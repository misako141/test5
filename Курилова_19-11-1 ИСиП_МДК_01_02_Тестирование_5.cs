using System;
namespace ConsoleApp11
{
    public class calc
{
    public double a;
    public double b;
    public double c;

}

public class calc2 : calc
{
    public double D;
    public double t1;
    public double t2;
    public double x;
    public double x1;
    public double x2;
    public double x3;
    public double x4;
    public void reshenie()
    {
        D = b * b - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("Решений нет");
        }
        else
        {
            t1 = ((-b) + Math.Sqrt(D)) / (2 * a);
            t2 = ((-b) - Math.Sqrt(D)) / (2 * a);
            x1 = Math.Sqrt(t1);
            Console.WriteLine("Первый корень: " + x1);
            x2 = Math.Sqrt(t1) * (-1);
            Console.WriteLine("Второй корень: " + x2);
            x3 = Math.Sqrt(t2);
            Console.WriteLine("Третий корень: " + x3);
            x4 = Math.Sqrt(t2) * (-1);
            Console.WriteLine("Четвертый корень: " + x4);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        double A;
        double B;
        double C;
        Console.WriteLine("Введите а: ");
        A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b: ");
        B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c: ");
        C = Convert.ToDouble(Console.ReadLine());
        calc2 n = new calc2();
        n.a = A;
        n.b = B;
        n.c = C;
        n.reshenie();
        Console.ReadKey();
    }
}
}