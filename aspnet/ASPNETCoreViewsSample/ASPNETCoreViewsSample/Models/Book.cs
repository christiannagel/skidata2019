﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreViewsSample.Models
{
    public class Book
    {
        
        public int BookId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
        public string Publisher { get; set; }

        [Display()]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
