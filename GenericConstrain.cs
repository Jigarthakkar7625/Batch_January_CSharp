using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    // Struct >> Value
    // Class >> Reference
    // New() >> Constructor
    // Base class >> Koi Parent
    // Interface >> 

    public class GenericConstrain<T> where T : struct // T > >Value any >> bool, int, double // Value Type
    {
        public T Value;

        public void Add(T data1, T data2)
        {
            /// You can do any operation
        }

    }

    public class GenericConstrainClass<T> where T : class // Reference type
    {
        public T Value;

        public void Add(T item)
        {
            // YESY EYSY YEYSYEYedfhsdfhdsh

        }

    }

    public class GenericConstrainConstructor<T> where T : new()
    {
        public T Value;

        public GenericConstrainConstructor()
        {
            //
        }

        public void Add(T item)
        {
            // YESY EYSY YEYSYEYedfhsdfhdsh

        }

    }

    public class BaseClass
    {




    }

    public class GenericConstrainBaseClass<T> where T : BaseClass
    {
        public T Value;

        public void Add(T item)
        {
            // YESY EYSY YEYSYEYedfhsdfhdsh

        }

    }

    public interface IInterface
    {
        void GetData();
    }

    public class ParentClass : IInterface
    {
        public void GetData()
        {
            throw new NotImplementedException();
        }
    }


    public class GenericConstrainInteface<T> where T : IInterface
    {
        public T Value;

        public void Add(T item)
        {
            // YESY EYSY YEYSYEYedfhsdfhdsh

        }

    }



}
