using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_O
{
    class Program
    {
        // 4/27/18:Do Binary To Decimal 
        #region RECURSION
        public static int RecursiveFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * RecursiveFactorial(number - 1);
        }
        public static int Factorial(int number)
        {
            int temp = number;

            for (int i = 1; i < number + 1; i++)
            {
                if (i != number)
                {
                    temp = temp * (number - i);
                }
            }
            return temp;
        }
        public static int RecursiveFibbonacci(int number)
        {
            if (number <= 2)
            {
                return 1;
            }

            return RecursiveFibbonacci(number - 1) + RecursiveFibbonacci(number - 2);
        }

        #endregion
        #region BinaryIrrativly
        public static string Binary()
        {   Console.WriteLine("Convert to Binary:");
            int number = int.Parse(Console.ReadLine());
            int tempNum = number;
            string finalstring = "";
            for (int i = 0; i < number; i++)
            {
                if (tempNum != 0)
                {
                    if (i >= 1)
                    {
                        tempNum = tempNum / 2;
                    }

                    if (tempNum % 2 == 1)
                    {
                        finalstring = "1" + finalstring;
                    }
                    else if (i < number)
                    {
                        finalstring = "0" + finalstring;
                    }
                }
            }
            return finalstring;
        }
        #endregion
        #region Binary Recursively      
        public static string ToBinary(int num)
        {
            string binaryNum = REBinary("", num);

            string reverse = "";

            for(int i = binaryNum.Length - 1;i > -1;i--)
            {
                reverse += binaryNum[i];
            }

            return reverse;
        }
    
        public static string REBinary(string rebinary, int Num)
        {
            int newNum = Num / 2;
            int remainder = Num % 2;
            rebinary += remainder.ToString();
            if (newNum <= 0)
            {
                return rebinary;
            }
            return REBinary(rebinary, newNum);
        }
        #endregion
        static void Main(string[] args)
        {   int num = 100;
            #region Binary Irratively
            //Delete Extra Zero
            /*
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("\t\t\t{0}\n",Binary());
                Console.WriteLine("Type Enter, Then Another Number You Want to Convert to Binary, Otherwise Click Alt F4");
                Console.ReadKey();
            }*/
            #endregion
            #region Binary Recursively
            
            Console.WriteLine(ToBinary(num));
            #endregion
            Console.ReadKey();
        }
    }
}
