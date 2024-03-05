using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace GY_BYD_WMS_API_DEMO.Framework
{
	internal class BYD_GY_WMS_Api_Base
	{
		/// <summary>
		/// 电芯数据
		/// </summary>
		public class OneBattery
		{
			[JsonProperty("batteryBarcode")]
			public string BatteryBarcode { get; set; }

			[JsonProperty("palletIndex")]
			public long PalletIndex { get; set; }

			[JsonProperty("isRealBattery")]
			public long IsrealBattery { get; set; }

			[JsonProperty("isNg")]
			public long IsNg { get; set; }

			[JsonProperty("batteryType")]
			public string BatteryType { get; set; }

			[JsonProperty("nodeCode")]
			public string NodeCode { get; set; }
		}

		/// <summary>
		/// 托盘数据
		/// </summary>
		public class PalletContent
		{
			[JsonProperty("palletBarcode")]
			public string PalletBarcode { get; set; }

			[JsonProperty("fileName")]
			public string FileName { get; set; }

			[JsonProperty("batteryType")]
			public string BatteryType { get; set; }

			[JsonProperty("batterys")]
			public OneBattery[] Batterys { get; set; }
		}

		/// <summary>
		/// 充放电库位[化成、分容]设备 托盘数据请求Json类
		/// </summary>
		public class Post_WarehouseCellBingAsset
		{
			[JsonProperty("zone")]
			public string Zone { get; set; }

			[JsonProperty("row")]
			public long Row { get; set; }

			[JsonProperty("col")]
			public long Col { get; set; }

			[JsonProperty("layer")]
			public long Layer { get; set; }

			[JsonProperty("depth")]
			public long Depth { get; set; }
		}

		/// <summary>
	/// 单机[预充、OCV、DCIR]设备 托盘数据请求Json类
	/// </summary>
		public class Post_EquipmentStationBingAsset
		{
			[JsonProperty("palletCode")]
			public string PalletCode { get; set; }

			[JsonProperty("equipmentCode")]
			public string EquipmentCode { get; set; }
		}

		/// <summary>
		/// 通用托盘数据返回对象类
		/// </summary>
		public class Return_BingAsset
		{
			[JsonProperty("result")]
			public long Result { get; set; }

			[JsonProperty("message")]
			public string Message { get; set; }

			[JsonProperty("pileContent")]
			public PalletContent PileContent { get; set; }
		}

		public class Converter
		{
			/// <summary>
			/// json字符串反序列化为对象
			/// </summary>
			/// <typeparam name="T">对象类型</typeparam>
			/// <param name="json">对象</param>
			/// <returns>(返回结果，返回对象，返回信息) </returns>
			public static (bool, T, string) Deserialize<T>(string json)
			{
				//T result;
				Type type = typeof(T);
				bool returnResult = false;
				T returnObj = default;
				string returnStr = "";
				if((json != null)&&(json != ""))
				{
					try
					{
						returnObj = JsonConvert.DeserializeObject<T>(json);
						returnResult = true;
					}
					catch(Exception ex)
					{
						returnStr = $"反序列化类{type.Name}异常,异常内容[{ex.Message}]";
					}
				}
				else
				{
					returnStr = $"反序列化类{type.Name}的json字符串为空";
				}
				return (returnResult, returnObj, returnStr);			
			}

			/// <summary>
			/// 对象序列化为json字符串
			/// </summary>
			/// <typeparam name="T">对象类型</typeparam>
			/// <param name="obj">对象</param>
			/// <returns>(返回结果，返回对象，返回信息)</returns>
			public static (bool, string) Serialize<T>(T obj)
			{
				Type type = typeof(T);
				bool returnResult = false;
				string returnStr;
				if (obj != null)
				{
					try 
					{ 
						returnStr = JsonConvert.SerializeObject(obj);
						returnResult = true;
					}
					catch(Exception ex) 
					{
						returnStr = $"序列化类[{type.Name}]异常,异常内容[{ex.Message}]";
					}
				}
				else
				{
					returnStr = $"序列化类[{type.Name}]为空";
				}
				return (returnResult, returnStr);
				
			}
		}
	}
}
