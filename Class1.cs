using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic_collections
{
    public class Class1
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(40);
            li.Add(60);
            li.Add(70);
            li.Add(90);
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
                Console.WriteLine();
            }
            li.Insert(3, 35);
            li.Insert(6, 35);
            li.Insert(0, 35);
            li.Insert(2, 35);
            Console.Write("after inserting the values in list");
            Console.WriteLine();
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
                Console.WriteLine();
            }
            Console.Write("after Removing  the values in list");
             li.Remove(1);
            li.Remove(2);
            li.Remove(3);
            li.Remove(4);
            Console.WriteLine();
            foreach(int v in li)
                            Console.WriteLine(v +" ");
            Console.WriteLine();
                        Console.ReadLine();

        }
    }
}
