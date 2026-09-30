using System;
using System.Collections.Generic;

namespace G_NET_65_EF001.Entities
{
    public class Author
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}