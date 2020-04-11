using System;
    class Com
    {
        public static void Main()
        {
            int i, j, temp;
            int[] A = new int[5];//array declaration
            int[] B = new int[5];
            int[] UN = new int[10];
            Console.WriteLine("Enter set A elements:"); //getting set A elements
            for (i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter set B elements:"); //getting set B elements
            for (i = 0; i < 5; i++)
            {
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 1; i < 5; i++)
            {

                for (j = 0; j < 5 - i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        temp = A[j];// declaring temporary memory to store set A
                        A[j] = A[j + 1];
                        A[j + 1] = temp; // sorting the set A elements
                    }
                }

            }
            for (i = 1; i < 5; i++)
            {
                for (j = 0; j < 5 - i; j++)
                {
                    if (B[j] > B[j + 1])
                    {
                        temp = B[j]; // declaring temporary memory to store set B
                        B[j] = B[j + 1];
                        B[j + 1] = temp; // sorting set B elements

                    }

                }
            }



            i = 0; j = 0; int k = 0;
            while ((i < 5) && (j < 5))
            {
                if (A[i] < B[j])
                {
                    UN[k] = A[i];
                    i++;
                    k++;
                }
                else if (A[i] > B[j])
                {
                    UN[k] = B[j];
                    j++;
                    k++;
                }
                else
                {
                    UN[k] = A[i];
                    i++;
                    j++;
                    k++;
                }
            }
            if (i == 5)
            {
                while (j < 5)
                {
                    UN[k] = B[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < 5)
                {
                    UN[k] = A[i];
                    i++;
                    k++;
                }
            }
            Console.WriteLine("A union B: "); //Displaying the result for A union B
            for (i = 0; i < k; i++)
            {
                Console.Write(UN[i] + " ");
            }


            i = 0; j = 0; k = 0;
            while ((i < 5) && (j < 5))
            {
                if (B[i] < A[j])
                {
                    UN[k] = B[i];
                    i++;
                    k++;
                }
                else if (B[i] > A[j])
                {
                    UN[k] = A[j];
                    j++;
                    k++;
                }
                else
                {
                    UN[k] = B[i];
                    i++;
                    j++;
                    k++;
                }
            }
            if (i == 5)
            {
                while (j < 5)
                {
                    UN[k] = A[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < 5)
                {
                    UN[k] = B[i];
                    i++;
                    k++;
                }
            }
            Console.WriteLine("\nB union A: "); //Displaying result of B union A
            for (i = 0; i < k; i++)
            {
                Console.Write(UN[i] + " ");
            }
            Console.WriteLine("\nThis proves that the union of 2 sets is commutative");
            Console.ReadLine();
        }
    }

        
