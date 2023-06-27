﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class Connection
    {

        /// <summary>
        /// App.config ConnectionStringi Çeken metod
        /// </summary>
        /// <returns></returns>
        static string GetConnectionStrings()
        {
            string connectionString = null;
            // app.confing connectionstring datası alıyor
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (!string.IsNullOrEmpty(cs.ConnectionString))
                        connectionString = cs.ConnectionString;
                }
            }
            return connectionString;
        }

        /// <summary>
        /// SqlConnection tipinden geri dönen metod. 
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ConnectionOpen()
        {
            SqlConnection baglanti = new SqlConnection(GetConnectionStrings());
            baglanti.Open();
            return baglanti;
        }

    }
}
