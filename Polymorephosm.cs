using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public class Polymorephosm
    {

        public virtual int ParentGetData(int b, string a)
        {
            return 1;
        }

        // Polymorphism : 
        // Method overloading : Same name of method : Same class > Paremeter should be diffrent
        // Its not depends on return type
        // Method overriding : Same name of method >> Child class

        //public int GetData(int b, string a)
        //{
        //    return 1;
        //}
        //public int GetData(int a)
        //{
        //    return 1;
        //}


    }

    public class ChildPolymorephosm : Polymorephosm
    {
        public override int ParentGetData(int b, string a)
        {
            return 123;
        }

    }


    // Interface : Multiple Inharitance, Only Public, not support Constructor
    // abstract : Single inharitance, Access modifiers, support Constructor
    public abstract class AbsractParentClass
    {
        public abstract void GetCustomerData();

        public void GetData()
        {
            Console.Write("");
        }
    }

    public class ChildAbsractParentClass : AbsractParentClass
    {
        // Virtual and Absrtact >> Ovveride
        public override void GetCustomerData()
        {

        }

    }
    public class Demo //non absract
    {
        public void GetCustomerData1233() { 
        }

    }
}
