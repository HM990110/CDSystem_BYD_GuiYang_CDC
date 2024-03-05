using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WMSInterface.WCSWebApiClient
{
	

	internal class WMSWebApiClient
	{
		public enum WCSWebApiPostType
		{
			UploadWMSCombineInfo,
			QueryBatteryResult,
			QueryWMSCombineInfo,
			UnbindWMSCombineInfo,
			//[化成、分容]检测柜送货状态 
			NotifyCellWorkState,
			//[化成、分容]检测柜查询货位状态
			GetLocationState,
			//[化成、分容]检测柜获取托盘电池信息
			RequetWarehouseCellBingAsset,
			//[预充、OCV、DCIR]获取托盘电池信息
			RequetEquipmentStationBingAsset,
			//[化成、分容]检测柜调⽤WMS接⼝上传结果 
			UploadWarehouseTestResult,
			//[预充、OCV、DCIR]调⽤WMS接⼝上传OCV检测结果
			UploadOCVTestResult,
			//[DCIR]调⽤WMS接⼝上传DCIR检测结果
			UploadDCIRTestResult,
			//[化成、分容]调⽤⽕警报警接⼝
			NotifyWMSStandingFireAlarm,
			NotifyWMSFireAlarm,
			//[化成、分容]检测柜调⽤WMS 获取货位任务是否完成
			NotifyCellFinishTest,
			//[化成、分容]检测柜通知脱开针床
			RequestReleasePull,
			RequestStandardToolMove
		}

		private readonly HttpClient _httpClient;

		private readonly string _apiUrl;

		public WMSWebApiClient(string apiUrl)
		{
			_httpClient = new HttpClient();
			//
			if (string.IsNullOrEmpty(apiUrl))
			{ 
				_apiUrl = "http://172.17.20.243:8090/api/MERequest/"; 
			}
			else 
			{ 
				_apiUrl = apiUrl; 
			}
			_httpClient.Timeout = TimeSpan.FromSeconds(5);
		}

		public async Task<string> CallApiWithTypeAndParams(WCSWebApiPostType postType, Dictionary<string, object> parameters)
		{
			var content = new StringContent(JsonSerializer.Serialize(parameters), Encoding.UTF8, "application/json");
			var postUrl = _apiUrl + postType.ToString();
			try
			{
				var response = await _httpClient.PostAsync(postUrl, content);
				if (response.IsSuccessStatusCode)
				{
					return await response.Content.ReadAsStringAsync();
				}
				else
				{
					return await response.Content.ReadAsStringAsync();
				}
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}


		public async Task<string> CallApiWithParams(Dictionary<string, object> parameters)
		{
			var content = new StringContent(JsonSerializer.Serialize(parameters), Encoding.UTF8, "application/json");

			try
			{
				var response = await _httpClient.PostAsync(_apiUrl, content);
				if (response.IsSuccessStatusCode)
				{
					return await response.Content.ReadAsStringAsync();
				}
				else
				{
					// Handle the error  
					//throw new HttpRequestException($"Error calling API: {response.StatusCode}");
					// 处理超时等错误  

					if (response.StatusCode == HttpStatusCode.RequestTimeout)
					{
						throw new HttpRequestException($"API请求超时");
					}
					else
					{
						throw new HttpRequestException($"Error calling API: {response.StatusCode}");
					}
				}
			}
			catch (Exception ex)
			{
				// 处理异常  
				// 在这里可以引用异常对象 ex
				return ex.Message;
			}



		}
	}
}
