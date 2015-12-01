using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MPS_WSP_WinForm_CSharp
{
    public partial class Form1 : Form
    {
        ConfigReader configReader;

        public Form1()
        {
            InitializeComponent();
            configReader = new ConfigReader();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            txtLog.Text += "Selected Checkout." + DateTime.Now.ToString();

            var mpsWS = new MPSWebService.wsSoapClient();
            var xmlRequest = @"<TStream>
                                  <Transaction>
                                      <MerchantID>{0}</MerchantID>
                                      <OperatorID>dano</OperatorID>
                                      <TranType>Credit</TranType>
                                      <TranCode>Sale</TranCode>
                                      <Memo>Team1 money2020</Memo>
                                      <InvoiceNo>123456</InvoiceNo>
                                      <RefNo>123456</RefNo>
                                      <Amount>
                                          <Purchase>2.26</Purchase>
                                      </Amount>
                                      <Account>
                                            <AcctNo>5499990123456781</AcctNo>
                                            <ExpDate>0816</ExpDate>
                                            <AccountSource>Keyed</AccountSource>
                                      </Account>
                                  </Transaction>
                                </TStream>";
            
            xmlRequest = String.Format(xmlRequest, configReader.MerchantID);

            MessageBox.Show(xmlRequest);

            var m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", xmlRequest);
                w.WriteLine("-------------------------------");
            }

            txtLog.Text += xmlRequest;

            Console.WriteLine(xmlRequest);
            Console.WriteLine("");
            Console.WriteLine("");
            
            mpsWS.Endpoint.Address = new System.ServiceModel.EndpointAddress(configReader.MPSWSPURL);
            var xmlResponse = mpsWS.CreditTransaction(xmlRequest, configReader.Password);

            MessageBox.Show(xmlResponse);

            using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", xmlRequest);
                w.WriteLine("-------------------------------");
            }

            txtLog.Text += xmlResponse;

            Console.WriteLine(xmlResponse);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private void btnMenuApple_Click(object sender, EventArgs e)
        {
            txtReceipt.Text += "1 Apple........2.15\r\n";
            txtLog.Text += "Selected Apple." + DateTime.Now.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            txtReceipt.Text += "\r\n";
            txtReceipt.Text += "\r\n";
            txtReceipt.Text += "Total..........9.85\r\n";
            txtLog.Text += "Selected Checkout." + DateTime.Now.ToString();
        }
    }
}
