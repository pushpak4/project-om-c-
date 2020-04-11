using System;
class all
{
public static void Main()
{
double a,b,c,x1,x2;
Console.WriteLine("enter value:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter value:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter value:");
c = Convert.ToDouble(Console.ReadLine());
x1 = (-b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / 2 * a;
Console.WriteLine("value:"+x1);
Console.ReadLine();
x2 = (-b - Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / 2 * a;
Console.WriteLine("value:"+x2);
Console.ReadLine();
}
}


