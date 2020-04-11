using System;
class two
{
public static void Main()
{
double h,x,y;
Console.WriteLine("enter value: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter value: ");
y = Convert.ToDouble(Console.ReadLine());
h = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
Console.WriteLine("value : "+h);
Console.ReadLine();
}
}

