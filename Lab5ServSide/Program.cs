using System.Runtime.InteropServices;
using System.Text.Json;

namespace Lab5ServSide
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.) Read About each starting class");
            Console.WriteLine("2.) Take starting class reccomendation quiz");
            string firstChoice = Console.ReadLine();    
            if (firstChoice == "2" )
            {

            }
            int parsedChoice;
            do
            {
                Console.WriteLine("Please Select the class you could like to read about");
                Console.WriteLine("1.) Hero");
                Console.WriteLine("2.) Bandit");
                Console.WriteLine("3.) Astrologer");
                Console.WriteLine("4.) Warrior");
                Console.WriteLine("5.) Prisoner");
                Console.WriteLine("6.) Confessor");
                Console.WriteLine("7.) Wretch");
                Console.WriteLine("8.) Vagabond");
                Console.WriteLine("9.) Prophet");
                Console.WriteLine("10.) Samurai");
                Console.WriteLine("11.) Stop");
                string userChoice = Console.ReadLine();
                parsedChoice = int.Parse(userChoice);

                switch (parsedChoice)
                {
                    case 1:
                        HttpClient client = new HttpClient();
                        HttpResponseMessage response = await client.GetAsync("https://eldenring.fanapis.com/api/classes/17f69d71826l0i32gkm3ndn3kywxqj");
                        string json = await response.Content.ReadAsStringAsync();
                        string[] myObjects = json.Split(',');
                        foreach (string s in myObjects)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }

                        Console.WriteLine("Early Game Weapon");
                        break;
                    case 2:
                        HttpClient client1 = new HttpClient();
                        HttpResponseMessage response1 = await client1.GetAsync("https://eldenring.fanapis.com/api/classes/17f69d43011l0i32gojnjjs9mcg0k");
                        string json1 = await response1.Content.ReadAsStringAsync();
                        string[] myObjects1 = json1.Split(',');
                        foreach (string s in myObjects1)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 3:
                        HttpClient client2 = new HttpClient();
                        HttpResponseMessage response2 = await client2.GetAsync("https://eldenring.fanapis.com/api/classes/17f69874f7bl0i32gmqaffmbfral8f");
                        string json2 = await response2.Content.ReadAsStringAsync();
                        string[] myObject2 = json2.Split(',');
                        foreach (string s in myObject2)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 4:
                        HttpClient client3 = new HttpClient();
                        HttpResponseMessage response3 = await client3.GetAsync("https://eldenring.fanapis.com/api/classes/17f69b2dd76l0i32gljr3f62pkzhjo");
                        string json3 = await response3.Content.ReadAsStringAsync();
                        string[] myObjects3 = json3.Split(',');
                        foreach (string s in myObjects3)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 5:
                        HttpClient client4 = new HttpClient();
                        HttpResponseMessage response4 = await client4.GetAsync("https://eldenring.fanapis.com/api/classes/17f69d1f5f1l0i32grxfonsq64huhl");
                        string json4 = await response4.Content.ReadAsStringAsync();
                        string[] myObjects4 = json4.Split(',');
                        foreach (string s in myObjects4)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 6:
                        HttpClient client5 = new HttpClient();
                        HttpResponseMessage response5 = await client5.GetAsync("https://eldenring.fanapis.com/api/classes/17f69774a83l0i32hjagb1nwcs1hne");
                        string json5 = await response5.Content.ReadAsStringAsync();
                        string[] myObjects5 = json5.Split(',');
                        foreach (string s in myObjects5)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 7:
                        HttpClient client6 = new HttpClient();
                        HttpResponseMessage response6 = await client6.GetAsync("https://eldenring.fanapis.com/api/classes/17f69d4ac46l0i32hju3peo5nijzbj");
                        string json6 = await response6.Content.ReadAsStringAsync();
                        string[] myObjects6 = json6.Split(',');
                        foreach (string s in myObjects6)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 8:
                        HttpClient client7 = new HttpClient();
                        HttpResponseMessage response7 = await client7.GetAsync("https://eldenring.fanapis.com/api/classes/17f69db959fl0i32hhpwdbjko0bj57");
                        string json7 = await response7.Content.ReadAsStringAsync();
                        string[] myObjects7 = json7.Split(',');
                        foreach (string s in myObjects7)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 9:
                        HttpClient client8 = new HttpClient();
                        HttpResponseMessage response8 = await client8.GetAsync("https://eldenring.fanapis.com/api/classes/17f69932fefl0i32hlnekz682ixnvc");
                        string json8 = await response8.Content.ReadAsStringAsync();
                        string[] myObjects8 = json8.Split(',');
                        foreach (string s in myObjects8)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    case 10:
                        HttpClient client9 = new HttpClient();
                        HttpResponseMessage response9 = await client9.GetAsync("https://eldenring.fanapis.com/api/classes/17f699f7f4cl0i32huaj53vkdxeh7b");
                        string json9 = await response9.Content.ReadAsStringAsync();
                        string[] myObjects9 = json9.Split(',');
                        foreach (string s in myObjects9)
                        {
                            string betterString = s.Replace("'", "").Replace("\"", "");
                            string stringWithoutBraces = betterString.Replace("{", "").Replace("}", "");
                            Console.WriteLine(stringWithoutBraces + "\n");
                        }
                        break;
                    default:
                        break;
                }
            } while (parsedChoice != 11);
        }
    }
}