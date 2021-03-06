﻿namespace Palitra27.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Palitra27.Data.Models;

    public class BrandsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Brands.Any())
            {
                return;
            }

            var brandDebeer = new Brand() { Name = "Debeer" };
            var brandHBBody = new Brand() { Name = "HBBody" };
            var brandNationalPaints = new Brand() { Name = "NationalPaints" };
            var brandPalitra = new Brand() { Name = "Palitra" };

            var allBrands = new List<Brand>() { brandDebeer, brandHBBody, brandNationalPaints, brandPalitra };

            await dbContext.AddRangeAsync(allBrands);
        }
    }
}
