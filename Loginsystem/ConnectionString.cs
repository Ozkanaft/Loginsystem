﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginsystem
{
    public class ConnectionString
    {
        private string connectionString = @"Password=123456;Persist Security Info=True;User ID=User;Initial Catalog=DB;Data Source=80.128.100.54,1433";

        public string Connection_Today()
        {
            return connectionString;
        }

    }
}