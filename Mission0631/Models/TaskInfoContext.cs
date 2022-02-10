using Microsoft.EntityFrameworkCore;
using Mission0631.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This page provides seeding for the database tables
namespace Mission0631.Models
{
    public class TaskInfoContext : DbContext
    {
        //Constructor
        public TaskInfoContext(DbContextOptions<TaskInfoContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<EnterTaskSubmission> Tasks { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(

                    new Category { CategoryID = 1, CategoryName = "Home" },
                    new Category { CategoryID = 2, CategoryName = "School" },
                    new Category { CategoryID = 3, CategoryName = "Work" },
                    new Category { CategoryID = 4, CategoryName = "Church" }
                );

            //    mb.Entity<EnterTaskSubmission>().HasData(

            //        new EnterTaskSubmission
            //        {
            //            TaskID = 1,
            //            CategoryID = 2,
            //            Task = "Complete assignment",
            //            DueDate = "2022-1-1",
            //            Quadrant = "",
            //            Category = "School",
            //            Completed = false
            //        },

            //        new EnterTaskSubmission
            //        {
            //            TaskID = 2,
            //            CategoryID = 1,
            //            Task = "Go grocery shopping",
            //            DueDate = "2002",
            //            Quadrant = "",
            //            Category = "Home",
            //            Completed = false
            //        },
            //        new EnterTaskSubmission
            //        {
            //            TaskID = 3,
            //            CategoryID = 3,
            //            Task = "Set up conference with manager",
            //            DueDate = "2002",
            //            Quadrant = "",
            //            Category = "Work",
            //            Completed = false
        }
        //);
        //}
    }
}
