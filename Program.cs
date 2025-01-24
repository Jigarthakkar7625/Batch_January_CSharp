using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDemo // Family name
{
    //.NET framework : 
    //Build >> language(C#, J#, F#, VB.NET) >> Publish >> Window(exe) and Web application (API) >>  ERP
    //Server >> Window server


    //.NET CORE : open source >> Platform ind...


    public class Program
    {


        static void Main(string[] args)
        {


            AccessModifires accessModifires = new AccessModifires();

            accessModifires.UserName = "fsf";
            accessModifires.UserId = 123;

            accessModifires.getData();
            accessModifires.PrivateGetData();


            var PassinCopy = new Customer();
            Customer copyConstr = new Customer(PassinCopy); // OBJECT // Memory sto

            Customer customer = new Customer(); // OBJECT // Memory sto
            Customer customer22 = new Customer(10); // OBJECT // Memory sto

            StaticClass.customerId = 10; // No need to create object 

            

            //.ToString();
            // Convert.ToString();

            string abcdddd = null;
            string newVal = abcdddd.ToString();
            string newVal111 = Convert.ToString(abcdddd);


            // Boxing and unBoxing >> HW

            // ReadOnly and Const

            

            Customer customer1 = null;
            customer1.ToString();

            //string newVal111 = Convert.ToString(abcdddd);


            customer.CustomerId = null;

            customer.CustomerId = 1500;


            customer.GetData();


            //Customer customer1 = new Customer(100); // OBJECT

            //int acc = customer1.CustomerId;
            //customer.GetData();

            //debug : F10
            // Debug >> Inside defination >> F11

            // C and C++ >>> C# >> C sharp

            // var abc = 10;

            //string a = "JIgar";
            //a = "Pooja";

            //int b = 10; 

            //int userId = 20;
            //int userName = 20;

            //char charVar = 'A';


            //int  >> num
            //Long >> num >> Big size 
            //Float >> 6 to 7 Decimal
            //Double >> 15 digit
            //Bool >> True or true
            //CHAR >> 'A', 'B'
            //String >> "jigar"


            // SImple Data types  >> Int, Flot, Char, Boolean


            /*var ABC = 10;
            Console.WriteLine(ABC);
            */

            // Value Types
            // SImple Data types  >> Int, Flot, Char, Boolean
            // Enum
            // Struct
            // nullable

            // Reference Type >> String
            // Class
            // interface
            // Array
            // Delegates

            // Type Casting  > 
            // Implicit Type Casting (Automatic)
            // 

            //int myInt = 9;
            //double myDouble = myInt; // There is no error >>

            //// Explicit Type Casting (Manully)

            //double myDoubleDemo = 10.2;
            //int myIntDemo = (int) myDoubleDemo; // There is am error

            //string temp = "Jigar";

            //Console.WriteLine(myDouble);
            //Console.WriteLine("</ br>");
            //Console.WriteLine(myIntDemo);
            //Console.ReadLine();



            //Operators : 

            // Arithmetic +,-,*,/,%
            // (++) (--) // Increment and decrement >> 
            // Post increment  and Pre incremetn
            // Post D and pre D

            //int a = 10;
            //Console.WriteLine(a++); // Post increment 10
            //Console.WriteLine(a++); // 11
            //Console.WriteLine(a); // pre increment
            //Console.WriteLine("<br>"); // pre increment
            //Console.WriteLine(++a); // pre increment

            //Console.ReadLine();

            // Assignment

            //int a = 5; // Assignment 
            //int b = 5;
            //// b += 10 >> b = b + 10;

            //string sql = "jigar";
            //sql += "Hello"; // sql = sql +  "Hello";
            //sql += "Hellodsd"; // sql = sql +  "Hellodsd";
            //sql += "Hello sds"; // sql = sql +  "Hello sds";
            //sql += "Hello dsd s"; // sql = sql +  "Hello dsd s";


            //Console.WriteLine(sql);
            //Console.ReadLine();
            // Relational  > > TRUE and False

            //int a = 10;
            //int b = 20;

            //int c = 30;
            //int d = 40;

            //var result = a == b; 
            //var result1 = a != b;
            //var result2 = a > b; 
            //var result3 = a < b; 
            //var result4 = a >= b; 
            //var result5 = a <= b; 



            // Logical >> &&, ||, !
            //int a = 10;
            //int b = 20;

            //int c = 30;
            //int d = 40;

            //var result = a == b || b == c;

            // 1 && 1 >> 1
            // 1 && 0 >> 0
            // 0 && 1 >> 0
            // 0 && 0 >> 0

            // 
            // 1 || 1 >> 1
            // 1 || 0 >> 1
            // 0 || 1 >> 1
            // 0 || 0 >> 0


            // Bitwise  >> HW


            // ternary operator

            // Flow Statement >> 
            //  Selection Statement (Conditional) (if, Switch)
            // Iteration Statement (for, do-while, while, foreach)
            // Jump (Break, Continue, return, Goto(X))

            //int a = 10;
            //int b = 10;
            //if (a != 10) // Check first
            //{
            //    Console.WriteLine("TRUE");
            //    //if (b == 10)
            //    //{
            //    //    Console.WriteLine("TRUE");

            //    //}
            //}
            //else if (b == 10)
            //{
            //    Console.WriteLine("TRUE");

            //}

            //else
            //{
            //    Console.WriteLine("FALSE");
            //}

            string c = "C#";
            if (c == "C#" || c == "Java" || c == "PHP")
            {

            }

            String abc = "APPLE";

            // A = 1
            // P = 2
            // L = 1
            // E = 1

            //switch (c)
            //{

            //    case "C#":
            //        Console.WriteLine(1);
            //    case "Java":
            //    case "PHP":
            //        Console.WriteLine(1);
            //        break;

            //    case "Jigar":
            //    case "Thakkar":
            //    case "Hello":
            //        Console.WriteLine(10);
            //        break;
            //    //case 1:
            //    //    Console.WriteLine(1);
            //    //    break;
            //    //case 2:
            //    //    Console.WriteLine(2);
            //    //    break;
            //    //case 10:
            //    //    Console.WriteLine(10);
            //    //    break;
            //    default:
            //        Console.WriteLine(10);
            //        break;

            //}


            // 

            int v = 10;

            //for (int i = 0; i <= v; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //while (v <= 1) // First condition check thase
            //{
            //    Console.WriteLine(v);
            //    v++;
            //}

            //do // Always execute first time
            //{
            //    Console.WriteLine(v);
            //    v++;

            //} while (v <= 1);



            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //// ctrl + k+d >> Formating
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}



            // Break : 




            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}




            int d = 10;
            int h = 20;



            //getData(ref d);

            //Console.WriteLine(d);
            //Console.ReadLine();

            //// Call by value and Call by reference

            //for (int i = 0; i < 10; i++)
            //{
            //    int y = a * 20;
            //    int res = b * 30;

            //    getData(y);


            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    int y = a * 300;
            //    int res = b * 400;

            //    getData(y); //



            //}

            // Recursion : 


            var result1 = fun(5);

            //5! >> 5 * 4 * 3 * 2 * 1 >> 120
            //1! >> 1



            

            //Console.WriteLine(first + " " + second);
            //Console.WriteLine(string.Concat(first + " " + second));

            //if (string.Equals(first, second))
            //{

            //}


            //if (first.Equals(second))
            //{

            //}

            //string first1 = "Jigar \"fdsds\" dsfdsfsd fd";


            //string dynamic = string.Empty;
            //dynamic += "Newstring";

            //dynamic += "dfdsdsfsd";
            //dynamic += "fdsfsfsf";

            //// String interpolation : 

            //string abccccc = "jigar Yatri # Krtul # Arti";

            //Console.WriteLine($"My Name is : {abccccc} !!!");

            //string result = "My Name is : " + abccccc + " !!!"; // memory 

            //// Split : 

            //var splitData = abccccc.Split('#');

            //foreach (var item in splitData)
            //{

            //}

            ////Substring : 

            //string resultSubString = abccccc.Substring(3, 6);

            string first = "  J i g a g  r g fdf  dfdf g jigar thakkar  ";
            string second = "Jigar Thakkar";

            //string trimResult = first.Trim();
            //string trimResult = second.Replace("Thakkar","Patel");

            //int trimResultInde = first.IndexOf('g'); // index

            //int trimResultIndexx = first.LastIndexOf("HAR"); // Index

            //bool abcsds = second.StartsWith("Ji");
            //bool abcsdsdsd = second.EndsWith("ar");


            string myDecimal = "423";  //7 Character >>> 4230000

            //string result = myDecimal.PadLeft(7, '0');
            //string results = myDecimal.PadRight(7, '0');


            if (string.Compare(first, "fgdgd", StringComparison.OrdinalIgnoreCase) > 0)
            {

            }










            Console.ReadLine();

        }

        public static int fun(int d) // AM // REturn type // F Name
        {
            if (d == 1)
            {
                return 1;
            }
            else
            {
                return (d * fun(d - 1));
            }
            //if (d > 0)
            //{
            //    Console.WriteLine(d);
            //    fun(d - 1);
            //}

        }

        public static void getData(ref int d) // AM // REturn type // F Name
        {
            d = 150;

            //getData(10);


            //if (y == 200)
            //{
            //    Console.WriteLine("fds");
            //}
            //else
            //{
            //    Console.WriteLine("fds");
            //}
        }
    }
}
