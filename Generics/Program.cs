using System;
using System.Collections.Generic;

namespace Generics
{

    // for the most time, using .Net defult generic lists: Syste.Collections.Generic. = list of defult class


    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float Calculate(TProduct product)
        {
            return product.Price;
        }
    }

    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    // where T : Icomparable --> 
    // where T : Product --> if t is product or any children of Product
    // where T : struct --> if T is value type
    // where T : class --> if T is reference type
    // where T : new() --> if T is object that has defulat constructor

    public class Utilities<T> where T : IComparable, new() // add defult constructor : for create an nullable object
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b; // if A is bigger than B, return A, otherwhise return B
        }

        // need to implement compare method interface in order to compare T object
        public T Max(T a, T b) 
        {
            a.CompareTo(b);
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {


        //    var books = new GenericList<BookList>();
        //    var numbers = new GenericList<int>();
        //    var lists = new GenericList<List>();
        //
        //    
        //    books.Add(new BookList());
        //    numbers.Add(10);
        //    lists.Add(new List());

        }
    }
    public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }



    }


    public class BookList
    {
        public void Add(BookList book)
        {
            throw new NotImplementedException();
        }
    }


    public class GenericList<T>
    {
        public void Add(T vlaue)
        {

        }
    }
}