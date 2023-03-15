using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21pp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double B = Convert.ToDouble(Console.ReadLine());
            double C;
            Console.WriteLine("1)- выполнить операцию “+”\n2)- выполнить операцию “-”\n3)- выполнить операцию “*”\n4)- выполнить операцию “/”\nВведите 1),2),3).");
            int nn = Convert.ToInt32(Console.ReadLine());
            switch (nn)
            {
                case 1:
                    C = A + B;
                    Console.WriteLine("A+B=" + C);
                    break;
                case 2:
                    C = A - B;
                    Console.WriteLine("A-B=" + C);
                    break;
                case 3:
                    C = A * B;
                    Console.WriteLine("A*dsfdsfsdfdsfdsfdsfsfsdfdsfB=" + C);
                    break;
                case 4:
                    C = A / B;
                    Console.WriteLine("A/B=" + C);
                    break;
            }
        }
    }
}
