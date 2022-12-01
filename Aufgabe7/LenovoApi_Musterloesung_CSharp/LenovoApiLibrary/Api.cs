using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LenovoApiLibrary
{
    /*  *******************************************************************
     *     Inspired by https://pcsupport.lenovo.com/ch/en/warrantylookup#/ 
     *     und Silas von der TRISA AG
     *  *******************************************************************
     */

    public abstract class Api
    {
        public const string URI = "https://pcsupport.lenovo.com/ch/en/api/v4/upsell/redport/getIbaseInfo";

        public static MachineInfo GetMachineInfo(string serialNumber)
        {
            try
            {
                string jsonRequest = "{\"serialNumber\":\"" + serialNumber + "\"}";
                byte[] byteArray = Encoding.UTF8.GetBytes(jsonRequest);

                WebRequest request = CreateWebRequest(URI);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(byteArray, 0, byteArray.Length);

                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    string jsonResponse = new StreamReader(responseStream).ReadToEnd();
                    return ConvertToMachineInfo(jsonResponse);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Versuch, Geräteinformationen für das Gerät mit Seriennummer: " 
                    + serialNumber + " abzurufen.", ex);
            }

            return null;
        }

        private static MachineInfo ConvertToMachineInfo(string json)
        {
            dynamic dynObj = JsonConvert.DeserializeObject(json);

            #region MachineInfo

            // serialize dynObj.data.machineInfo...
            string tmp = JsonConvert.SerializeObject(dynObj.data.machineInfo,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            // ...then deserialize serialized string again to obtain typed 'MachineInfo' object
            MachineInfo machineInfo = JsonConvert.DeserializeObject<MachineInfo>(tmp);
            machineInfo.JsonData = json;

            #endregion

            #region CurrentWarranty

            // serialize dynObj.data.currentWarranty...
            tmp = JsonConvert.SerializeObject(dynObj.data.currentWarranty,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            // ...then deserialize serialized string again to obtain typed 'MachineInfo' object
            machineInfo.CurrentWarranty =
                JsonConvert.DeserializeObject<Warranty>(tmp);

            #endregion 

            #region Warranties

            // serialize dynObj.data...
            tmp = JsonConvert.SerializeObject(dynObj.data,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            // ...then deserialize serialized string again to obtain typed 'BaseWarrenties' object...
            machineInfo.BaseWarrantyList = JsonConvert.DeserializeObject<BaseWarranties>(tmp);
            
            // ...'UpgradeWarranties' object
            machineInfo.UpgradeWarrantyList = JsonConvert.DeserializeObject<UpgradeWarranties>(tmp);
           
            // ...'ContractWarranties' object
            machineInfo.ContractWarrantyList = JsonConvert.DeserializeObject<ContractWarranties>(tmp);

            #endregion

            return machineInfo;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            IWebProxy webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;

            return request;
        }

        /*
        private static MachineInfo ParseMachineInfo(string json)
        {
            JObject jObj = JObject.Parse(json);

            MachineInfo mi = new MachineInfo();
            mi.Model = (string)jObj.SelectToken("data.machineInfo.model");
            mi.Product = (string)jObj.SelectToken("data.machineInfo.product");
            mi.ProductName = (string)jObj.SelectToken("data.machineInfo.productName");
            mi.Serial = (string)jObj.SelectToken("data.machineInfo.serial");
            
            return mi;
        } 
        */
    }
}
