using System;
class add
{
public static void Main()
{
int i, j, m, n;
Console.WriteLine("enter rows and columns of matrices ");
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter first matrices: ");
double[,] A = new double[10, 10];
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
A[i, j] = Convert.ToDouble(Console.ReadLine());
}
}
Console.WriteLine("matrices A");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
Console.WriteLine(A[i, j] + "\t");
}
Console.WriteLine();
}
double[,] B = new double[10, 10];
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
B[i, j] = A[i, j];
}
}
for (i = 1; i < 2; i++)
{
for (j = 0; j < 4; j++)
{
B[1, j] = A[1, j] - ((A[1, 0] / A[0, 0]) * A[0, j]);
}
Console.WriteLine();
}
for (i = 2; i < 3; i++)
{
for (j = 0; j < n; j++)
{
B[i, j] = A[i, j] - ((A[2, 0] / A[0, 0]) * A[0, j]);
}
Console.WriteLine();
}
Console.WriteLine("matrix is: ");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
Console.WriteLine(B[i, j] + "\t");
}
Console.WriteLine();
}
double[,] C = new double[10, 10];
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
C[i, j] = B[i, j];
}
}
for (i = 2; i < 3; i++)
{
for (j = 0; j < n; i++)
{
C[i, j] = B[i, j] - ((B[2, 1] / B[1, 1]) * B[1, j]);
}
Console.WriteLine();
}
Console.WriteLine("matrix is: ");
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
Console.WriteLine(C[i, j] + "\t");
}
Console.WriteLine();
}
double z = C[2, 3] / C[2, 2];
double y = (C[1, 3] - C[1, 2] * z) / C[1, 1];
double x = (C[0, 3] - C[0, 1] * y - C[0, 2] * z) / C[0, 0];
Console.ReadLine();
}
}
