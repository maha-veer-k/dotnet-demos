using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{
    class Search
    {
        public bool LinearSearch(int key, int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == key) return true;
            }
            return false;
        }

        public bool BinarySearch(int key, int[] arr)
        {
            Array.Sort(arr);
            int n = arr.Length, mid, high = n - 1, low = 0;
            while (low <= high)
            {
                mid = (low + high) >> 1;
                if (arr[mid] == key) return true;
                else if (arr[mid] > key) high = mid - 1;
                else low = mid + 1;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr =  new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the key ");
            int searchKey = Convert.ToInt32(Console.ReadLine());

            if (search.BinarySearch(n, arr)) Console.WriteLine("element found");
            else Console.WriteLine("element not found");
        }
    }
}