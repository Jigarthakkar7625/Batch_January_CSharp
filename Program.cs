using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static MyDemo.Enum;

namespace MyDemo // Family name
{
    //.NET framework : 
    //Build >> language(C#, J#, F#, VB.NET) >> Publish >> Window(exe) and Web application (API) >>  ERP
    //Server >> Window server


    //.NET CORE : open source >> Platform ind...


    delegate int MyDelegate(int n);

    public class Delegates
    {
        // Method > As Parameter pass karvu che

        public static int AddData(int a)
        {
            return a + 10;

        }

        public static int MulData(int a)
        {
            return a * 10;

        }
    }

    public static class Program
    {

       
        static void Main(string[] args)
        {

            //int[] ints1 = { 1, 2, 3 };
            var fsfdsffdsf = getData122(true,11,"dassd","fsdf",3243,'s');

            // Delegate
            MyDelegate d1 = new MyDelegate(Delegates.AddData);
            MyDelegate d2 = new MyDelegate(Delegates.MulData);

            var value = d1(20);







            var monday = (int)Days.Monday;
            var monday1 = (int)Days.Tuesday;
            var monday2 = (int)Days.Wednesday;
            var monday3 = (int)Days.Thursday;
            var monday4 = (int)Days.Friday;
            var monday5 = (int)Days.Saturday;
            var monday6 = (int)Days.Sunday;

            int abcdsad = 10;


            Type trre = abcdsad.GetType();



            Type t = typeof(MyDelegate);
            Type t11 = typeof(System.String);

            Console.WriteLine(t11.FullName);
            Console.WriteLine(t11.BaseType);
            Console.WriteLine(t11.IsClass);
            Console.WriteLine(t11.IsEnum);



            var getDesc = Days.Monday.DescriptionAttr();
            //foreach (var item in Enum.GetValues(typeof(Days)))
            //{
            //    Console.WriteLine(item);
            //}



            List<int> ints = new List<int> { 1, 2, 3 };
            ints.Add(1);

            GenericConstrain<bool> genericConstrain = new GenericConstrain<bool>();
            genericConstrain.Add(false, true);

            GenericConstrain<int> genericConstrain1 = new GenericConstrain<int>();
            genericConstrain1.Add(1, 2);
            genericConstrain1.Add(4, 3);


            // Class : 
            GenericConstrainClass<string> genericConstrainClass = new GenericConstrainClass<string>();

            GenericConstrainClass<Polymorephosm> genericConstrainClass1 = new GenericConstrainClass<Polymorephosm>();
            Polymorephosm polymorephosm1 = new Polymorephosm();

            genericConstrainClass1.Add(polymorephosm1);
















            List<Polymorephosm> ints2 = new List<Polymorephosm>();


            //var tuple = Tuple.Create(1, 2, 3, 4, "5", true, 7, Tuple.Create(1, 2, 3, 4));


            //var i1 = tuple.Item1;
            //var i2 = tuple.Item7;
            //var rest = tuple.Rest; // Last element

            //var rest11 = tuple.Rest.Item1; // Last element

            //List<Tuple<int, string>> list1 = new List<Tuple<int, string>>
            //{
            //    Tuple.Create(1,"jigar"),
            //    Tuple.Create(1,"Nidhi"),
            //};

            //foreach (var item in list1)
            //{
            //    //item.Item1
            //}







            // fibbo :

            //List<int> ints = new List<int> { 1, 2, 3, 4, 5, 3 };

            //var dec = ints.OrderByDescending(x => x).ToList();

            //var getOdd = ints.Where(x => x % 2 !=0).ToList();


            ////var dec1 = ints.Take(5).TakeWhile().ToList();

            //// Fibboci >> 
            //int n = 10;
            //int a = 0, b = 1, c=0;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(a);
            //    c = a + b;
            //    a = b;
            //    b = c;
            //}

            //Console.ReadLine();


            // DSA :: 

            // 1 : Generic collection :: Rule and regulation
            // List<T>

            //List<UserClass> ints22 = new List<UserClass>();

            //UserClass1 UserClass1 = new UserClass1();
            //UserClass1.MyProperty = 1;
            //UserClass1.MyProperty11 = "jigar";
            //UserClass1.IsACtive = true;

            ////ints22.Add(UserClass1);

            //ints22.Add(new UserClass { MyProperty = 1, MyProperty11 = "jigar", IsACtive = true });


            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);


            //ints.Remove(4);

            //// ints.RemoveAt(10);
            ////ints.Clear();

            //bool a = ints.Contains(4);

            //List<int> ints1 = new List<int>();
            //ints1.Add(5);
            //ints1.Add(6);


            //ints.AddRange(ints1);

            //int count = ints.Count;

            //if (ints.Count > 0)
            //{
            //    //
            //}




            //foreach (var item in ints)
            //{
            //    Console.Write(item);

            //}
            //Console.ReadLine();




            // Dictionaty<TKey,Tvalue>

            Dictionary<int, string> values = new Dictionary<int, string>();
            //Dictionary<int, string> values = new Dictionary<int, string>();
            //values.Add(1, null);
            //values.Add(2, null);
            //values.Add(3, null);
            //foreach (var item in values)
            //{
            //    Console.Write(item.Key);
            //    Console.Write(item.Value);
            //}


            // Queue<T> > FIFO
            //Queue<int> queue = new Queue<int>(); 
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);  
            //queue.Enqueue(5);

            //queue.Dequeue();

            //var peekElement = queue.Peek(); // 

            //queue.Clear();
            //var c = queue.Count;

            //Console.ReadLine();


            //// Stack<T> :: LIFO
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //stack.Pop();

            //var a = stack.Peek();


            //// Hashtable<T>
            //HashSet<int> set = new HashSet<int>(); // unique value store
            //set.Add(10);
            //set.Add(20);
            //set.Add(10);



            // 2. Non-Generic collection :: NO
            // ArrayList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("jigar");
            //arrayList.Add("jigar");
            //arrayList.Add(true);
            //arrayList.Add('C');


            //// Queue
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("dsada");
            //queue.Enqueue(false);

            //// Stack

            // Hashtable

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "jigar");
            hashtable.Add("sdsd", "jigar12121");
            hashtable.Add(true, false);
            //hashtable.Add("sdsd", "sasdffdsf");

            // SortedList
            SortedList SortedList1 = new SortedList();
            SortedList1.Add(4, "jigar");
            SortedList1.Add(2, "jigar12121");
            SortedList1.Add(5, false);
            //SortedList1.Add("sdsd", "sasdffdsf");


            //

            //var tuple = new Tuple<int, string, string>(10, "str", "fdg");
            //var b = tuple.Item1;
            //var a = tuple.Item2;

            List<(int id, string name, bool isavtive)> lisrt = new List<(int, string, bool)>();

            lisrt.Add((id: 1, name: "jigar", isavtive: true));
            lisrt.Add((id: 1, name: "jigar", isavtive: true));
            lisrt.Add((id: 1, name: "jigar", isavtive: true));



            // Exception handling:

            // FileIO
            // Multithreading
            // GC

            try
            {

                MyPartialClass myPartialClass = new MyPartialClass();
                myPartialClass.UserId = 1;
                myPartialClass.UserName = "fds";
                myPartialClass.getData();

                myPartialClass.getData(1);

                //try
                //{
                //    int a1 = 10;
                //    int b1 = 0;

                //    var resul1111 = a1 / b1;
                //}
                //catch (Exception e) //Exception e >> Global
                //{
                //    Console.WriteLine(e);
                //}
                //finally
                //{
                //    Console.WriteLine("Finally");
                //}

                //int a = 10;
                //int b = 10;

                //var result = a / b;

                throw new Exception("Useer ID is not added");

                // int a = 10;

            }


            catch (ArgumentException e) //Exception e >> Global
            {
                Console.WriteLine(e);
            }

            catch (NullReferenceException e) //Exception e >> Global
            {
                Console.WriteLine(e);
            }
            catch (FormatException e) //Exception e >> Global
            {
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e) //Exception e >> Global
            {
                Console.WriteLine(e);
            }
            catch (Exception e) //Exception e >> Global
            {
                Console.WriteLine(e);
            }
            finally // Everytime this will called
            {
                Console.WriteLine("Finally");
            }



            Polymorephosm polymorephosm = new Polymorephosm();

            Polymorephosm paarentObject11 = new Polymorephosm();
            var getresponse12 = paarentObject11.ParentGetData(1, "fsd");

            Polymorephosm paarentObject = new ChildPolymorephosm();
            var getresponse = paarentObject.ParentGetData(1, "fsd");

            //polymorephosm.GetData(1,"jigar");


            //polymorephosm.GetData(2);

            //polymorephosm.GetData(1);

            //AccessModifires accessModifires = new AccessModifires();

            //accessModifires.UserName = "fsf";
            //accessModifires.UserId = 123;

            //accessModifires.getData();
            //accessModifires.PrivateGetData();


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

            //string c = "C#";
            //if (c == "C#" || c == "Java" || c == "PHP")
            //{

            //}

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

        //var fsfdsffdsf = getData122(true, 11, "dassd", "fsdf", 3243, 's');
        public static int getData122(params object[] d) // AM // REturn type // F Name
        {
            //d = 150;
            foreach (var item in d)
            {

            }
            return 1;

        }

        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
    }

   
}
