using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MPS_WSP_WinForm_CSharp
{
    public class LogData
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Info { get; set; }
        public DateTime DateInfo { get; set; }
        public string Severity { get; set; }
    }
}
