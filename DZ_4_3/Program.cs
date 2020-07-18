using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_3
{
    class Program
    {
        //6. Заполнить массив из двадцати элементов следующим образом: 20, 19, ..., 1.

        static void Main(string[] args)
        {
            int[] numbArr = new int[20];

            int iter = 21;

            for (int i = 0; i < numbArr.Length; i++)
            {
                iter = iter - 1;
                numbArr[i] = iter;
            }

            foreach (int i in numbArr)
            {
                Console.Write($"{i} ");
                //Console.WriteLine(numbArr[i]);
            }

            Console.ReadLine();
        }
    }
}
