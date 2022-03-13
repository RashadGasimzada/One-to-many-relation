using LessonMigration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<FlowerExpertProfile> FlowerExpertProfiles { get; set; }
        public DbSet<FlowerExpertsTitle> FlowerExpertsTitles { get; set; }
        public DbSet<BlogTitle> BlogTitles { get; set; }
        public DbSet<BlogProfile> BlogProfiles { get; set; }
        public DbSet<IGAccount> IGAccounts { get; set; }



    }
}
