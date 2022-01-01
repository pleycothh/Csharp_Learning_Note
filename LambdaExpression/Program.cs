

using System.Collections.Generic;
//Func<int, int> sq = Squre;
/*
int factor = 5; 
Func<int,int> multiplire = n => n * factor;
Console.WriteLine(multiplire(5));
Console.ReadLine();
*/

// second example:

namespace LambdaExpression
{
    public class Book
    {
        public int Price { get; set; }
        public string Title { get; set; }
    }

    public class BookRepository: Book
    {

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "asd", Price = 1 },
                new Book() {Title = "asd", Price = 2 },
                new Book() {Title = "asd", Price = 3 }
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapbooks = books.FindAll(book => book.Price > 1);
            // findall function, loop through each element in List, check true or fules and return if ture

            Console.WriteLine(cheapbooks.Count);
            //books.FindAll;
        }
    }
}