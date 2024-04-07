using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#11.	WAP to convert temperature from degree Celsius to Fahrenheit & vice-versa. Use the formula : F=9C/5 + 32 ");
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("Select an options:->");
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("1. Convert Celsius to Fehrenheit");
            Console.WriteLine("2. Convert Fehrenheit to Celsius");

            int selection = Convert.ToInt32(Console.ReadLine());
            double tempreture = 0;
            switch(selection)
            {
                case 1:
                    Console.WriteLine("The formula is \n1. °F = (°C x 1.8) + 32 or \n°F = °C x (9/5) + 32");
                    Console.WriteLine("Enter tempreture in Celcius: ");
                    tempreture = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(string.Format("The Tempreture  in Celcius {0} is Fehrenheit {1} "),tempreture, (tempreture * (9/5) + 32));
                    break;
                case 2:
                    Console.WriteLine("The formula is °C = (°F - 32) x (5/9)");
                    Console.WriteLine("Enter tempreture in Fehrenheit: ");
                    tempreture = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(string.Format("The Tempreture  in Fehrenheit {0} is Celcius {1} "), tempreture, ((tempreture  - 32) * (9 / 5)));
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadKey();
        }
    }
}
