using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GoogleAPIConsumption.Helpers
{
    public static class HTTP
    {
        public enum Formatting { JSON, XML };
       

        /// <summary>
        /// Issues an http post request to the passed URL, passes string parameters
        /// and returns request response.
        /// </summary>
        /// <param name="URL">Http post request URL.</param>
        /// <param name="data">Dictionary of string data with string key.</param>
        /// <returns> 
        /// Http request response as string.
        /// </returns> 
        public async static Task<string> PostHttpRequestAsync(Uri URL, Dictionary<string, string> data)
        {
            try
            {
                HttpClient client = new HttpClient();
                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(URL, content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
  
       
    }

}