using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_bank.Data
{
    public class PostgreSQLConfiguration
    {
        public PostgreSQLConfiguration(string connectionString) => ConnectionString = connectionString;
        public string ConnectionString { get; set; }
    }
}
