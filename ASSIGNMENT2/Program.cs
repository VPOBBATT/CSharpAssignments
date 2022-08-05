using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using static ClassLibrary1.Class1;

namespace Program
{
    class Managementstudent
    {
        public static void Main(string[] args)
        {
            try
            {
                Library myObject = new Library();
                myObject.displayEmployees();
                //Employee Myobject = new Employee();
                //Console.WriteLine(Myobject.calculateGrossSalary());
                //Employee MyObject = new Employee();
                //Console.WriteLine(Myobject.getAutomatically());

                Class1.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();


        }
    }
}