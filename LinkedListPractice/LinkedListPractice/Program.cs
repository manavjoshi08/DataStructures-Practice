using SimpleGenericLinkedListPractice;
using DoubleLinkedListPractice;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoubleLinkedList 
            {
                //DoubleLinkedList db = new DoubleLinkedList();
                //db.Add(1);
                //db.Add(2);
                //db.Add(3);
                //db.Add(4);
                //db.Add(5);
                //db.Add(6);
                //db.GetAll();
                //int remove = 3;
                //Console.WriteLine("Below is get all after removing a node value: " + remove.ToString());
                //db.Remove(remove);
                //db.GetAll();
                //Console.Read();
            }

            //Logic for print 1 to 100 without using loop
            {
                Console.WriteLine(String.Join(",", Array.ConvertAll<int, string>(Enumerable.Range(1, 100).ToArray(), i => i.ToString())));
                Console.Read();
            }
            
            //Logic to print 1 to 100 without using numbers
            {
                int one = 'x' / 'x';
                string s = "----------";

                for (int i = one; i <= s.Length * s.Length; i++)
                {
                    Console.WriteLine(i);
                }
            }

            //SimpleLinkedList with tail
            {
                //SimpleLinkedListTail sll = new SimpleLinkedListTail();
                //sll.AddLast(1);
                //sll.AddLast(2);
                //sll.AddLast(3);
                //sll.AddLast(4);
                //sll.AddFirst("first");
                //sll.AddLast("last");
                //sll.ReadAll();
            }

            //SimpleLinkedList with tail and generics
            {
                //SimpleLinkedListTail<int> sll = new SimpleLinkedListTail<int>();
                //sll.AddLast(1);
                //sll.AddLast(2);
                //sll.AddLast(3);
                //sll.AddLast(4);
                //sll.AddFirst(0);
                //sll.AddLast(5);
                //sll.Remove(4);
                //sll.ReadAll();
            }
        }
    }
}