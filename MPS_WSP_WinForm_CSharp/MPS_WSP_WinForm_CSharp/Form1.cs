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
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft.Json;

namespace MPS_WSP_WinForm_CSharp
{
    public partial class Form1 : Form
    {
        ConfigReader configReader;
        ILogger logger;

        public Form1()
        {
            InitializeComponent();
            configReader = new ConfigReader();
            logger = new AzureDocumentDBLogger(configReader.EndpointUrl, configReader.AuthorizationKey);
            logger.Location = configReader.LoggingLocation;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            AddToTextLog("Selected Checkout." + DateTime.Now.ToString(), false);

            var mpsWS = new MPSWebService.wsSoapClient();

            var xmlRequest = DatacapXMLBuilder.BuildCreditSaleRequest(configReader.MerchantID);

            AddToTextLog(xmlRequest, true);

            mpsWS.Endpoint.Address = new System.ServiceModel.EndpointAddress(configReader.MPSWSPURL);
            var xmlResponse = mpsWS.CreditTransaction(xmlRequest, configReader.Password);

            AddToTextLog(xmlResponse, true);
        }

        private void AddToTextLog(string data, bool showMessageBox)
        {
            txtLog.Text += data;
            logger.LogData(data);            
            if (showMessageBox)
                MessageBox.Show(data);
        }

        private void btnMenuApple_Click(object sender, EventArgs e)
        {
            txtReceipt.Text += "1 Apple........2.15\r\n";
            AddToTextLog("Selected Apple", false);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            txtReceipt.Text += "\r\n";
            txtReceipt.Text += "\r\n";
            txtReceipt.Text += "Total..........9.85\r\n";
            AddToTextLog("Selected Checkout", false);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var client = new DocumentClient(new Uri(configReader.EndpointUrl), configReader.AuthorizationKey);
            var database = client.CreateDatabaseQuery().Where(db => db.Id == "LoggerDatabase").AsEnumerable().FirstOrDefault();
            var documentCollection = client.CreateDocumentCollectionQuery("dbs/" + database.Id).Where(c => c.Id == "LoggerCollection").AsEnumerable().FirstOrDefault();

            txtLog.Clear();

            var logEntries =
                from f in client.CreateDocumentQuery("dbs/" + database.Id + "/colls/" + documentCollection.Id)
                select f;

            foreach (var logEntry in logEntries)
            {
                txtLog.Text += logEntry;
            }

        }
    }
}
