using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace G_NET_65_EF001.Entities
{
    public class Book
    {
        public int Id { get; set; } // Primary Key
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearPublished { get; set; }
        public bool IsInStock { get; set; }


        public int CategoryId { get; set; } 
        public Category Category { get; set; } = null!;

        
        public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
    }
}