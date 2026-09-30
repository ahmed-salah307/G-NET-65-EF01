using System.Collections.Generic;

namespace G_NET_65_EF001.Entities
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
        public bool IsActive { get; set; }
         
        
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}