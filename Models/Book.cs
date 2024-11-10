using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Telcean_Lorena_Alexia_LAB2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? AuthorID { get; set; } // Foreign key
        public Author? Author { get; set; } // Navigation property
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
    }  
}