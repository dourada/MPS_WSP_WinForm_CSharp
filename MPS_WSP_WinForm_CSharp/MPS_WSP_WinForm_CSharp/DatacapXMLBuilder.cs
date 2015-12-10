using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_WSP_WinForm_CSharp
{
    public class DatacapXMLBuilder
    {
        public static string BuildCreditSaleRequest(string merchantId)
        {
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

            xmlRequest = String.Format(xmlRequest, merchantId);

            return xmlRequest;
        }
    }
}
