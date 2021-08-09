using System;
using System.ComponentModel.DataAnnotations;
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

        public Book(Guid id)
        {
            Id = id.ToString();
        }

        [Required]
        [Column("id")]
        public string Id { get; internal set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("price")]
        public decimal Price { get; set; }

        [Required]
        [Column("author")]
        public string Author { get; set; }

        [Required]
        [Column("sequence")]
        public int Sequence { get; set; }
    }
}
