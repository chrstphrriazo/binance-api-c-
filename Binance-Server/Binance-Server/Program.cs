using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Net.Http;

namespace TryBinance
{
    class Program
    {
        static async Task Main()
        {
            // Testnet Keys
            string API_Key = "C1QdD0R3LvdgFXFjKQSQUtbeHQVMBZAXW9XKs0eshOepUUiyw6c4840CfCXp1Z8x";
            string API_Secret = "5iNjgz7CZ1yUK5P3LqgswFRWqtkiraTUhWyyBGAEnMUHbSObzWLp5FWxfqDgmQGp";
            string baseurl = "https://testnet.binance.vision/api/v3/account?";
            string dataQueryString = "recvWindow=15000&timestamp=" + Math.Round(Convert.ToDecimal(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds), 0).ToString();

            //Code for calling Binance API general endpoints
/*            HttpClient httpclient = new HttpClient();
            string response = await httpclient.GetStringAsync(
                "https://testnet.binance.vision/api/v3/ticker/price?symbol=BTCUSDT");
            Console.WriteLine(response);*/

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-MBX-APIKEY", API_Key);
            HttpResponseMessage response = await client.GetAsync(baseurl + dataQueryString + "&signature=" + BitConverter.ToString(new HMACSHA256(Encoding.ASCII.GetBytes(API_Secret)).ComputeHash(Encoding.ASCII.GetBytes(dataQueryString))).Replace("-", string.Empty).ToLower());
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
    }
}