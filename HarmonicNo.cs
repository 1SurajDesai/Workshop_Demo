using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopProblem
{
    public class HarmonicNo
    {
        public static void FindHarmonicValue()
        {
            //Variables
            int N, sum = 0;
            Console.WriteLine("Enter a number to find its Harmonic Value");
            N = Convert.ToInt32(Console.ReadLine());
            if (N == 0)
            {
                Console.WriteLine("Number cannot be zero");
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    sum = sum +  1 / i;
                }

            }
            Console.WriteLine("Nth Harmonic value is " + sum);
        }


        
    }
}
