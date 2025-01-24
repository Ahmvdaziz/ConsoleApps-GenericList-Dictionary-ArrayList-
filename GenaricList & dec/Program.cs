using System.Collections;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GenaricList___dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[2];
            ints[0] = 1;
            ints[1] = 2;
            foreach (var i in ints)
            {
                // System.Console.WriteLine(i);
            }
            //Console.WriteLine("Hello, World!");
            /*Array List 
            not strong type collection
            */
            #region ArrList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add("Ahmed");
            //arrayList.Add("Aziz");
            //arrayList.AddRange(new int[] { 3, 4, 5 });
            //arrayList.Remove(1);// remove first 1
            //arrayList.RemoveAt(1);// remove index 1
            //arrayList.RemoveRange(0, 2);// remove from index 0 to 2
            //arrayList.Insert(0, 1);// insert 1 at index 0
            //arrayList.InsertRange(1, new int[] { 1, 2, 3 });// insert 1,2,3 at index 0
            //foreach (var item in arrayList)
            //{
            //    System.Console.Write(item + " ");
            //}
            #endregion
            #region Generic List 

            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            //  list.Capacity
            list.AddRange(new int[] { 3, 4, 5 });
            list.Remove(1);// remove first 1
            list.RemoveAt(1);// remove index 1
            list.RemoveRange(0, 2);// remove from index 0 to 2
            list.Insert(0, 1);// insert 1 at index 0
            list.InsertRange(1, new int[] { 1, 2, 3 });// insert 1,2,3 at index 0
            foreach (var item in list)
            {
                // System.Console.Write(item + " ");
            }
            var res = list[0] + list[1];
            Console.WriteLine(res);

            var listofstring = new List<string>();
            listofstring.Add("Ahmed");
            listofstring.Add("Aziz");
            listofstring.AddRange(new string[] { "Omar", "Mohamed" });
            listofstring.Remove("Ahmed");
            listofstring.RemoveAt(1);
            listofstring.RemoveRange(0, 2);
            foreach (var item in listofstring)
            {
                System.Console.Write(item + " "); // فاااااضي
            }

            #endregion
            #region Dictionary

            //var dic = new Dictionary<int, string>();
            //dic.Add(1, "Ahmed");
            //dic.Add(2, "Aziz");
            //dic.Add(3, "Omar");
            //dic.Add(4, "Mohamed");
            // Console.WriteLine(dic.ContainsKey(1));
            //   Console.WriteLine(dic[1]);
            #endregion

            #region FilmsApp
            Console.WriteLine("Welcome to the Film Management App");
            Console.WriteLine("what do you want to do");
            Console.WriteLine("1- Add new film");
            Console.WriteLine("2- Show all films");
            Console.WriteLine("3- Search for film");
            Console.WriteLine("4- Delete film");
            Console.WriteLine("5- Exit");
            var films = new List<string>();
            while (true)
            {
                if (films.Count == 0)
                {
                    Console.WriteLine("No films added yet");
                }
                var choiccce = int.Parse(Console.ReadLine());
                if (choiccce == 1)
                {
                    Console.WriteLine("Enter film name");
                    var film = Console.ReadLine();
                    films.Add(film);
                    Console.WriteLine("Film added");
                    Console.WriteLine("what do you need again?");

                }
                if (choiccce == 2)
                {
                    foreach (var film in films)
                    {
                        Console.WriteLine(film);
                    }
                }
                if (choiccce == 3)
                {
                    Console.WriteLine("Enter film name");
                    var film = Console.ReadLine();
                    if (films.Contains(film))
                    {
                        Console.WriteLine("Film found");
                    }
                    else
                    {
                        Console.WriteLine("Film not found");
                    }
                }
                if (choiccce == 4)
                {
                    Console.WriteLine("Enter film name");
                    var film = Console.ReadLine();
                    if (films.Contains(film))
                    {
                        films.Remove(film);
                        Console.WriteLine("Film deleted");
                    }
                    else
                    {
                        Console.WriteLine("Film not found");
                    }
                }
                if (choiccce == 5)
                {
                    break;
                }
            }
            #endregion
            #region Customer order management
            var orders = new List<string>();
            char choice = 'y';

            while (choice == 'y')
            {
                Console.WriteLine("Add new order");

                Console.WriteLine("Enter the name of the customer:");
                var name = Console.ReadLine();

                Console.WriteLine("Enter the order of the customer:");
                var order = Console.ReadLine();

                orders.Add($"Customer: {name}, Order: {order}");
                Console.WriteLine("Order added successfully!");

                Console.WriteLine("Do you want to add another order? (y/n):");
                choice = char.Parse(Console.ReadLine().ToLower());
            }

            Console.WriteLine("Do you want to show all orders? (y/n):");
            choice = char.Parse(Console.ReadLine().ToLower());

            if (choice == 'y')
            {
                Console.WriteLine("All Orders:");
                foreach (var item in orders)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Thank you!");
            }

            #endregion


            #region Electronic dictionary
            Console.WriteLine("Hello for our dectionary app");
            var dic = new Dictionary<string, string>();
            dic.Add("يأكل", "eat");
            dic.Add("يشرب", "drink");
            dic.Add("ينام", "sleep");
            dic.Add("يعمل", "work");
            dic.Add("يدرس", "study");
            dic.Add("يقرأ", "read");
            dic.Add("يكتب", "write");
            dic.Add("يسمع", "listen");
            dic.Add("يتكلم", "speak");
            dic.Add("يشاهد", "watch");
            dic.Add("يسافر", "travel");
            dic.Add("يستمع", "listen");
            dic.Add("يستمتع", "enjoy");
            dic.Add("يتعلم", "learn");
            dic.Add("يعلم", "teach");
            dic.Add("يفهم", "understand");
            dic.Add("يعرف", "know");
            dic.Add("يسأل", "ask");
            dic.Add("يجيب", "answer");
            dic.Add("يفتح", "open");
            dic.Add("يغلق", "close");
            dic.Add("يدخل", "enter");
            dic.Add("يخرج", "exit");
            dic.Add("ينظر", "look");
            dic.Add("يجلس", "sit");
            dic.Add("يقف", "stand");
            dic.Add("يمشي", "walk");
            dic.Add("يجري", "run");
            dic.Add("يسبح", "swim");
            dic.Add("يقود", "drive");
            dic.Add("يطير", "fly");
            dic.Add("يصعد", "climb");
            dic.Add("ينزل", "go down");
            Console.WriteLine("what do You want to do?");
            Console.WriteLine("1- Add new word");
            Console.WriteLine("2- Translate Word");
            var choicce = int.Parse(Console.ReadLine());
            if (choicce == 1)
            {
                Console.WriteLine("Enter the Arabic word");
                var arabic = Console.ReadLine();
                Console.WriteLine("Enter the English word");
                var english = Console.ReadLine();
                dic.Add(arabic, english);
                Console.WriteLine("Word added successfully");
            }
            if (choicce == 2)
            {
                Console.WriteLine("Enter the Arabic word");
                var arabic = Console.ReadLine();
                if (dic.ContainsKey(arabic))
                {
                    Console.WriteLine(dic[arabic]);
                }
                else
                {
                    Console.WriteLine("Word not found");
                    Console.WriteLine("Do you want to add it? (y/n)");
                    var add = Console.ReadLine();
                    if (add == "y")
                    {
                        Console.WriteLine("Enter the English word");
                        var english = Console.ReadLine();
                        dic.Add(arabic, english);
                        Console.WriteLine("Word added successfully");
                    }

                }
            }
            #endregion

        }

    }
}
