using System;
class Program
{
    static void Main()
    {
        static int[] CreateArray(int ArrayLength)
        {
            int[] array = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                array[i] = new Random().Next(99);
            }
            return array;
        }

        static int[] SelectionSortArray(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[indexMin])
                    {
                        indexMin = j;
                    }
                }
                int Temp = Array[indexMin];
                Array[indexMin] = Array[i];
                Array[i] = Temp;
            }
            return Array;
        }

        static void ArrayWrite(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }
        Console.WriteLine("Введите длину массива: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // ArrayWrite(CreateArray(ArrayLength: N));
        // Console.WriteLine();
        ArrayWrite(SelectionSortArray(Array: CreateArray(ArrayLength: N)));


    }
}