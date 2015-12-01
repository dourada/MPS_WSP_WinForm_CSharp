using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var mpsWS = new MPSWebService.wsSoapClient();
            var xmlRequest = @"<TStream>
                                  <Transaction>
                                      <MerchantID>{0}</MerchantID>
                                      <OperatorID>{1}</OperatorID>
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
            
            xmlRequest = String.Format(xmlRequest, configReader.MerchantID, "test");

            MessageBox.Show(xmlRequest);

            Console.WriteLine(xmlRequest);
            Console.WriteLine("");
            Console.WriteLine("");
            
            mpsWS.Endpoint.Address = new System.ServiceModel.EndpointAddress(configReader.MPSWSPURL);
            var xmlResponse = mpsWS.CreditTransaction(xmlRequest, configReader.Password);

            MessageBox.Show(xmlResponse);

            Console.WriteLine(xmlResponse);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
