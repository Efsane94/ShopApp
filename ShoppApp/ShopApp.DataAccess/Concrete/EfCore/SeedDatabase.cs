using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category { Name="Telefon"},
            new Category { Name="Bilgisayar"},
            new Category { Name="Elektronik"}
        };

        private static Product[] Products =
        {
            new Product{ Name="Samsung S5", Price=2000, ImageUrl="1.jpg", Description="<p>Gozel Telefon</p>"},
            new Product{ Name="Samsung S6", Price=2500, ImageUrl="2.jpg", Description="<p>Gozel Telefon</p>"},
            new Product{ Name="Iphone 6", Price=4000, ImageUrl="3.jpg", Description="<p>Gozel Telefon</p>"},
            new Product{ Name="Samsung S7", Price=2700, ImageUrl="4.jpg", Description="<p>Gozel Telefon</p>"},
            new Product{ Name="Iphone 7", Price=3700, ImageUrl="5.jpg", Description="<p>Gozel Telefon</p>"},
            new Product{ Name="Samsung S8", Price=3400, ImageUrl="6.jpg", Description="<p>Gozel Telefon</p>"},
            new Product{ Name="Iphone XS", Price=5000, ImageUrl="7.jpg", Description="<p>Gozel Telefon</p>"},
            new Product{ Name="Iphone 8", Price=3650, ImageUrl="8.jpg", Description="<p>Gozel Telefon</p>"}
        };

        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory{Product= Products[0], Category=Categories[0]},
            new ProductCategory{Product= Products[0], Category=Categories[2]},
            new ProductCategory{Product= Products[1], Category=Categories[0]},
            new ProductCategory{Product= Products[1], Category=Categories[1]},
            new ProductCategory{Product= Products[2], Category=Categories[0]},
            new ProductCategory{Product= Products[2], Category=Categories[2]},
            new ProductCategory{Product= Products[3], Category=Categories[1]},
        };
    }
}
