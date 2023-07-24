using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment13
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;           
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                        

                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void InsertionSort(int[] array)
        {
            int u = array.Length;
            for (int k = 0; k < u; k++)
            {
                int key = array[k];
                int l = k - 1;
                while (l >= 0 && array[l] > key)
                {
                    array[l + 1] = array[l];
                    l--;
                }
                array[l + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public static void Printinsert(int[] array) { 
            for (int k = 0;k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }

            Console.WriteLine("\n");
        }     
       
        
        static void Main(string[] args)
        {
            int[] arr = { 100, 234, 125, 112, 322, 11, 190 };           
            Console.WriteLine("Print Array without Sort");
            Print(arr);           
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr);         
            stopwatch.Stop();
            Console.WriteLine("After Bubble Sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.WriteLine("\n");
            int[] array = { 100, 234, 125, 112, 322, 11, 190 };
            Console.WriteLine("Print Array without Sort");
            Printinsert(array);           
            stopwatch.Start();
            InsertionSort(array);
            stopwatch.Stop();
            Console.WriteLine("After insertion Sort");
            Printinsert(array);
            Console.WriteLine($"ArraySize {array.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }
    }
}
