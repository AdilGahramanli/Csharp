using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Helloworld
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Messager messager = new Messager();
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine("Hello " + messager.userName);

            
            
            string dateDayName = DateTime.Now.DayOfWeek.ToString();


            for (int i = 0; i < messager.intervalDays.Length; i++)
            {
                if (dateDayName == messager.intervalDays[i])
                {

                    Console.WriteLine("Nous sommes Mercredi");

                }
            }

            messager.dateMessager();

           

            Console.ReadLine();

        }


    }
}

