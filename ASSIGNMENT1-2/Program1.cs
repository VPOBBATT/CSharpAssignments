using System;

class TheBiggestMarksAmongTheFiveStudents
{
    static void Main()
    {


        Console.Write("\n\n");
        Console.Write("Find the highest marks among them:\n");
        Console.Write("------------------------------------");
        Console.Write("\n\n");

        Console.Write("Enter the 1st student Average marks:");
        decimal a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the 2nd student Average marks :");
        decimal b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the 3rd student Average marks :");
        decimal c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the 4th student Average marks :");
        decimal d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the 5th student Average marks :");
        decimal e = Convert.ToInt32(Console.ReadLine());
        decimal average = (a + b + c + d + e) / 5;
        Console.WriteLine("The average marks of five Students {0},{1},{2},{3},{4} is :{5}", a, b, c, d, e, average);

        if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
        {
            Console.WriteLine("The highest marks is: {0}", a);
            return;
        }
        if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
        {
            Console.WriteLine("The highest marks is: {0}", b);
            return;
        }
        if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
        {
            Console.WriteLine("The highest marks  is: {0}", c);
            return;
        }
        if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
        {
            Console.WriteLine("The highest maarks is: {0}", d);
            return;
        }
        if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
        {
            Console.WriteLine("The highest marks  is: {0}", e);
            return;
        }

    }
}
