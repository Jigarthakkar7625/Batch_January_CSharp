using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    // Object and Class >>
    public class Customer
    {
        const int PI = 3;
        readonly int myDataReadOnly;
        // Class name and Method name are same its call constructor
        public Customer() // Defalt const
        {
           // CustomerId = 10;
        }

        public Customer(int customerId) // Parameterise const
        {
            myDataReadOnly = customerId;
            //CustomerId = customerId;
        }

        public int? CustomerId { get; set; }///

        //public string MyData { get; set; }///

        public void GetData()
        {
           // CustomerId = 150000;
            
        }
    }
}
