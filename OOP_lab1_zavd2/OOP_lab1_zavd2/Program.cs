using System.Transactions;

namespace OOP_lab1_zavd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sides of the triangle");
            Console.Write("Enter side 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 3: ");
            double c= Convert.ToDouble(Console.ReadLine());
            TTriangle t1 = new TTriangle(a,b,c);
            Console.WriteLine($"A triangle exists: { t1.IsExist(a, b, c)}");
            Console.WriteLine($"\vPerimeter: {t1.Perimeter(a, b, c)}");
            Console.WriteLine($"Square: {t1.Square(a, b, c)}\v");
            TTriangle t2 = new TTriangle(t1);
            Console.WriteLine(t2);
            Console.WriteLine($"Comparison: {t1.Equals(t2)}\v");
            double q = 3;
            double w = 4;
            double e = 5;
            TTriangle t3 = new TTriangle(q,w,e);
            Console.WriteLine(t3);
            Console.WriteLine($"Comparison: {t1.Equals(t3)}");
            Console.Write("\vEnter the height of the prism: ");
            double d= Convert.ToDouble(Console.ReadLine());
            TTrianglePrism tp1 = new TTrianglePrism(a, b, c, d);
            Console.WriteLine($"Volume Prism { tp1.Square(a, b, c, d)}\v");
           
        }
    }
}
