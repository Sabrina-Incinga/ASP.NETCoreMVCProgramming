﻿using Cupcakes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cupcakes.Data
{
    public class CupcakeContext : DbContext
    {
        public CupcakeContext(DbContextOptions<CupcakeContext> options) : base(options)
        {
        }

        public DbSet<Bakery> Bakeries { get; set; }
        public DbSet<Cupcake> Cupcakes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Bakery> bakeryBuilder =  modelBuilder.Entity<Bakery>();

            bakeryBuilder.HasData(new Bakery() {BakeryId=1,BakeryName= "Gluteus Free", Address= "635 Brighton Circle Road", Quantity=8 }, new Bakery() { BakeryId = 2, BakeryName = "Cupcakes Break", Address = "4323 Jerome Avenue", Quantity = 22 }, new Bakery() { BakeryId = 3, BakeryName = "Cupcakes Ahead", Address = "2553 Pin Oak Drive", Quantity = 18 }, new Bakery() { BakeryId = 4, BakeryName = "Sugar", Address = "1608 Charles Street", Quantity = 30 });

            EntityTypeBuilder<Cupcake> cupcakeBuilder = modelBuilder.Entity<Cupcake>();

            cupcakeBuilder.HasData(new Cupcake() {CupcakeId=1,CupcakeType=CupcakeType.Birthday,Description= "Vanilla cupcake with coconut cream", GlutenFree=true, Price=2.5,BakeryId=1,ImageMimeType="image/jpeg",ImageName= "birthday-cupcake.jpg", CaloricValue=355 }, 
                new Cupcake() { CupcakeId = 2, CupcakeType = CupcakeType.Chocolate, Description = "VChocolate cupcake with caramel filling and chocolate butter cream", GlutenFree = false, Price = 3.2, BakeryId = 2, ImageMimeType = "image/jpeg", ImageName = "chocolate-cupcake.jpg", CaloricValue=195 }, 
                new Cupcake() { CupcakeId = 3, CupcakeType = CupcakeType.Strawberry, Description = "Chocolate cupcake with straberry cream filling", GlutenFree = false, Price = 4, BakeryId = 3, ImageMimeType = "image/jpeg", ImageName = "pink-cupcake.jpg", CaloricValue=295 },
                new Cupcake() { CupcakeId = 4, CupcakeType = CupcakeType.Turquoise, Description = "Vanilla cupcake with butter cream", GlutenFree = true, Price = 1.5, BakeryId = 4, ImageMimeType = "image/jpeg", ImageName = "turquoise-cupcake.jpg", CaloricValue=360 });

        }
    }
}
