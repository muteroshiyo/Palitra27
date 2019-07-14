﻿namespace Palitra27.Data.Models
{
    using System.Collections.Generic;

    using Palitra27.Data.Common.Models;

    public class Product : BaseDeletableModel<string>
    {
        public string BrandId { get; set; }

        public ProductBrand Brand { get; set; }

        public string Name { get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public string MiniDescription { get; set; } = "This product has no Description";

        public string Description { get; set; } = "This product has no Description";

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Depth { get; set; }

        public decimal Weight { get; set; }
    }
}
