using Newtonsoft.Json;
using System.IO.Compression;
using System.Text;

namespace CDClassLibrary.Tools
{
    public class ZipUp
    {
        //#region 压缩解压object
        /// <summary>
        /// 压缩字节
        /// </summary>
        /// <param name="DataOriginal"></param>
        /// <returns></returns>
        public static byte[] CompressionObject(object DataOriginal)
        {
            string str = JsonConvert.SerializeObject(DataOriginal);
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            var ms = new MemoryStream(bytes) { Position = 0 };
            var outms = new MemoryStream();
            using (var deflateStream = new DeflateStream(outms, CompressionMode.Compress, true))
            {
                var buf = new byte[1024];
                int len;
                while ((len = ms.Read(buf, 0, buf.Length)) > 0)
                    deflateStream.Write(buf, 0, len);
            }
            return outms.ToArray();
        }

        /// <summary>
        /// 解压缩字节
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static T? DecompressionObject<T>(byte[] bytes)
        {
            var ms = new MemoryStream(bytes) { Position = 0 };
            var outms = new MemoryStream();
            using (var deflateStream = new DeflateStream(ms, CompressionMode.Decompress, true))
            {
                var buf = new byte[1024];
                int len;
                while ((len = deflateStream.Read(buf, 0, buf.Length)) > 0)
                    outms.Write(buf, 0, len);
            }
            return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(outms.ToArray()));
        }
    }
}
