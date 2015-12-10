using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_WSP_WinForm_CSharp
{
    public interface ILogger
    {
        string Location {get;set;}
        void LogData(string data);
    }
}
