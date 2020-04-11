using System;
class maths
{
static void Main()
{
double r1,r2,theta1,theta2,h,v,r,theta;
Console.WriteLine("Enter number : ");
r1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number : ");
r2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number : ");
theta1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number : ");
theta2=Convert.ToDouble(Console.ReadLine());
h = r1 * Math.Cos(theta1 * Math.PI / 180) - r2 * Math.Cos(theta2 * Math.PI / 180);
Console.WriteLine("Number : "+h);
Console.ReadLine();
v = r1 * Math.Sin(theta1 * Math.PI / 180) - r2 * Math.Sin(theta2 * Math.PI / 180);
Console.WriteLine("Number : "+v);
Console.ReadLine();
r = Math.Sqrt(h * h + v * v);
Console.WriteLine("Number : "+r);
Console.ReadLine();
theta = Math.Atan(v / h);
Console.WriteLine("Number : "+theta);
Console.ReadLine();
}
}
