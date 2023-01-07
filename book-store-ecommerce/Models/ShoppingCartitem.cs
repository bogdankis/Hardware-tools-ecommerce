﻿using System.ComponentModel.DataAnnotations;

namespace book_store_ecommerce.Models
{
    public class ShoppingCartitem
    {
        [Key]
        public int Id { get; set; }
        public Book Book { get; set; }

        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
