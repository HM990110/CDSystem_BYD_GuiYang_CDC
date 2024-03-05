using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net;
using System.Linq.Expressions;

namespace WMSInterface
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 
	public class WebApiClient
	{
		private readonly HttpClient _httpClient;
		private readonly string _apiUrl;

		public WebApiClient(string apiUrl)
		{
			_httpClient = new HttpClient();
			_apiUrl = apiUrl; //http://172.17.20.243:8090/api/MERequest/
			_httpClient.Timeout = TimeSpan.FromSeconds(5);
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

	public partial class MainWindow : Window
	{
		private WebApiClient _webApiClient;
		public MainWindow()
		{
			InitializeComponent();
			_webApiClient = new WebApiClient("http://172.17.20.243:8090/api/MERequest/");
		}

		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				_webApiClient = new WebApiClient("http://172.17.20.243:8090/api/MERequest/RequetEquipmentStationBingAsset");
				var result = await _webApiClient.CallApiWithParams(new Dictionary<string, object> { { "palletCode", "YZA00001" }, { "equipmentCode", "YC01" } });
				MessageBox.Show(result);
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Error calling API: {ex.Message}");
			}
		}
	}
}
