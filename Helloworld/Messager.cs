using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Messager
    {
        public string[] intervalDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        public string[] intervalWeekEnd = { "Saturday", "Sunday" };
        public string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public void dateMessager()
        {


            int hour = DateTime.Now.Hour;

            if (hour >= 9 && hour <= 13 && intervalDays.Contains(DateTime.Now.DayOfWeek.ToString()))
            {

                Console.WriteLine("Bonjour " + userName);

            }

            if (hour >= 13 && hour <= 18 && intervalDays.Contains(DateTime.Now.DayOfWeek.ToString()))
            {

                Console.WriteLine("Bon après-midi " + userName);

            }

            if ((hour >= 18 || hour <= 9 && intervalDays.Contains(DateTime.Now.DayOfWeek.ToString()) && DateTime.Now.DayOfWeek.ToString() != "Friday"))
            {

                Console.WriteLine("Bonsoir " + userName);

            }

            //Le code ci-dessous est monstrueusement troooooooooop lonnnnnnnnnnng !!!!! (et ci-dessus c'est pas mieux!!)
            if (((hour >= 18 || hour <= 9) && (DateTime.Now.DayOfWeek.ToString() != "Friday" || intervalWeekEnd.Contains(DateTime.Now.DayOfWeek.ToString()))))
            {

                Console.WriteLine("Bon week-end");

            }

        }
    }
}
