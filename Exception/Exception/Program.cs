using Exception.Models;
using System;
using System.Collections.Generic;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice
            //MyList<int> myList = new MyList<int>();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(6);
            //myList.Add(8);
            //myList.Add(12);
            //myList.Add(123);
            //myList.Add(15);
            //myList.Add(14);
            //myList.Add(178);

            //myList.GetAll();

            //List<int> list = new List<int>() { 1, 2, 4, 6, 8, 13, 16 };
            //myList.AddRange(list);
            //myList.GetAll();

            //MyList<string> names = new MyList<string>();
            //names.Add("Orxan");
            //names.Add("Sabir");
            //names.Add("Ilkin");
            //names.Add("Seid");
            //names.Add("Emil");

            //var result = names.Find(m => m == "Orxan");
            //Console.WriteLine(result);
            #endregion

            #region Homework FindAll

            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(22);
            nums.Add(23);
            nums.Add(2);

            var result2 = nums.FindAll(m => m == 3);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            #endregion


        }
    }
}
