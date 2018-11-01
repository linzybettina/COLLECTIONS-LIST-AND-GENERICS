using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic_collections
{
    class dynamicex
    {
        //public void add(int a, int b)//only integer value can be processed
        //{
        //    Console.WriteLine(a + b);
        //}
        //public void sub(int a, int b)
        //{
        //    Console.WriteLine(a - b);

        //}
        //public void mul(int a, int b)
        //{
        //    Console.WriteLine(a * b);
        //}
        //public void div(int a, int b)
        //{
        //    Console.WriteLine(a / b);
        //}
        public void add<T>(T a, T b)// any data type
        {
           // Console.WriteLine(a + b);//shows the error because + operators cannot be applied to the type T
            dynamic d1 = a;
            dynamic d2 = b;//convert the variables a and b to the corresponding data type in

            Console.WriteLine(d1 + d2);
        }
        public void sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);

        }
        public void mul<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void div<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
      static void Main()
      {
    dynamicex dy=new dynamicex();
       dy.add(19,10);
       dy.sub(19, 10);
       dy.mul(19, 10);
       dy.div(19, 10);
       Console.ReadLine();



}}
}
