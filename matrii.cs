using System;
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n;
            Console.WriteLine("Enter the rows and columns of a matrix : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Matrix : ");
            double[,] A = new double[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix A is : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double[,] B = new double[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = A[i,j];
                }
            }
            for (i = 1; i < 3; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = A[i, j] - ((A[i, 0] / A[0, 0]) * A[0, j]);
                }
                Console.WriteLine();
            }
                Console.WriteLine("The step1 matrix is : ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                double[,] C = new double[10, 10];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        C[i, j] = B[i,j];
                    }
                }
                for (i = 2; i < 3; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        C[i, j] = B[i, j] - ((B[2, 1] / B[1, 1]) * B[1, j]);
                    }
                    Console.WriteLine();

                }

                Console.WriteLine("The step2 matrix is : ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(C[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            for (i = 0; i < m; i++) ;
            {
                for (j = 0; j < n; j++) ;
                {
                    double xi = (C[i, n - 1] ) / C[i, i];
                }
            }
                double z = C[2, 3] / C[2, 2];
                double y = (C[1, 3] - C[1, 2] * z) / C[1, 1];
                double x = (C[0, 3] - C[0, 1] * y - C[0, 2] * z) / C[0, 0];
                Console.WriteLine("x : {0}, y : {1}, z : {2}", x, y, z);
                Console.ReadLine();
            }
            
        }