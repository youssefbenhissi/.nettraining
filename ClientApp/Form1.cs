﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Formatting;
namespace ClientApp
{
    public partial class Form1 : Form
    {
        localhost.WebService1 proxy = new localhost.WebService1();
        HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }
        private void WebServiceSettings()
        {
            client.BaseAddress = new Uri("http://localhost:56405/WebService1.asmx/");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //string countriesJson = proxy.Countries();
            //DataTable dtCountries =  JsonConvert.DeserializeObject<DataTable>(countriesJson);

            //dataGridView1.DataSource = dtCountries;
            WebServiceSettings();
        }

        private DataTable stringSplit(string userJson)
        {
            string[] json = userJson.Split('>');
            string[] final = json[2].Split('<');
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(final[0]);
            return dt;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HttpResponseMessage message = client.GetAsync("dataTableForUsers?id=" + textBoxID.Text + "").Result;
            string userJson = message.Content.ReadAsStringAsync().Result;

            dataGridView1.DataSource = stringSplit(userJson);
        }
    }
}
