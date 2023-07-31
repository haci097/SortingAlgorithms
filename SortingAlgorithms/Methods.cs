using System;

namespace SortingAlgorithms
{
    public static class Methods
    {
        public static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void SelectionSort(int[] array)
        {
            int min_key, temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min_key = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min_key])
                    {
                        min_key = j;
                    }
                }

                temp = array[min_key];
                array[min_key] = array[i];
                array[i] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public static void InsertionSort(int[] array)
        {
            int j, key;
            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
