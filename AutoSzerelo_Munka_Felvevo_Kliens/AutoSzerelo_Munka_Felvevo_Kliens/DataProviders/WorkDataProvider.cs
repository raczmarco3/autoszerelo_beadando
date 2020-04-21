using AutoSzerelo_Munka_Felvevo_Kliens.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoSzerelo_Munka_Felvevo_Kliens.DataProviders
{
    public static class WorkDataProvider
    {
        private static string _url = "http://localhost:5000/api/work";
        
        public static IList<Work> GetWork()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(_url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    var works = JsonConvert.DeserializeObject<IList<Work>>(rawData);

                    return works;
                }
                else
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void CreateWork(Work work)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(work);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_url, content).Result;

                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateWork(Work work)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(work);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync(_url, content).Result;

                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void DeleteWork(long WorkId)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(_url + "/" + WorkId).Result;

                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

    }
}
