using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace  WebApi.Entities{
    public class Author {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId {get; set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Book> Books { get; set; }
        public DateTime Birthday { get; set; }
    }
}