using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_core_entity_02.Models;

namespace MVC_core_entity_02.Models
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext (DbContextOptions<TaskDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_core_entity_02.Models.Task> Task { get; set; }

        public DbSet<MVC_core_entity_02.Models.category> Category { get; set; }

        //FLUENT API RELATIONSHIP GO RIGHT HERE
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //RELATIONSHIPS
            //CATEGORY NAME REQUIRED
            builder.Entity<category>().Property(c => c.CategoryName).IsRequired().HasMaxLength(15);

            //Every task has 1 category
            builder.Entity<category>().HasMany(c => c.Tasks).WithOne(task => task.Category);

            builder.Entity<Models.Task>().HasOne(task => task.Category).WithMany(category => category.Tasks);
        }
    }
}
