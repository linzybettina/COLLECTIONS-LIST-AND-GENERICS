using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic_collections
{
    class Class2
    {
        //public bool compare(object a, object b)
        //{
        //    if (a.Equals(b))
        //        return true;
        //    return false;
        //}
        //public bool compare(float a, float b)
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}
        //public bool compare(double a, double b)
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}
        //public bool compare(string a, string b)
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}
        public bool compare<T>(T a,T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
       

        static void Main()
        {
            //Class2 obj = new Class2();
            //bool result = obj.compare(10,10);//compare integer

            //Class2 obj = new Class2();   
            //bool result = obj.compare(true,true);//compare boolean

            Class2 obj = new Class2();
            //bool result = obj.compare(12.5f,13);//compare float and integer,boxing and unboxing will be done

           // bool result = obj.compare<float>(12.5f,13.56);//can't convert to float so it shows error
            bool result = obj.compare<float>(12.5f, 13.56f);//it is Type safe

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }}
     
