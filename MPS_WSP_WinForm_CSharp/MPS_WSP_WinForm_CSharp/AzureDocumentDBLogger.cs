using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft.Json;

namespace MPS_WSP_WinForm_CSharp
{
    public class AzureDocumentDBLogger : ILogger
    {
        string _location = string.Empty;
        string _endpointUrl = string.Empty;
        string _authorizationKey = string.Empty;

        public AzureDocumentDBLogger(string endpointUrl, string authorizationKey)
        {
            _endpointUrl = endpointUrl;
            _authorizationKey = authorizationKey;
        }

        string ILogger.Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        async void ILogger.LogData(string data)
        {
            var client = new DocumentClient(new Uri(_endpointUrl), _authorizationKey);
            Database database = client.CreateDatabaseQuery().Where(db => db.Id == "LoggerDatabase").AsEnumerable().FirstOrDefault();

            // If the database does not exist, create a new database
            if (database == null)
            {
                database = await client.CreateDatabaseAsync(
                    new Database
                    {
                        Id = "LoggerDatabase"
                    });
            }

            DocumentCollection documentCollection = client.CreateDocumentCollectionQuery("dbs/" + database.Id).Where(c => c.Id == "LoggerCollection").AsEnumerable().FirstOrDefault();

            // If the document collection does not exist, create a new collection
            if (documentCollection == null)
            {
                documentCollection = await client.CreateDocumentCollectionAsync("dbs/" + database.Id,
                    new DocumentCollection
                    {
                        Id = "LoggerCollection"
                    });
            }

            var logData = new LogData();
            logData.Id = Guid.NewGuid().ToString();
            logData.Info = data;
            logData.DateInfo = DateTime.Now;
            logData.Severity = "Severe";

            await client.CreateDocumentAsync("dbs/" + database.Id + "/colls/" + documentCollection.Id, logData);
        }
    }
}
