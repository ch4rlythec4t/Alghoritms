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
            int TempLength = Array.Length;
            for (int j = 1; TempLength > 0;)
            {
                for (int i = j; i < TempLength; i++)
                {
                    if (Array[i] < Array[i - 1])
                    {
                        int Temp = Array[i];
                        Array[i] = Array[i - 1];
                        Array[i - 1] = Temp;
                    }
                }
                TempLength--;
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