using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MPS_WSP_WinForm_CSharp
{
    public class ConfigReader
    {
        public string MerchantID = string.Empty;
        public string Password = string.Empty;
        public string MPSWSPURL = string.Empty;
        public string LoggingLocation = string.Empty;
        public string EndpointUrl = string.Empty;
        public string AuthorizationKey = string.Empty;

        public ConfigReader()
        {
            MerchantID = ConfigurationManager.AppSettings["MerchantID"];
            Password = ConfigurationManager.AppSettings["Password"];
            MPSWSPURL = ConfigurationManager.AppSettings["MPSWSPURL"];
            LoggingLocation = ConfigurationManager.AppSettings["LoggingLocation"];
            EndpointUrl = ConfigurationManager.AppSettings["EndpointUrl"];
            AuthorizationKey = ConfigurationManager.AppSettings["AuthorizationKey"];
             
        }
    }
}
