using System;
    class Com
    {
        public static void Main()
        {
            int i, j, temp;
            int[] A = new int[5];//array declaration
            int[] B = new int[5];
            int[] IN = new int[5];
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
                    i++;
                }
                else if (A[i] > B[j])
                {
                    j++;
                }
                else
                {
                    IN[k] = A[i];
                    i++;
                    j++;
                    k++;
                }
            }
            Console.WriteLine("\nA intersection B: "); //it Displays A intersection B
            for (i = 0; i < k; i++)
            {
                Console.Write(IN[i] + " ");
            }
            i = 0; j = 0; k = 0;
            while ((i < 5) && (j < 5))
            {
                if (B[i] < A[j])
                {
                    i++;
                }
                else if (B[i] > A[j])
                {
                    j++;
                }
                else
                {
                    IN[k] = B[i];
                    i++;
                    j++;
                    k++;
                }
            }
            Console.WriteLine("\nB intersection A: "); //it Displays B Intersection A
            for (i = 0; i < k; i++)
            {
                Console.Write(IN[i] + " ");
            }
            Console.WriteLine("\nThis proves that the intersection of 2 sets is commutative");
        }
    }

        
