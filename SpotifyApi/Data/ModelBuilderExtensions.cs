using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = (int)Categories.Rock, Name = "Rock" },
                new Category() { Id = (int)Categories.Pop, Name = "Pop" },
                new Category() { Id = (int)Categories.HipHop, Name = "Hip Hop" },
                new Category() { Id = (int)Categories.Jazz, Name = "Jazz" },
                new Category() { Id = (int)Categories.Classical, Name = "Classical" },
                new Category() { Id = (int)Categories.Electronic, Name = "Electronic" },
                new Category() { Id = (int)Categories.Country, Name = "Country" },
                new Category() { Id = (int)Categories.Folk, Name = "Folk" },
                new Category() { Id = (int)Categories.RnB, Name = "RnB" },
                new Category() { Id = (int)Categories.Metal, Name = "Metal" },
                new Category() { Id = (int)Categories.Blues, Name = "Blues" },
                new Category() { Id = (int)Categories.Other, Name = "Other" }
            });
        }
    }
}
