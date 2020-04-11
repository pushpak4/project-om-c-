using System;
class push
{
public static void Main()
{
int i,j,m,n;
Console.WriteLine("enter rows and columns");
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());
double[,]A = new double[10,10];
Console.WriteLine("enter the matrix");
for(i=0;i<m;i++)
{
for(j=0;j<n;j++)
{
A[i,j] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
}
double[,]B = new double[10,10];
Console.WriteLine("enter the matrix");
for(i=0;i<m;i++)
{
for(j=0;j<n;j++)
{
B[i,j] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
}
double[,]C = new double[10,10];
Console.WriteLine("enter the matrix");
for(i=0;i<m;i++)
{
for(j=0;j<n;j++)
{
C[i,j] = A[i,j]+B[i,j];
Console.WriteLine(C[i,j]+"\t");
}
Console.WriteLine();
}
Console.ReadLine();
}
}
