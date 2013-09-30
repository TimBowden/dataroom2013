using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.WindowsAzure;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace Dwf.Firmwide.Dataroom
{
    
    public class AzureMobileService
    {
        #region Private Variables

        private Uri muriMobileEndPoint = new Uri("https://dwfms.azure-mobile.net/tables/DWFDataRoom2013");
        private string mstrApplicationKey = "lwYNpqYaVweFohhEAupikBbkqNrMve15";

        private string mstrServiceName = "dwfms";
        private string mstrTableName = "DWFDataRoom2013";

        //public static MobileServiceClient ms = new MobileServiceClient("https://dwfms.azure-mobile.net/", "lwYNpqYaVweFohhEAupikBbkqNrMve15");           

        #endregion




        #region Structures

        public struct RequestDetails
        {
            public Guid ListId;
            public Uri DocumentLink;
            public string DisplayName;
            

            public override string ToString()
            {
                StringBuilder sbrJSON = new StringBuilder("{'DisplayName':'" + DisplayName + "', 'DocumentLink':'" + DocumentLink + "', 'ListId': '" + ListId.ToString() + "' })");
                return sbrJSON.ToString();
            }

        }

        

        #endregion

        #region Properties

        public RequestDetails MobileServicesRequest { get; set; }
        public Uri EndPoint { get { return muriMobileEndPoint; } set { muriMobileEndPoint = value; } }
        

        public string ApplicationKey
        {
            get { return mstrApplicationKey; }
            set { mstrApplicationKey = value; }
        }

        #endregion

        #region Public Async Methods

        public void AsyncPostToMobileService()
        {
            

            Uri address = new Uri(string.Format("https://{0}.azure-mobile.net/tables/{1}", mstrServiceName, mstrTableName));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(address);

            request.Method = "POST";
            request.Headers = new WebHeaderCollection
                            {
                                {"X-ZUMO-APPLICATION", mstrApplicationKey}
                            };

            string serialization = new JavaScriptSerializer().Serialize(MobileServicesRequest);
            byte[] byteData = Encoding.UTF8.GetBytes(serialization);
            request.ContentLength = byteData.Length;

            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();

        }

        #endregion

    }
}
