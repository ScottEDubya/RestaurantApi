﻿using Microsoft.EntityFrameworkCore;
using RestaurantApi.Models;

namespace RestaurantApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.Migrate(); //will make db if not exist
        }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        //dining room
        //menus
        //orders
        //employees
        //customers
    }
}