using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                SortedList<int, string> sortedList = new SortedList<int, string>();
                sortedList.Add(2, "7");
                sortedList.Add(1, "6");
                sortedList.Add(3, "8");
                sortedList.Add(4, "9");
                sortedList.Add(5, "10");
                Console.Write("\n\n\nSortedList: ");
                foreach (KeyValuePair<int, string> kvp in sortedList)
                {
                    Console.Write($"Key = {kvp.Key}, Value = {kvp.Value} ");
                }

                List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
                Console.Write("List: ");
                foreach (var i in list)
                {
                    Console.Write($"{i} ");
                }
                HashSet<int> hash = new HashSet<int>();
                for (int i = 0; i < 11; i++)
                {
                    hash.Add(i * 2);
                }
                Console.Write("\n\n\nHash Table: ");
                foreach (var i in hash)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();


                Queue<string> queue = new Queue<string>();
                queue.Enqueue("10");
                queue.Enqueue("11");
                queue.Enqueue("12");
                queue.Enqueue("13");
                queue.Enqueue("14");
                Console.Write("\n\n\nQueue: ");
                foreach (var i in queue)
                {
                    Console.Write($"{i} ");
                }
                Console.Write("\n\n\nLinkedList: ");
                LinkedList<int> vs = new LinkedList<int>();
                vs.AddFirst(6);
                vs.AddAfter(vs.First, 5);
                vs.AddAfter(vs.First, 4);
                vs.AddAfter(vs.First, 3);
                vs.AddAfter(vs.First, 2);
                foreach (var i in vs)
                {
                    Console.Write($"{i} ");
                }
                Console.Write("\n\n\nStack: ");
                Stack<int> stack = new Stack<int>();
                stack.Push(6);
                stack.Push(7);
                stack.Push(8);
                stack.Push(9);
                stack.Push(10);
                foreach (var i in stack)
                {
                    Console.Write($"{i} ");
                }



                Dictionary<int, string> keyPairs = new Dictionary<int, string>();
                keyPairs.Add(1, "Bird");
                keyPairs.Add(2, "Zebra");
                keyPairs.Add(3, "Big dog");
                keyPairs.Add(4, "Small dog");
                keyPairs.Add(5, "Medium dog");
                Console.Write("\n\n\nDictionary: ");
                foreach (KeyValuePair<int, string> kvp in keyPairs)
                {
                    Console.Write($"Key = {kvp.Key}, Value = {kvp.Value}");
                }

            }
        }
    }
}
