using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADO
    {
        protected string _connectionString;
        public BaseADO()
            {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connectionString = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            }
    }
}
