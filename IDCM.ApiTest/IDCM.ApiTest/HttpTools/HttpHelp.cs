using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IDCM.ApiTest.HttpTools
{
    public class HttpHelp
    {
        private HttpClient httpClient;
        public HttpHelp()
        {
            httpClient = new HttpClient();
        }

        public async Task<T> PostAsync<T>(string url,string apikey,string input,string sign)
        {
            if (string.IsNullOrWhiteSpace(url)) throw new ArgumentNullException(nameof(url));
            if (string.IsNullOrWhiteSpace(apikey)) throw new ArgumentNullException(nameof(apikey));
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException(nameof(input));
            if (string.IsNullOrWhiteSpace(sign)) throw new ArgumentNullException(nameof(sign));

            var byteArray = Encoding.UTF8.GetBytes("");
            using (HttpContent httpContent = new StreamContent(new MemoryStream(byteArray)))
            {
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                httpContent.Headers.Add("X-IDCM-APIKEY", apikey);
                httpContent.Headers.Add("X-IDCM-SIGNATURE", sign);
                httpContent.Headers.Add("X-IDCM-INPUT", input);

                var response = await httpClient.PostAsync(url, httpContent);
                var ret = await this.CheckResponseOk<T>(response);

                return ret;
            }
        }

        /// <summary>
        /// Check the crypto client response is ok.
        /// </summary>
        /// <typeparam name="T">
        /// The type.
        /// </typeparam>
        /// <param name="response">
        /// The response.
        /// </param>
        /// <exception cref="BitcoinClientException">
        /// The exception message.
        /// </exception>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private async Task<T> CheckResponseOk<T>(HttpResponseMessage response)
        {
            try
            {
                using (var jsonStream = await response.Content.ReadAsStreamAsync())
                {
                    using (var jsonStreamReader = new StreamReader(jsonStream))
                    {
                        var result = await jsonStreamReader.ReadToEndAsync();
                        var ret = JsonConvert.DeserializeObject<T>(result);

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            throw new Exception(result);
                        }

                        return ret;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Failed parsing the result, StatusCode={0}, row message={1}", response.StatusCode, response.Content.ReadAsStringAsync().Result), ex);
            }
        }
    }
}
