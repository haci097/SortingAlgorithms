using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };

            Console.WriteLine("Bubble Sort: ");
            Methods.BubbleSort(array);

            Console.WriteLine("Selection Sort: ");
            Methods.SelectionSort(array);

            Console.WriteLine("Insertion Sort: ");
            Methods.InsertionSort(array);

        }
    }
}
