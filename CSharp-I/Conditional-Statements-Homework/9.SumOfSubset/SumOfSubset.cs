using System;

class SumOfSubset
{
    static void Main()
    {
        int[] array = new int[5];

        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;

        // Second subset
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                int sum = array[i] + array[j];
                if (sum == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", array[i], array[j], sum);
                    count++;
                }
            }
        }

        // Third subset
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    int sum = array[i] + array[j] + array[k];
                    if (sum == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = {3}", array[i], array[j], array[k], sum);
                        count++;
                    }
                }
            }
        }

        // Fourth subset
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    for (int m = k + 1; m < 5; m++)
                    {
                        int sum = array[i] + array[j] + array[k] + array[m];
                        if (sum == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", array[i], array[j], array[k], array[m], sum);
                            count++;
                        }
                    }
                }
            }
        }

        // Fifth subset
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    for (int m = k + 1; m < 5; m++)
                    {
                        for (int p = m + 1; p < 5; p++)
                        {
                            int sum = array[i] + array[j] + array[k] + array[m] + array[p];
                            if (sum == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", array[i], array[j], array[k], array[m], array[p], sum);
                                count++;
                            }
                        }
                    }
                }
            }
        }
    }
}