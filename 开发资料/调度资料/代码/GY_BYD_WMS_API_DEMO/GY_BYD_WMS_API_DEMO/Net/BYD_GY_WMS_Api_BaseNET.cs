using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GY_BYD_WMS_API_DEMO.Net
{
	internal class BYD_GY_WMS_Api_BaseNET
	{   
		
		/// <summary>
		/// 电芯数据
		/// </summary>
		public class OneBattery
		{
			[JsonPropertyName("batteryBarcode")]
			public string BatteryBarcode { get; set; }

			[JsonPropertyName("palletIndex")]
			public long PalletIndex { get; set; }

			[JsonPropertyName("isRealBattery")]
			public long IsrealBattery { get; set; }

			[JsonPropertyName("isNg")]
			public long IsNg { get; set; }

			[JsonPropertyName("batteryType")]
			public string BatteryType { get; set; }

			[JsonPropertyName("nodeCode")]
			public string NodeCode { get; set; }
		}

		/// <summary>
		/// 托盘数据
		/// </summary>
		public class PalletContent
		{
			[JsonPropertyName("palletBarcode")]
			public string Palletbarcode { get; set; }

			[JsonPropertyName("fileName")]
			public string FileName { get; set; }

			[JsonPropertyName("batteryType")]
			public string BatteryType { get; set; }

			[JsonPropertyName("batterys")]
			public OneBattery[] Batterys { get; set; }
		}

		/// <summary>
		/// 充放电库位[化成、分容]设备 托盘数据请求Json类
		/// </summary>
		public class Post_WarehouseCellBingAsset
		{
			[JsonPropertyName("zone")]
			public string Zone { get; set; }

			[JsonPropertyName("row")]
			public long Row { get; set; }

			[JsonPropertyName("col")]
			public long Col { get; set; }

			[JsonPropertyName("layer")]
			public long Layer { get; set; }

			[JsonPropertyName("depth")]
			public long Depth { get; set; }
		}

		/// <summary>
		/// 单机[预充、OCV、DCIR]设备 托盘数据请求Json类
		/// </summary>
		public class Post_EquipmentStationBingAsset
		{
			[JsonPropertyName("palletCode")]
			public string PalletCode { get; set; }

			[JsonPropertyName("equipmentCode")]
			public string EquipmentCode { get; set; }
		}

		/// <summary>
		/// 通用托盘数据返回对象类
		/// </summary>
		public class Return_BingAsset
		{
			[JsonPropertyName("result")]
			public long Result { get; set; }

			[JsonPropertyName("message")]
			public string Message { get; set; }

			[JsonPropertyName("pileContent")]
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
				if ((json != null) && (json != ""))
				{
					try
					{

						returnObj = JsonSerializer.Deserialize<T>(json);
						returnResult = true;
					}
					catch (Exception ex)
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
						
						returnStr = JsonSerializer.Serialize(obj);
						returnResult = true;
					}
					catch (Exception ex)
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
