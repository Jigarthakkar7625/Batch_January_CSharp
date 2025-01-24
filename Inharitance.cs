using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public class A
    {
        public int AProperty { get; set; }

    }


    public class B : A // Single Inharitance
    {
        public int BProperty { get; set; }
    }


    public class C : B // Multi level inhritance 
    {
        public int CProperty { get; set; }
    }


    public class D : A, B // Multi level inhritance 
    {
        public int CProperty { get; set; }

        public void GetData()
        {
            Console.Write("");
        }
    }


    public interface IA // Default public access modi
    {
        //public int userid { get; set; }; //Property is not allow
        
        int AProperty { get; set; }

        void GetDataA(); // Declaration
    }

    public interface IB
    {
        void GetDataB();  // Declaration
    }


    public class MultipleInharitance : IA, IB // Multi level inhritance 
    {
        public void GetDataA()
        {
            Console.Write("sdas"); // Datbase mathi data get karsu
        }

        public void GetDataB()
        {
            Console.Write("sdas");
        }
    }

}
