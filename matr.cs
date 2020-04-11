using System;
class add
{
public static void Main()
{
int m, n, i, j, k;
Console.WriteLine("enter rows and columns of matrices ");
m = Convert.ToInt16(Console.ReadLine());
n = Convert.ToInt16(Console.ReadLine());
double[,] A = new double[m, n];
Console.WriteLine("enter first matrices: ");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
A[i, j] = Convert.ToDouble(Console.ReadLine());
}
}
double[,] B = new double[m, n];
Console.WriteLine("enter first matrices: ");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
B[i, j] = Convert.ToDouble(Console.ReadLine());
}
}
Console.Clear();
Console.WriteLine("Matrices A");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
Console.WriteLine(A[i, j] + "\t");
}
Console.WriteLine();
}
Console.WriteLine("Matrices B");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
Console.WriteLine(B[i, j] + "\t");
}
Console.WriteLine();
}
double[,] C = new double[m, n];
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
C[i, j] = 0;
for (k = 0; k < m; k++)
{
C[i, j] = A[i, j] * B[i, j];
}
}
}
Console.WriteLine("matrix is: \n");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
Console.WriteLine(C[i, j] + "\t");
}
Console.WriteLine();
}
Console.ReadLine();
}
}
