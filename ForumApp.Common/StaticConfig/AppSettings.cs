using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Common.StaticConfig
{
    public class AppSettings
    {
        public static string ApplicationDomain
        {
            get
            {
                return ConfigurationManager.AppSettings["appDomain"];
            }
        }

        public static string AudienceID
        {
            get
            {
                return ConfigurationManager.AppSettings["audienceId"];
            }
        }

        public static string SymmetricKey
        {
            get
            {
                return ConfigurationManager.AppSettings["SymmetricKey"];
            }
        }
    }
}