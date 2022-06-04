using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using WebApi_Common.Models;

namespace OfficeClient.CardataProvider
{
    class DataProvider
    {

        private const string _url = "http://localhost:5000/api/cardata";

        public static IEnumerable<Cardata> GetCardata()
        {
            using(var client = new HttpClient())
            {
                var response = client.GetAsync(_url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    var cardatas = JsonConvert.DeserializeObject<IEnumerable<Cardata>>(rawData);
                    return cardatas;
                }
                throw new InvalidOperationException(response.StatusCode.ToString());
            }
        }

        public static void CreateCardata(Cardata cardata)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(cardata);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdateCardata(Cardata cardata)
        {
            using (var client = new HttpClient())
            {
                var currenturl = _url + "/" + cardata.Id;
                var rawData = JsonConvert.SerializeObject(cardata);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync(currenturl, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void DeleteCardata(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync($"{_url}/{id}").Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
