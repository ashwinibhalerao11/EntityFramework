﻿using Microsoft.EntityFrameworkCore;
namespace EntityFramework.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
         public DbSet<Products> Products { get; set; }   
    }
}
