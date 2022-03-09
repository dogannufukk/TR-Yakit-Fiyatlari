using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.WebServiceMethods
{
    public class GetApiDataService : IGetApiDataService
    {
        public string ReadWebRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    var result = responseReader.ReadToEnd();
                    return result;
                }
            }
            catch (Exception e)
            {
                //TODO: Exception log
                return "error";
            }
        }
    }
}
