using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;
using Owin;

namespace MyHostedOwinRestServices
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BooksController : ApiController
    {
        Book[] Books = new Book[]
            {
                new Book
                {
                    Id = 1,
                    Title = "Pride and Prejudice",
                    Year = 1813,
                    Price = 9.99M,
                    Genre = "Comedy of manners"
                },
                new Book
                {
                    Id = 2,
                    Title = "Northanger Abbey",
                    Year = 1817,
                    Price = 12.95M,
                    Genre = "Gothic parody"
                },
                new Book()
                {
                    Id = 3,
                    Title = "David Copperfield",
                    Year = 1850,
                    Price = 15,
                    Genre = "Bildungsroman"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Don Quixote",
                    Year = 1617,
                    Price = 8.95M,
                    Genre = "Picaresque"
                }
            };

        // GET: api/Books               
        public IEnumerable<Book> GetBooks()
        {
            return Books;
        }

        // GET: api/Books/5        
        public Book GetBook(int id)
        {
            try
            {
                return Books[id];
            }
            catch (Exception ex)
            {
                return new Book();
            }
        }

    }
}