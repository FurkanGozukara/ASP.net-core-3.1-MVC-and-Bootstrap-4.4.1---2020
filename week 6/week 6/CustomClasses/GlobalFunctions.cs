using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week_6.CustomClasses
{
    public static class GlobalFunctions
    {
        private static readonly IConfiguration _configuration;

        static GlobalFunctions()
        {
            _configuration = Startup.StaticConfig;
        }

        public static string returnGivenConfiguration(string srConfigKey)
        {
            try
            {
                return _configuration.GetValue<string>(srConfigKey);
            }
            catch  
            {
                return "Invalid Config Name";
            }
 
        }
    }
}
