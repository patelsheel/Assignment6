﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDatabase.Entities
{
    [Table("Products")]
    public class Product
    {
        public int ProductID { get; set; }
        [MaxLength(50)]
        public string? ProductName { get; set; }
        public float ProductPrice { get; set; }
    }
}

