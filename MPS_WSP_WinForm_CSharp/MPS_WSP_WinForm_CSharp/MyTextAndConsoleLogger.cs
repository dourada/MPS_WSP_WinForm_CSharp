using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MPS_WSP_WinForm_CSharp
{
    public class MyTextAndConsoleLogger : ILogger
    {
        string _location = string.Empty;

        void ILogger.LogData(string data)
        {
            try
            {
                if (!Directory.Exists(_location))
                {
                    Directory.CreateDirectory(_location);
                }

                using (StreamWriter w = File.AppendText(_location + "\\" + "log.txt"))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                        DateTime.Now.ToLongDateString());
                    w.WriteLine("  :");
                    w.WriteLine("  :{0}", data);
                    w.WriteLine("-------------------------------");
                }

                Console.WriteLine("--------");
                Console.WriteLine(data);
                Console.WriteLine("--------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
