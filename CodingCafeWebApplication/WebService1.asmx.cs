﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
namespace CodingCafeWebApplication
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtCountries = new DataTable();
        DBAccess objDBAcces = new DBAccess();
        DataTable dtUsers = new DataTable();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int sum(int a , int b)
        {
            return a+b;
        }

        [WebMethod]
        public string Countries()
        {
            dtCountries.Columns.Add("CountryName");
            dtCountries.Columns.Add("Continent");
            dtCountries.Rows.Add("Pakistan", "Asia");
            dtCountries.Rows.Add("France", "Europe");
            dtCountries.Rows.Add("Tunisia", "Africa");


            return JsonConvert.SerializeObject(dtCountries);
        }

        [WebMethod]
        public string dataTableForUsers(string id)
        {
            string query = "Select * From Users WHERE ID = '" + id + "'";
            objDBAcces.readDatathroughAdapter(query, dtUsers);
            return JsonConvert.SerializeObject(dtUsers);
        }
    }
}
