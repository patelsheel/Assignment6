using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        [MaxLength(50)]
        [DisplayName("Product")]
        public string? ProductName { get; set; }
        [DisplayName("Price")]
        public float ProductPrice { get; set; }
    }
}

