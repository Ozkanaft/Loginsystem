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
        private string connectionString = @"Password=123456;Persist Security Info=True;User ID=User;Initial Catalog=DB;Data Source=93.200.63.175,1433";

        public string Connection_Today()
        {
            return connectionString;
        }

    }
}
