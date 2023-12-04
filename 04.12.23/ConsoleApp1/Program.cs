using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Build dom1 = new Build();
            dom1.name = "Юность";
            dom1.area = 300;
            dom1.kvo = 2;
            Console.WriteLine(dom1.ToString());
            
            Build dom2 = new Build("Дача",150,4);
            Console.WriteLine(dom2.ToString());

            /// <summary>
            /// Способ, где параметры вводятся с клавиатуры 
            /// </summary>
            Console.WriteLine("name: ");
            string name =Console.ReadLine();
            Console.WriteLine("area: ");
            double area =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kvo: ");
            int kvo =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("floor: ");
            int floor =Convert.ToInt32(Console.ReadLine());

            Build dom3 = new Build(name,area, kvo, floor);
            Console.WriteLine($"{dom3.ToString()}");

            Console.ReadKey();
        }
    }
}
