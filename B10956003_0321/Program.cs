using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace B10956003_0321
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int result = Add(3, 5);
            //Console.WriteLine(result);
            //Car myCar = new Car();
            //myCar.ShowInfo();
            //myCar.ChangeColor("blue");
            //myCar.ShowInfo();

            //Car CarA = new CarA();
            //CarA.OpenDoor();

            //await MyHttpClientAsync();


        static private async Task MyHttpClientAsync()
        {
            HttpClient client = new HttpClient();

            try
            {
                string url = "http://www.contoso.com/";


                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(url);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        static private int Add(int a, int b)
        {
            return a + b;

        }
        static private int MyRandom(int minNum, int maxNum)
        {
            Random random = new Random();
            return random.Next(minNum, maxNum + 1);

        }
    }
}