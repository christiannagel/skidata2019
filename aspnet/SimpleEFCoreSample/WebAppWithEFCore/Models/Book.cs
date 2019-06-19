using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SimpleEFCoreSample
{
    // [Table("MyBooks")]
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(50), Required()]
        public string Title { get; set; }
        
        public string Publisher { get; set; }
    }
}
