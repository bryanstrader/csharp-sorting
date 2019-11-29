using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<Int32>() { 1, 23, 43, 232, 55, 31, 2, 3, 4, 32, 22, 7, 46, 332 };
            var numbers2 = new List<Int32>() { 1, 2, 3, 4, 5, 7, 8, 10, 22 };

            Console.WriteLine(string.Join(",", numbers.ToArray()));
            
            Console.WriteLine("Bubble sort results for numbers: ");
            SortNumbersBubble(numbers);

            Console.WriteLine("Locate max value: ");
            FindMaxElement(numbers);

            Console.WriteLine("Selection sort results for numbers: ");
            SelectionSort(numbers);

            //binary search, number will be found or not
            //the items must be sorted for binary search to work
            Console.WriteLine("Does number exist in our list: ");
            var num = 22;
            var itemExists = BinarySearch(numbers2, numbers2.Count, num);
            if (itemExists)
                Console.WriteLine(num + " exists");
            else
                Console.WriteLine(num + " does not exists");

            //wait
            Console.ReadKey();
        }


        public static void FindMaxElement(List<Int32> numbers)
        {
            var maxVal = numbers[0];

            for (int v=0; v < numbers.Count; v++)
            {
                if (numbers[v] > maxVal)
                {
                    maxVal = numbers[v];
                }
            }

            Console.WriteLine(maxVal + " is the max value element");
        }


        public static Int32 Factorial(Int32 n)
        {
            if (n == 1)
                return n;

            return n * Factorial(n - 1);
        }

 
        public static void SortNumbersBubble(List<Int32> numbers)
        {
            for (int write = 0; write < numbers.Count; write++)
            {
                for (int sort = 0; sort < numbers.Count - 1; sort++)
                {
                    if (numbers[sort] > numbers[sort + 1])
                    {
                        var temp = numbers[sort + 1];
                        numbers[sort + 1] = numbers[sort];
                        numbers[sort] = temp;
                    }
                }
            }

            //output sorted
            foreach (Int32 num in numbers)            
                Console.WriteLine(num);            
        }


        public static void SelectionSort(List<Int32> numbers)
        {
            var sortedCollection = new List<Int32>();
            var n = numbers.Count;

            for (int x = 0; x < n; x++)
            {
                var minIndex = 0;
                var min = numbers[minIndex];

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                        minIndex = i;
                    }
                }

                numbers.Remove(min);
                sortedCollection.Add(min);
            }

            //output sorted
            foreach (Int32 num in sortedCollection)
                Console.WriteLine(num);
        }



        public static bool BinarySearch(List<Int32> a, Int32 n, Int32 val)
        {
            //if nothing to search
            if (n == 0)
                return false;

            //if only one item check it
            if (n == 1)
                if (a[0] == val)
                    return true;
                else
                    return false;

            if (val < a[(Int32)(double)(n / 2)])
            {
                var count = n / 2 - 1;
                var position = 0;
                var rangeCount = n / 2 + 1;

                return BinarySearch(a.GetRange(position, rangeCount), rangeCount - 1, val);
            }
            else if (val > a[(Int32)(double)(n / 2)])
            {
                var count = n / 2 - 1;
                var position = n / 2 + 1;
                var rangeCount = n / 2 + 1;

                return BinarySearch(a.GetRange(position, a.Count - position), a.Count - position, val);
            }
            else
            {
                return true;
            }
        }

    }
}
