using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dates = new MyDictionary<string, int>();
            dates.Add("İstanbul'un Fethi", 1453);

            Console.WriteLine(dates.Length);

            dates.Add("Cumhuriyetin İlanı", 1923);

            Console.WriteLine(dates.Length);


            foreach (var date in dates.Keys)
            {
                Console.WriteLine(date);
            }





            Console.ReadLine();
        }
    }
}
