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
            var myCollection = new Dictionary<string, Int32>();

            //C# has an implementation of linked list
            var myLinkedList = new LinkedList<object>();

            //SortNumbersBubble(numbers);

            //FindMaxElement(numbers);

            //SelectionSort(numbers);

            //Console.WriteLine(Factorial(5));
     
            


            Console.ReadKey();
        }


        public static void FindMaxElement(List<Int32> numbers)
        {
            var maxVal = numbers[0];

            for (int v=0; v < numbers.Count -1; v++)
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

   
        //slow
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

        //somewhat faster than bubble
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


        public static void InsertionSort(List<Int32> numbers)
        {



        }


        public static void QuickSort(List<Int32> numbers)
        {



        }


    }
}
