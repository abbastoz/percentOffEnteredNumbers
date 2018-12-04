using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percentOffEnteredNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 0, -1, -2 -6, 7, 9,10 };
            Program p = new Program();
            p.percentNumber(arr);
        }
        public void percentNumber(int[] arr)
        {
            int cPositive, cNegative, cZero;
            cPositive = 0;
            cNegative = 0;
            cZero = 0;
            int lenght = arr.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (arr[i] > 0)
                {
                    cPositive++;
                }
                else if (arr[i] < 0)
                {
                    cNegative++;
                }
                else
                {
                    cZero++;
                }

            }
            Decimal dLenght = Decimal.Parse(lenght.ToString());
            Decimal dPositive = Decimal.Parse(cPositive.ToString());
            Decimal dNegative = Decimal.Parse(cNegative.ToString());
            Decimal dZero = Decimal.Parse(cZero.ToString());
            Console.WriteLine((dPositive/dLenght).ToString("N6"));
            Console.WriteLine((dNegative / dLenght).ToString("N6"));
            Console.WriteLine((dZero / dLenght).ToString("N6"));
            Console.ReadKey();
        }
    }
}
