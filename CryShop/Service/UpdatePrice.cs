using CryShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CryShop.Service
{
    public class UpdatePrice
    {
        private bool _shouldStop;
        private HttpClient _httpClient;

        public void StartUpdating(params string[] coinNames)
        {
            Thread updateThread = new Thread(() => UpdateCurrencyData(coinNames));
            updateThread.Start();
        }

        public void StopUpdating()
        {

            _shouldStop = true;
        }

        private async void UpdateCurrencyData(params string[] coinNames)
        {
            while (!_shouldStop)
            {
                _httpClient = new HttpClient();
                foreach (var coinName in coinNames)
                {
                    HttpResponseMessage response = await _httpClient.GetAsync($"https://api.binance.com/api/v3/ticker/price?symbol={coinName}USDT");
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    decimal price = data.price;

                    using (var db = new ConnectDb())
                    {
                        var coin = db.Coins.FirstOrDefault(c => c.Name == coinName);

                        if (coin != null)
                        {
                            coin.Price = price;
                            await db.SaveChangesAsync();
                        }
                    }
                }
                await Task.Delay(100);
            }
        }

    }
}

