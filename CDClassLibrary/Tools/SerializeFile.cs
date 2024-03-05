using CDClassLibrary.Stage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CDClassLibrary.Tools
{
    /// <summary>
    /// 文件序列化与反序列化
    /// </summary>
    public class SerializeFile
    {
        /// <summary>
        /// 将对象序列化
        /// </summary>
        /// <param name="FilePath">文件(支持绝大多数数据类型)</param>
        /// <param name="obj">要序列化的对象(如哈希表,数组等等)</param>
        public static void FileSerialize(string FilePath, object obj)
        {
            //if (System.IO.File.Exists(FilePath))
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
            }
            FileStream fs = new(FilePath, FileMode.Create);
            BinaryFormatter sl = new();
            try
            {
                sl.Serialize(fs, obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine("1039:" + ex.Message);
                GlobalFunction.ErrorLogAdd("", "序列化存储失败", ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// 将文件反序列化
        /// </summary>
        /// <param name="FilePath">文件路径(必须是经过当前序列化后的文件)</param>
        /// <returns>返回 null 表示序列反解失败或者目标文件不存在</returns>
        public static object? FileDeSerialize(string FilePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
            }
            if (System.IO.File.Exists(FilePath))
            {

                FileStream fs = new(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter sl = new();
                try
                {
                    object obg = sl.Deserialize(fs);
                    return obg;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("1040:" + ex.Message);
                    GlobalFunction.ErrorLogAdd("", "文件反序列化", "地址<" + FilePath + ">" + ex.Message);
                    return null;
                }
                finally
                {
                    fs.Close();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
