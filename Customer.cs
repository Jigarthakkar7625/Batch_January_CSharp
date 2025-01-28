using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public static class StaticClass
    {

        public static int customerId { get; set; } // Static

        // public int? CustomerId { get; set; } /// non static
    }


    // Object and Class >>
    public class Customer // non static class
    {

        public static string connString { get; set; } // Static


        public int? CustomerId { get; set; } /// non static

        public virtual string getData()
        {
            return "5";
        }

        const int PI = 3;
        readonly int myDataReadOnly;
        // Class name and Method name are same its call constructor
        public Customer() // Defalt const
        {
            // CustomerId = 10;
        }

        static Customer() // Static const // 1st > static
        {
            connString = "Databaseconnectionstring"; // Only static prop use thay
            //CustomerId = 10;
        }

        public Customer(int customerId) // Parameterise const
        {
            connString = "jijfdsfj";
            myDataReadOnly = customerId;
            //CustomerId = customerId;
        }

        public Customer(Customer customer) // Copy constructor
        {

        }

        //private Customer() // Copy constructor
        //{

        //}

        // Design pattern >
        // Single >>
        // Factory
        // Repository





        // Static 
        // Copy constructor
        // Private constructor




        //public string MyData { get; set; }///

        public void GetData()
        {
            // CustomerId = 150000;

        }
    }

    public class ChildCustomer : Customer
    {
        public override string getData()
        {
            return "jigar";
        }
    }

    public abstract class absractClass
    {
        public abstract string getData();

    }

    public class ChildAbsract : absractClass
    {
        public override string getData()
        {
            return "";
            Console.WriteLine("");
        }
    }


    public class UserClass 
    {
        public int MyProperty { get; set; }
        public string MyProperty11 { get; set; }
        public bool IsACtive { get; set; }
    }

    public class UserClass1
    {
        public int MyProperty { get; set; }
        public string MyProperty11 { get; set; }
        public bool IsACtive { get; set; }
    }


}
