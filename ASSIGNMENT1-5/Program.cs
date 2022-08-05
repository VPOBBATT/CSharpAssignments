using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCircumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                double radius, circumference, area;
                Console.WriteLine("Enter the value of the radius :");
                radius = double.Parse(Console.ReadLine());

                circumference = 2 * Math.PI * radius;

                Console.WriteLine("Circumference of the circle:" + Math.Round(circumference, 2));
                area = Math.PI * radius * radius;
                Console.WriteLine("Area of the Circle:{0}", area);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
