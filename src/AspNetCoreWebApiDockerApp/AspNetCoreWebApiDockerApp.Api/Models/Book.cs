using System;

namespace AspNetCoreWebApiDockerApp.Api.Models
{
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
