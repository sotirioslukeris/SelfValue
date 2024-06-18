using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Labour> labours = new List<Labour>();
            
            Console.WriteLine("Въведи броя на дейностите");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Въведете информация за {n} дейности");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Дейност {i} : ");
                Console.WriteLine("Код");
                string code = Console.ReadLine();
                Console.WriteLine("Вид");
                string vid = Console.ReadLine();
                Console.WriteLine("Часове");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Часово заплащане");
                double zaplashtane = double.Parse(Console.ReadLine());

                Labour labour = new Payment(code, vid, hours, zaplashtane); //Полиморфизъм

                labours.Add(labour);

            }

            Console.WriteLine("Информация за всяка от дейностите");

            labours.ForEach(x =>  x.Print());

        }
    }
}
