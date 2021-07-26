using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreWebApiDockerApp.Api.Models
{
    [Table("books", Schema = "librarydb")]
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Column("id")]
        public string Id { get; internal set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("author")]
        public string Author { get; set; }
    }
}
