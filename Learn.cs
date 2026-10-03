using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            double itog_sum;
            Console.WriteLine("Введите сумму --- ");
            string sum = Console.ReadLine();
            bool index_1 = double.TryParse(sum, out double a);
            itog_sum = Math.Round(a, 3);

            if (index_1 == false)
            {
                Console.WriteLine("Неверный тип данных");
                return;
            }
            else if (index_1 == true)
            {
                Console.WriteLine("Какой тип валюты ? (введите номер)");
                Console.WriteLine("Рубли(1), Доллары(2)");
                string numberList = Console.ReadLine();
                bool index_2 = double.TryParse(numberList, out double b);
                if (index_2 == false || b > 2 || b < 0)
                {
                    Console.WriteLine("Неверный индекс или превышеное число допустимого");
                    return;
                }





                Console.WriteLine("Во что переводим (введите номер)");
                Console.WriteLine("Рубли(1), Доллары(2)");
                string numberList2 = Console.ReadLine();

                bool index_3 = double.TryParse(numberList2, out double c);
                if (index_3 == false || c > 2 || c < 0)
                {
                    Console.WriteLine("Неверный индекс или превышеное число допустимого");
                    return;
                }



                if (b == 1 && c == 2)
                {
                    RublXDollar(a);
                }
                else if (b == 2 && c == 1)
                {
                    DollarXRubl(a);
                }

                else if (b == 2 && c == 2)
                {
                    Console.WriteLine(itog_sum);
                }
                else if (b == 1 && c == 1)
                {
                    Console.WriteLine(itog_sum);
                }

                void DollarXRubl(double x)
                {
                    double itog = x * 80;
                    Console.WriteLine(itog);
                }

                void RublXDollar(double x)
                {
                    double itog2 = x / 80;
                    Console.WriteLine(itog2);
                }
            }






        }
    }
}
