﻿using System.Configuration;

namespace DataAccess
{
    public static class ConnectionStringProvider
    {
        public static string Get() =>
            ConfigurationManager.ConnectionStrings["test22"].ConnectionString;
    }
}
