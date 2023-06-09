using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basinc_arayuz
{
    class Session
    {
        private static string _connectionString;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = Util.GetAppValue("ConnStr");
                }

                return _connectionString;
            }
        }
    }
}
