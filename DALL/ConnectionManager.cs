﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class ConnectionManager
    {
        internal SqlConnection _conexion;
        public ConnectionManager(string connectionString)
        {
            _conexion = new SqlConnection(connectionString);
        }
        public void Open()
        {
            _conexion.Open();
        }
        public void Close()
        {
            _conexion.Close();
        }
    }
}
