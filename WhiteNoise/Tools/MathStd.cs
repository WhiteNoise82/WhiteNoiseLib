using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteNoise.Tools
{
    public class MathStd
    {
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num2;
            num2 = num1;
            num1 = temp;
        }

        public static void Devide(int num1, int num2, out int quotient, out int reminder)
        {
            quotient = num1 / num2;
            reminder = num1 % num2;
        }

        public static int Sum(params int[] num)
        {
            int sum = 0;

            for (int i = 0; i < num.Length; i++) sum += num[i];

            return sum;
        }

        
    }
}
