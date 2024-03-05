using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using GY_BYD_WMS_API_DEMO.Framework;
//using static GY_BYD_WMS_API_DEMO.Framework.BYD_GY_WMS_Api_Base;

using GY_BYD_WMS_API_DEMO.Net;
using static GY_BYD_WMS_API_DEMO.Net.BYD_GY_WMS_Api_BaseNET;



namespace GY_BYD_WMS_API_DEMO
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			bool b;
			string str;
			Post_EquipmentStationBingAsset a = new Post_EquipmentStationBingAsset
			{
				EquipmentCode = "OCV2-1",
				PalletCode = "YAZ000001"
			};
			////Post_EquipmentStationBingAsset a = null; debug 测试为空状态下接口异常处理
			//(b, str) = BYD_GY_WMS_Api_Base.Converter.Serialize<Post_EquipmentStationBingAsset>(a);
			(b, str) = BYD_GY_WMS_Api_BaseNET.Converter.Serialize<Post_EquipmentStationBingAsset>(a);// net6

			textBox1.Text = str;
		


		}

		private void Button2_Click(object sender, EventArgs e)
		{
			string json = textBox2.Text;
			bool b;
			Return_BingAsset r;
			string str;
			//(b, r, str) = BYD_GY_WMS_Api_Base.Converter.Deserialize<Return_BingAsset>(json);
			(b, r, str) = BYD_GY_WMS_Api_BaseNET.Converter.Deserialize<Return_BingAsset>(json); //net6
			if (b)
			{ 
				string x = r.PileContent.Batterys[0].BatteryBarcode;
				textBox1.Text = x;
			}
			else { textBox1.Text = str; }
			
			
			
		}
	}
}
