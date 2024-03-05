using CDClassLibrary.Data;
using CDClassLibrary.Language;
using CDClassLibrary.Log;
using CDClassLibrary.Tools;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace CDClassLibrary.Stage
{
    public class GlobalFunction
    {
        /// <summary>
        /// struct转换为byte[]
        /// </summary>
        /// <param name="structObj"></param>
        /// <returns></returns>
        public static byte[] StructToBytes(object structObj)
        {
            int size = Marshal.SizeOf(structObj);
            IntPtr buffer = Marshal.AllocHGlobal(size); //中间变量
            try
            {
                Marshal.StructureToPtr(structObj, buffer, false);
                byte[] bytes = new byte[size];
                Marshal.Copy(buffer, bytes, 0, size);
                return bytes;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// <summary>
        /// byte[]转换为struct
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="strcutType"></param>
        /// <returns></returns>
        public static object? BytesToStruct(byte[] bytes, Type strcutType)
        {
            int size = Marshal.SizeOf(strcutType);
            IntPtr buffer = Marshal.AllocHGlobal(size); //中间变量
            try
            {
                Marshal.Copy(bytes, 0, buffer, size);
                return Marshal.PtrToStructure(buffer, strcutType);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        public static void Language()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(GlobalDefine.Lang.ToString());
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(GlobalDefine.Lang.ToString());

            GlobalParams.Res = new System.Resources.ResourceManager("CDClassLibrary.Language.ResourceLang", typeof(ResourceLang).Assembly);
        }

        public static string GetValue(Enum enumValue)
        {
            string name = EnumHelper.GetEnumDescription(enumValue);
            string Value = GlobalParams.Res.GetString(name) ?? enumValue.ToString();
            return Value;
        }

        public static void GetConfig()
        {
            if (!Directory.Exists(GlobalDefine.SystemPath))
                Directory.CreateDirectory(GlobalDefine.SystemPath);

            IniFileHM ConfigFile = new(GlobalDefine.ConfigFile);

            string[] keys = ConfigFile.INIGetAllItemKeys("Config");

            if (keys.Contains("Lang"))
                GlobalDefine.Lang = Enum.Parse<Lang>(ConfigFile.INIGetStringValue("Config", "Lang", Lang.zh.ToString()));
            else
                ConfigFile.INIWriteValue("Config", "Lang", Lang.zh.ToString());

            if (keys.Contains("WMSIP"))
                GlobalDefine.WMSIP = ConfigFile.INIGetStringValue("Config", "WMSIP", "192.168.255.1");
            else
                ConfigFile.INIWriteValue("Config", "WMSIP", "192.168.255.1");

            if (keys.Contains("MESIP"))
                GlobalDefine.MESIP = ConfigFile.INIGetStringValue("Config", "MESIP", "192.168.255.1");
            else
                ConfigFile.INIWriteValue("Config", "MESIP", "192.168.255.1");

            if (keys.Contains("LNSTNO"))
                GlobalDefine.LNSTNO = ConfigFile.INIGetStringValue("Config", "LNSTNO", 1);
            else
                ConfigFile.INIWriteValue("Config", "LNSTNO", 1);

            if (keys.Contains("DVSTNO"))
                GlobalDefine.DVSTNO = ConfigFile.INIGetStringValue("Config", "DVSTNO", 1);
            else
                ConfigFile.INIWriteValue("Config", "DVSTNO", 1);

            if (keys.Contains("UpdateInterval"))
                GlobalDefine.UpdateInterval = ConfigFile.INIGetStringValue("Config", "UpdateInterval", 10);
            else
                ConfigFile.INIWriteValue("Config", "UpdateInterval", 10);

            if (keys.Contains("VoltInterval"))
                GlobalDefine.VoltInterval = ConfigFile.INIGetStringValue("Config", "VoltInterval", 10);
            else
                ConfigFile.INIWriteValue("Config", "VoltInterval", 10);

            if (keys.Contains("CurreInterval"))
                GlobalDefine.CurreInterval = ConfigFile.INIGetStringValue("Config", "CurreInterval", 10);
            else
                ConfigFile.INIWriteValue("Config", "CurreInterval", 30);

            if (keys.Contains("OperationMode"))
                GlobalDefine.OperationMode = ConfigFile.INIGetStringValue("Config", "OperationMode", true);
            else
                ConfigFile.INIWriteValue("Config", "OperationMode", true);

            if (keys.Contains("NOCellchannelVolt"))
                GlobalDefine.NOCellchannelVolt = ConfigFile.INIGetStringValue("Config", "NOCellchannelVolt", 300);
            else
                ConfigFile.INIWriteValue("Config", "NOCellchannelVolt", 300);

            int NUM_DEVICEPERLINE = 10;
            if (keys.Contains("NUM_DEVICEPERLINE"))
                NUM_DEVICEPERLINE = ConfigFile.INIGetStringValue("Config", "NUM_DEVICEPERLINE", 10);
            else
                ConfigFile.INIWriteValue("Config", "NUM_DEVICEPERLINE", 10);

            int NUM_STAGEPERDEVICE = 10;
            if (keys.Contains("NUM_STAGEPERDEVICE"))
                NUM_STAGEPERDEVICE = ConfigFile.INIGetStringValue("Config", "NUM_STAGEPERDEVICE", 10);
            else
                ConfigFile.INIWriteValue("Config", "NUM_STAGEPERDEVICE", 10);

            GlobalDefine.NumAllSTAGES(NUM_DEVICEPERLINE, NUM_STAGEPERDEVICE);
        }

        public static bool SetNOCellchannelVolt()
        {
            if (!Directory.Exists(GlobalDefine.SystemPath))
                Directory.CreateDirectory(GlobalDefine.SystemPath);

            IniFileHM ConfigFile = new(GlobalDefine.ConfigFile); 

            return ConfigFile.INIWriteValue("Config", "NOCellchannelVolt", GlobalDefine.NOCellchannelVolt);
        }

        public static void GetParameterLimit()
        {
            GlobalDefine.ParameterLimit = (TParameterLimit)SerializeFile.FileDeSerialize(GlobalDefine.ParameterLimitFile);
            if (GlobalDefine.ParameterLimit == null || GlobalDefine.ParameterLimit.Limits == null)
            {
                GlobalDefine.ParameterLimit = new TParameterLimit();
                SetParameterLimit();
            }
        }

        public static void SetParameterLimit()
        {
            SerializeFile.FileSerialize(GlobalDefine.ParameterLimitFile, GlobalDefine.ParameterLimit);
        }

        public static void SendConfig(int FStageID)
        {
            new Thread(() =>
            {
                if (GlobalParams.CommMCU[FStageID].IsConnected())
                {
                    GlobalParams.CommMCU[FStageID].SetTempSmogLimitAll(GlobalDefine.ParameterLimit.Limits[FStageID].ATempLimit, GlobalDefine.ParameterLimit.Limits[FStageID].ACellTempLimit, GlobalDefine.ParameterLimit.Limits[FStageID].ASmogLimit);
                    GlobalParams.CommMCU[FStageID].WaterPIDControl(GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKp, GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKi, GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDKd, GlobalDefine.ParameterLimit.Limits[FStageID].WaterPID.PIDT);
                    GlobalParams.CommMCU[FStageID].WaterDoorTarget(GlobalDefine.ParameterLimit.Limits[FStageID].WaterTargetTempValue);
                    GlobalParams.CommMCU[FStageID].TimeSyn();
                    /*
                        GlobalParams.CommMCU[FStageID].VacuumFix(FStageNo, GlobalDefine.Config.stageConfigs[FStageID].VacuumFix);
                        GlobalParams.CommMCU[FStageID].NegatPrePID(FStageNo, GlobalDefine.Config.stageConfigs[FStageID].NegatPrePID);
                    */
                }
            }).Start();
        }

        public static void GetNGCount()
        {
            var Obj = SerializeFile.FileDeSerialize(GlobalDefine.NGCountFile);

            if (Obj == null)
            {
                GlobalDefine.DeviceNGCount = new TDeviceNGCount();
            }
            else
            {
                GlobalDefine.DeviceNGCount = (TDeviceNGCount)Obj;

                bool boo = true;
                if (GlobalDefine.DeviceNGCount.NGCount == null || GlobalDefine.DeviceNGCount.NGCount.Length != GlobalDefine.NUM_ALLSTAGES)
                {
                    boo = false;
                    int[][] NGCount = new int[GlobalDefine.NUM_ALLSTAGES][];
                    for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                    {
                        NGCount[FStageID] = new int[GlobalDefine.CHANNELS];
                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            NGCount[FStageID][ChnNo] = 0;
                    }
                    GlobalDefine.DeviceNGCount.NGCount = NGCount;
                }
                if (GlobalDefine.DeviceNGCount.ContactCount == null || GlobalDefine.DeviceNGCount.ContactCount.Length != GlobalDefine.NUM_ALLSTAGES)
                {
                    boo = false;
                    int[][] ContactCount = new int[GlobalDefine.NUM_ALLSTAGES][];
                    for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                    {
                        ContactCount[FStageID] = new int[GlobalDefine.CHANNELS];
                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            ContactCount[FStageID][ChnNo] = 0;
                    }
                    GlobalDefine.DeviceNGCount.ContactCount = ContactCount;
                }
                if (GlobalDefine.DeviceNGCount.RunCount == null || GlobalDefine.DeviceNGCount.RunCount.Length != GlobalDefine.NUM_ALLSTAGES)
                {
                    boo = false;
                    int[][] RunCount = new int[GlobalDefine.NUM_ALLSTAGES][];
                    for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                    {
                        RunCount[FStageID] = new int[GlobalDefine.CHANNELS];
                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            RunCount[FStageID][ChnNo] = 0;
                    }
                    GlobalDefine.DeviceNGCount.RunCount = RunCount;
                }
                if (GlobalDefine.DeviceNGCount.UpKeepCount == null || GlobalDefine.DeviceNGCount.UpKeepCount.Length != GlobalDefine.NUM_ALLSTAGES)
                {
                    boo = false;
                    int[][] UpKeepCount = new int[GlobalDefine.NUM_ALLSTAGES][];
                    for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                    {
                        UpKeepCount[FStageID] = new int[GlobalDefine.CHANNELS];
                        for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            UpKeepCount[FStageID][ChnNo] = 0;
                    }
                    GlobalDefine.DeviceNGCount.UpKeepCount = UpKeepCount;
                }
                if (!boo)
                {
                    SetNGCount();
                }

                {
                    boo = true;
                    for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                    {
                        if (GlobalDefine.DeviceNGCount.NGCount[FStageID].Length != GlobalDefine.CHANNELS &&
                            GlobalDefine.DeviceNGCount.UpKeepCount[FStageID].Length != GlobalDefine.CHANNELS &&
                            GlobalDefine.DeviceNGCount.ContactCount[FStageID].Length != GlobalDefine.CHANNELS &&
                            GlobalDefine.DeviceNGCount.RunCount[FStageID].Length != GlobalDefine.CHANNELS)
                        {
                            GlobalDefine.DeviceNGCount.NGCount[FStageID] = new int[GlobalDefine.CHANNELS];
                            GlobalDefine.DeviceNGCount.UpKeepCount[FStageID] = new int[GlobalDefine.CHANNELS];
                            GlobalDefine.DeviceNGCount.ContactCount[FStageID] = new int[GlobalDefine.CHANNELS];
                            GlobalDefine.DeviceNGCount.RunCount[FStageID] = new int[GlobalDefine.CHANNELS];
                            for (int ChnNo = 0; ChnNo < GlobalDefine.CHANNELS; ChnNo++)
                            {
                                GlobalDefine.DeviceNGCount.NGCount[FStageID][ChnNo] = 0;
                                GlobalDefine.DeviceNGCount.UpKeepCount[FStageID][ChnNo] = 0;
                                GlobalDefine.DeviceNGCount.ContactCount[FStageID][ChnNo] = 0;
                                GlobalDefine.DeviceNGCount.RunCount[FStageID][ChnNo] = 0;
                            }
                            boo = false;
                        }
                    }
                    if (!boo)
                    {
                        SetNGCount();
                    }
                }
            }
        }

        public static void SetNGCount()
        {
            SerializeFile.FileSerialize(GlobalDefine.NGCountFile, GlobalDefine.DeviceNGCount);
        }

        public static string ToStageNo(int FStageID)
        {
            int Row = FStageID % GlobalDefine.NUM_DEVICEPERLINE;
            int Column = FStageID / GlobalDefine.NUM_DEVICEPERLINE;
            string FStageNo = GlobalDefine.LNSTNO.ToString().PadLeft(2, '0') + (GlobalDefine.DVSTNO + Column).ToString().PadLeft(3, '0') + (Row + 1).ToString().PadLeft(2, '0');
            return FStageNo;
        }

        public static void SetMapping()
        {
            SerializeFile.FileSerialize(GlobalDefine.MappingFile, GlobalDefine.Mapping);
        }

        public static void GetMapping()
        {
            GlobalDefine.Mapping = (int[])SerializeFile.FileDeSerialize(GlobalDefine.MappingFile);
            if (GlobalDefine.Mapping == null || GlobalDefine.Mapping.Length != GlobalDefine.CHANNELS)
            {
                GlobalDefine.Mapping = new int[GlobalDefine.CHANNELS];
                for (int i = 0; i < GlobalDefine.CHANNELRow; i++)
                {
                    for (int j = 0; j < GlobalDefine.CHANNELColumn; j++)
                    {
                        int x = j + i * GlobalDefine.CHANNELColumn_MCU;
                        int v = j + i * GlobalDefine.CHANNELColumn;
                        GlobalDefine.Mapping[v] = x;
                    }
                }
                SerializeFile.FileSerialize(GlobalDefine.MappingFile, GlobalDefine.Mapping);
            }
        }

        public static void SetIP()
        {
            SerializeFile.FileSerialize(GlobalDefine.IPFile, GlobalDefine.IPs);
        }

        public static void GetIP()
        {
            GlobalDefine.IPs = (string[])SerializeFile.FileDeSerialize(GlobalDefine.IPFile);
            if (GlobalDefine.IPs == null || GlobalDefine.IPs.Length != GlobalDefine.NUM_ALLSTAGES)
            {
                GlobalDefine.IPs = new string[GlobalDefine.NUM_ALLSTAGES];
                for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                {
                    GlobalDefine.IPs[FStageID] = "192.168.123." + (FStageID + 1);
                }
                SetIP();
            }
        }

        public static void SetDeviceType()
        {
            SerializeFile.FileSerialize(GlobalDefine.DeviceTypeFile, GlobalDefine.DeviceTypes);
        }

        public static void GetDeviceType()
        {
            var obj = SerializeFile.FileDeSerialize(GlobalDefine.DeviceTypeFile);
            if (obj != null)
                GlobalDefine.DeviceTypes = (TDeviceType[])obj;
            else
                GlobalDefine.DeviceTypes = Array.Empty<TDeviceType>();
            if (GlobalDefine.DeviceTypes.Length != GlobalDefine.NUM_ALLSTAGES)
            {
                GlobalDefine.DeviceTypes = new TDeviceType[GlobalDefine.NUM_ALLSTAGES];
                for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                {
                    GlobalDefine.DeviceTypes[FStageID] = TDeviceType.CDC2;
                }
                SetDeviceType();
            }
        }

        public static void SetVacancyFlag()
        {
            SerializeFile.FileSerialize(GlobalDefine.VacancyFlagFile, GlobalDefine.VacancyFlags);
        }

        public static void GetVacancyFlag()
        {
            var obj = SerializeFile.FileDeSerialize(GlobalDefine.VacancyFlagFile);
            if (obj != null)
                GlobalDefine.VacancyFlags = (bool[])obj;
            else
                GlobalDefine.VacancyFlags = Array.Empty<bool>();
            if (GlobalDefine.VacancyFlags.Length != GlobalDefine.NUM_ALLSTAGES)
            {
                GlobalDefine.VacancyFlags = new bool[GlobalDefine.NUM_ALLSTAGES];
                for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                {
                    GlobalDefine.VacancyFlags[FStageID] = false;
                }
                SetVacancyFlag();
            }
        }

        public static void SetManualAutoFlag()
        {
            SerializeFile.FileSerialize(GlobalDefine.ManualAutoFlagFile, GlobalDefine.ManualAutoFlags);
        }

        public static void GetManualAutoFlag()
        {
            GlobalDefine.ManualAutoFlags = (bool[])SerializeFile.FileDeSerialize(GlobalDefine.ManualAutoFlagFile);
            if (GlobalDefine.ManualAutoFlags == null || GlobalDefine.ManualAutoFlags.Length != GlobalDefine.NUM_ALLSTAGES)
            {
                GlobalDefine.ManualAutoFlags = new bool[GlobalDefine.NUM_ALLSTAGES];
                for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
                {
                    GlobalDefine.ManualAutoFlags[FStageID] = false;
                }
                SetManualAutoFlag();
            }
        }

        public static void SetProcesses(string ProcessFile)
        {
            SerializeFile.FileSerialize(GlobalDefine.ProcessPath + ProcessFile + ".dat", GlobalParams.ProcessGroup.First((b) => b.ProcessName == ProcessFile));
        }

        public static void GetProcessGroup()
        {
            GlobalParams.ProcessGroup = new List<TProcessGroup>();
            if (!Directory.Exists(GlobalDefine.ProcessPath))
                Directory.CreateDirectory(GlobalDefine.ProcessPath);
            DirectoryInfo directory = new(GlobalDefine.ProcessPath);
            foreach (FileInfo file in directory.GetFiles())
            {
                GetProcessGroup(file.FullName, file.Name.Split('.')[0]);
            }
        }

        public static bool GetProcessGroup(string ProcessFile, string FileName)
        {
            var obj = SerializeFile.FileDeSerialize(ProcessFile);
            if (obj != null)
            {
                try
                {
                    TProcessGroup processGroup = (TProcessGroup)obj;
                    processGroup.ProcessName = FileName;
                    GlobalParams.ProcessGroup.Add(processGroup);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void GetStage()
        {
            for (int FStageID = 0; FStageID < GlobalDefine.NUM_ALLSTAGES; FStageID++)
            {
                var obj = SerializeFile.FileDeSerialize(GlobalDefine.StagePath + FStageID + ".dat");
                if (obj != null)
                {
                    if (File.Exists(GlobalDefine.StagePath + FStageID + ".dat"))
                        File.Delete(GlobalDefine.StagePath + FStageID + ".dat");
                    GlobalParams.GStages[FStageID] = (ThreadStage)obj;
                }
                else
                    GlobalParams.GStages[FStageID] = new ThreadStage();
                GlobalParams.GStages[FStageID].ThreadStageInfo(FStageID);
            }
        }

        public static void RunLogAdd(string fStageNo, string lType, string lMessage = "")
        {
            LogHelper logHelper = new(fStageNo, lType, lMessage);
            GlobalParams.RunLog.Add(logHelper);
            LogHelper.WriteRunLog(logHelper);
        }

        public static void AlarmLogAdd(string fStageNo, string lType, string lMessage = "")
        {
            LogHelper logHelper = new(fStageNo, lType, lMessage);
            GlobalParams.AlarmLog.Add(logHelper);
            LogHelper.WriteAlarmLog(logHelper);
        }

        public static void ErrorLogAdd(string fStageNo, string lType, string lMessage = "")
        {
            LogHelper logHelper = new(fStageNo, lType, lMessage);
            GlobalParams.ErrorLog.Add(logHelper);
            LogHelper.WriteErrorLog(logHelper);
        }

        public static void MesLogAdd(string fStageNo, string lType, string lMessage = "")
        {
            LogHelper logHelper = new(fStageNo, lType, lMessage);
            GlobalParams.MesLog.Add(logHelper);
            LogHelper.WriteMesLog(logHelper);
        }
    }

    public enum TDeviceType : byte
    {
        CDC2,
        CDC3,
    }
}
