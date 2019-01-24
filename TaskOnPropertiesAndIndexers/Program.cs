using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnPropertiesAndIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            int loverRange=0;
            int upRange=0;
            bool resultOfFirstConversion, resultOfSecondConversion;
            bool check=false;
            while (check==false)
            {
                Console.Write("Введите начало диапазона: ");
                resultOfFirstConversion = int.TryParse(Console.ReadLine(), out loverRange);

                Console.Write("Введите конец диапазона: ");
                resultOfSecondConversion = int.TryParse(Console.ReadLine(), out upRange);
                if (resultOfFirstConversion == true && resultOfSecondConversion == true)
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Введите цифры!!!");
                }
            }
                RangeOfArray array = new RangeOfArray(loverRange, upRange);
                Random random = new Random();

            /*Метод заполнеиния массива*/

            if (loverRange > upRange)
            {
                Swap(ref loverRange, ref upRange);
            }


            for (int i=loverRange; i<upRange; i++)
            {
                array[i] = random.Next(1, 10);
            }

            /*Отображения массива*/

            for (int i = loverRange; i < upRange; i++)
            {
                Console.Write(array[i]+ " ");
            }
            Console.WriteLine();

            array.ShowClassArray();

            Console.ReadLine();
        }
        static void Swap(ref int value1, ref int value2)
        {
            int tmp = value1;
            value1 = value2;
            value2 = tmp;
        }
    }
}
