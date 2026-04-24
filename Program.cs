using System.Diagnostics.CodeAnalysis;

using System;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        //cau 1
        Console.WriteLine("Cau 1");
        int a = 1;
        int b = 2;
        Console.WriteLine($"a + b = {a + b}");
        //cau 2
        Console.WriteLine("câu 2");
        int d = 5, e = 8;
        Console.WriteLine($"chưa swap: d = {d}, e = {e}");

        Swap(ref d, ref e);

        Console.WriteLine($" đã swap: d = {d}, e = {e}");
        //cau 3
        Console.WriteLine("câu 3");
        Console.WriteLine($"a * b = {a * b}");
        //cau 4
        Console.WriteLine("Cau 4");
        double feet = 4;
        double meters = feet * 0.3048;
        Console.WriteLine($"{feet} feet = {meters} met");
        //cau 5
        Console.WriteLine("cau 5");
       double celsius = 30;
        double fahrenheitFromC = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C = {fahrenheitFromC}°F");

        double fahrenheit = 86;
        double celsiusFromF = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit}°F = {celsiusFromF}°C");
        // cau 6
        Console.WriteLine("Cau 6");

        Console.WriteLine($"Size of int: {sizeof(int)} bytes");
        Console.WriteLine($"Size of double: {sizeof(double)} bytes");
       //"cau 7 "
        Console.WriteLine("cau 7");
        Console.Write("nhap du lieu: ");
        char ch = Console.ReadKey().KeyChar;
        int ascii = (int)ch;
        Console.WriteLine("\nASCII = " + ascii);
        Console.WriteLine("câu 8");
        double r = 8;
        double area = r * r * 3.14;
        Console.WriteLine("area of circle = " + area );
        Console.WriteLine("câu 9"); 
        double x = 4;
        Double Area = x * x;
        Console.WriteLine("area of square =" + Area);
        Console.WriteLine("câu 10");
        int days = int.Parse( Console.ReadLine()! );
        int years = days / 365;
        int month = (days % 365) / 30;
      int week = (days % 365) / 7;
      Console.WriteLine(years);
        Console.WriteLine(month);
        Console.WriteLine(week);






        static void Swap(ref int d, ref int f)
        {
            int temp = d;
            d = f;
            f = temp;

        }
    }
}
