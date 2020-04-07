using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week_6.CustomClasses
{
    public static class GlobalFunctions
    {
        public static readonly string srUserInfoKey = "user_login";

        public static SiteConfiguration siteConfig;

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

        public static void SetSessionData(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetSessionData<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
