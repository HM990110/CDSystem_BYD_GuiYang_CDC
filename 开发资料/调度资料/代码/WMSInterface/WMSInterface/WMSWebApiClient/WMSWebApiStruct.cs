using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSInterface.WCSWebApiClient
{
	internal class WMSWebApiStruct
	{
		#region 通用结构体
		//统一返回结构体
		struct Post_ReturnInfo
		{
			public int result;
			public string message;
		}

		//统一返回结构体待数据
		struct Post_ReturnInfoWithData
		{
			public int result;
			public string message;
			public string pileContent;
		}

		public struct OneBatteryTestResult
		{
			//string 不可空 电芯条码
			public string BatteryBarcode;
			//0=NG 1=OK
			public int Result;
			//NG代码
			public string BatteryNGCode;
			//电池位置
			public int BatteryIndex;
		}



		//struct Post_Return_PileContent
		#endregion

		#region 化成 分容部分

		#region 获取库位状态方法[GetLocationState] 相关
		//Post结构体 
		struct Post_GetLocationState
		{
			public string zone;
			public int row;
		}
		//返回结构体 
		struct Post_ReturnInfoWithsLocationState
		{
			public int result;
			public string message;
			public string locationStates;
		}
		//库位状态  搭配Post_ReturnInfoWithsLocationState使用
		struct Post_Return_LocationCode
		{
			public string locationCode;
			public int state;
		}
		#endregion

		#region 检测柜推送货位状态[NotifyCellWorkState] 相关
		//上报库位状态结构体
		struct Post_WorkStates
		{
			//区域（单字母） N=化成区域 R=分容区域
			public string Zone;
			//排
			public int Row;
			//列
			public int Col;
			//层
			public int Layer;
			//深度 这边库位只有一个托盘 深度默认1
			public int Depth;
			//库位状态 1=空闲  2=⼯作中 3=异常 4=维修
			public int StatusCode;
			//设备异常信息
			public string Message;
		}
		#endregion

		#region 检测柜获取托盘电池信息[RequetWarehouseCellBingAsset] 相关
		struct Post_RequetWarehouseCellBingAsset
		{
			//区域（单字母） N=化成区域 R=分容区域
			public string Zone;
			//排
			public int Row;
			//列
			public int Col;
			//层
			public int Layer;
			//深度 这边库位只有一个托盘 深度默认1
			public int Depth;

		}

		public struct OneBattery
		{
			//电芯条码
			public string BatteryBarcode;
			//通道位置 1~196
			public int PalletIndex;
			//电芯真假 0=假电芯 1=真电芯[默认]
			public int IsRealBattery;
			//前工序测试结果 0=OK 1=NG
			public int IsNg; 
		}
		public class PalletContent
		{
			//托盘条码
			public string PalletBarcode = "";
			//测试⼯艺号
			public string FileName = "";
			//电池类型(型号)
			public string BatteryType = "";
			//托盘⾥的电池数据集
			public OneBattery[]? Batterys;
		}

		#endregion

		#region 检测柜调⽤WMS接⼝上传结果
		

		public class UploadWareHouseTestResult
		{
			public string? Zone; //区域
			public int Row; //排
			public int Col; //列
			public int Layer; //层
			public int Depth; //深位 默认1
			public string? PalletBarcode; //托盘条码
			public List<OneBatteryTestResult>? BatteryTestResults; //电池测试结果列表			
			public string? FileName; //⼯艺号
			public int BatteryTestFlag; //托盘OK、NG标识 1=OK 0=NG
			public string? BatteryType; //电池类型
		}

		//检测柜调⽤WMS接⼝上传结果

		#endregion

		#region 调⽤WMS接⼝上传OCV检测结果[UploadOCVTestResult]

		#endregion

		#endregion


	}

}
