using System;
class one
{
public static void Main()
{
double theta;
double sin;
double cos;
double tan;
Console.WriteLine("enter value : ");
theta = Convert.ToDouble(Console.ReadLine());
sin = Math.Sin(theta * Math.PI / 180);
cos = Math.Cos(theta * Math.PI / 180);
tan = Math.Tan(theta * Math.PI / 180);
Console.WriteLine("value : "+sin);
Console.WriteLine("value : "+cos);
Console.WriteLine("value : "+tan);
Console.ReadLine();
}
}