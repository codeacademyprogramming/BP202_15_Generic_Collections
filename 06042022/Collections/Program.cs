using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Non Generic Collections
            ArrayList arrayList1 = new ArrayList();

            arrayList1.Add(45);
            arrayList1.Add("name1");


            ArrayList arrayList2 = new ArrayList();
            arrayList2.AddRange(arrayList1);
            arrayList2.Add(45.4);

            arrayList2.RemoveAt(1);

            Console.WriteLine("Arraylist items:");
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }

            SortedList sortedList = new SortedList();
            sortedList.Add("Hikmet", "12345678");
            sortedList.Add("Abbas", "13245678");
            //sortedList.Add(45, 2345454);

            Queue queue = new Queue();
            queue.Enqueue(45);
            queue.Enqueue(15);
            queue.Enqueue(25);
            queue.Enqueue(35);

            Console.WriteLine("Peek: "+queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            Console.WriteLine("Queue elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(45);
            stack.Push(35);
            stack.Push(25);

            Console.WriteLine("Pop: "+stack.Pop());
            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("Peek: " + stack.Peek());

            Console.WriteLine("Stack items:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Generic collections

            List<int> nums = new List<int>();

            nums.Add(45);

            nums.Add(50);
            nums.Add(30);
            nums.Add(23);
            nums.Add(28);
            nums.Add(28);
            nums.Add(28);
            nums.Add(28);

            Console.WriteLine("Count: "+nums.Count);
            Console.WriteLine("Capacity: " + nums.Capacity);



            nums.Sort();
            nums.Reverse();

            nums.Remove(23);
            nums.RemoveAt(0);

            nums[0] = 20;

            Console.WriteLine("List items");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("AP1001", "Hikmet Abbasov");
            students.Add("AP1002", "Abbas Abbasov");
            students.Add("AP1003", "Gulten Abbasova");
            students.Add("AP1004", "Nigar Abbaszade");

            var name = students["AP1005"];


            #endregion

        }
    }
}
