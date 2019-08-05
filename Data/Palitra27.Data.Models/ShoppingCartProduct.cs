﻿namespace Palitra27.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ShoppingCartProduct
    {
        public string ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
