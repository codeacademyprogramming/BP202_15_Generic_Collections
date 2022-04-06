using System;
using System.Collections.Generic;

namespace GenericLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIntList intList = new MyIntList();
            intList.Add(45);
            intList.Add(35);
            intList.Add(25);
            intList.Add(15);


            MyStringList myStringList = new MyStringList();

            myStringList.Add("name1");
            myStringList.Add("name2");
            myStringList.Add("name3");
            myStringList.Add("name4");

            intList.RemoveAt(1);

            Console.WriteLine($"count: {intList.Count}");
            foreach (var item in intList.Array)
            {
                Console.WriteLine(item);
            }


            Human human1 = new Human();
            Human human2 = new Human();
            Human human3 = new Human();


            MyHumanList humanList = new MyHumanList();

            MyList<int> genericIntList = new MyList<int>();
            genericIntList.Add(45);
            genericIntList.Add(25);
            genericIntList.Add(15);
            genericIntList.Add(35);

            MyList<string> genericStringList = new MyList<string>();
            genericStringList.Add("name1");
            genericStringList.Add("name2");
            genericStringList.Add("name3");


            genericStringList.Add("dsfd");



            string[] arr = new string[10];
            arr[0] = "dfd";


            genericStringList[0] = "changed name 1";
            Console.WriteLine(genericStringList[0]);


            MyList<Human> genericHumanList = new MyList<Human>();
            genericHumanList.Add(human1);
            genericHumanList.Add(human2);


            int[] nums = new int[10];

            Console.WriteLine("My generic list items:");
            foreach (var item in genericStringList)
            {
                Console.WriteLine(item);
            }

            foreach (var item in GetWeekDays())
            {
                Console.WriteLine(item);
            }

        }

        static IEnumerable<string> GetWeekDays()
        {
            yield return "Bazarertesi";
            yield return "Cersenbe axsami";
            yield return "Cersenbe";
        }
    }
}
