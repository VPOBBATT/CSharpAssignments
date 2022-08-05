using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_1_3
{
    public class ParamArray
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 20, 30, 40, 50, 100 };
                int n = numbers.Length;
                Param(numbers);

                static int Param(params int[] numbers)

                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum = sum + numbers[i];
                    }
                    Console.WriteLine(" sum of all integers:{0}", sum);
                    return sum;
                }


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
