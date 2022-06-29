/*using System.Net;
using System.Security.Cryptography;
using System.Text;

// THIS USES A DEPRACATED CLASS
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string tempAPI_Key = "C1QdD0R3LvdgFXFjKQSQUtbeHQVMBZAXW9XKs0eshOepUUiyw6c4840CfCXp1Z8x";
            string tempAPI_Secret = "5iNjgz7CZ1yUK5P3LqgswFRWqtkiraTUhWyyBGAEnMUHbSObzWLp5FWxfqDgmQGp";
            Console.WriteLine("Hello World!");
*//*            WebRequest webrequest = WebRequest.Create("https://testnet.binance.vision/api/v3/ticker/price?symbol=BTCUSDT");
            WebResponse Response = webrequest.GetResponse();
            StreamReader reader = new StreamReader(Response.GetResponseStream());
            Console.WriteLine(reader.ReadToEnd());*//*
            long unixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string dataQueryString = "recvWindow=15000&timestamp=" + Math.Round(Convert.ToDecimal(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds), 0).ToString();
            WebRequest webrequest = WebRequest.Create("https://testnet.binance.vision/api/v3/account?" + dataQueryString + "&signature=" + BitConverter.ToString(new HMACSHA256(Encoding.ASCII.GetBytes(tempAPI_Secret)).ComputeHash(Encoding.ASCII.GetBytes(dataQueryString))).Replace("-", string.Empty).ToLower());
            webrequest.Method = "GET";
            webrequest.Headers.Add("X-MBX-APIKEY", tempAPI_Key);
            WebResponse Response = webrequest.GetResponse();
            StreamReader reader = new StreamReader(Response.GetResponseStream());
            string response = reader.ReadToEnd();
            Console.WriteLine(response);
            Console.WriteLine(unixTime);
            Console.WriteLine(dataQueryString);
            reader.Close();
            Response.Close();

        }
    }
}
*/