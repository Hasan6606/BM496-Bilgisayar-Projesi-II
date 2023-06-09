using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basinc_arayuz
{
    class Util
    {
        public static string GetAppValue(string key, string param = "")
        {
            string value = null;

            System.Collections.Specialized.NameValueCollection nameValueCollection = default(System.Collections.Specialized.NameValueCollection);

            nameValueCollection = System.Configuration.ConfigurationSettings.AppSettings;

            value = nameValueCollection[key];

            return value;
        }
    }
}
