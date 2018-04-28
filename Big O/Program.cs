using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_O
{
    class Program
    {
        // 4/20/18:Do Binary To Decimal 
        // 5/4/2018:Do Multiplication Recursivly
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
        {
            Console.WriteLine("Convert to Binary:");
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

            for (int i = binaryNum.Length - 1; i > -1; i--)
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
        #region Decimal Irrativly

        public static int DecimalIrrativly(string Text)
        {
            int sum = 0;

            for (int index = Text.Length - 1; index > -1; index--)
            {
                if (Text[index] == '1')
                {
                    sum += (int)Math.Pow(2, Text.Length - 1 - index);
                }
            }

            return sum;
        }

        #endregion
        #region DecimalRecursivly
        public static int DecimalHelper(int Number)
        {            
            return DecimalRecursivly(Number.ToString(), 0, Number.ToString().Length);
        }
        public static int DecimalRecursivly(string Text, int Sum, int orignalLength)
        {            
            if (Text.Length <= 0)
            {
                return Sum;
            }

            if (Text[Text.Length - 1] == '1')
            {
                Sum += (int)Math.Pow(2, orignalLength - Text.Length);
            }

            return DecimalRecursivly(Text.Remove(Text.Length - 1), Sum, orignalLength);
        }
        #endregion
        #region REMultipliction
        public static int REMultiplication(int Num1, int Num2)
        {
           
        }
        #endregion
        static void Main(string[] args)
        {
            #region REMultiplication 
            Console.WriteLine(REMultiplication(1,2));
            #endregion
            #region REBinary To Decimal
            //Console.WriteLine(DecimalHelper(101));
            #endregion
            #region Binary To Decimal
            //Console.WriteLine(DecimalIrrativly(num.ToString()));
            #endregion
            #region Binary Irratively
            //Delete Extra Zero
            /*
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine(Binary());

                Console.ReadKey();
            }*/
            #endregion
            #region Binary Recursively

            //Console.WriteLine(ToBinary(num));
            #endregion
            Console.ReadKey();
        }
    }
}
