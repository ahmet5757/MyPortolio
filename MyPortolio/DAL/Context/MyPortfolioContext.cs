﻿using Microsoft.EntityFrameworkCore;
using MyPortolio.DAL.Entities;

namespace MyPortolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2L523TB\\SQLEXPRESS;initial Catalog=MyPortfolioDb;integrated Security=true;TrustServerCertificate=true");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<skill> Skills { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }


    }
}
