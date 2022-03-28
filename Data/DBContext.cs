#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_review_2022.Model;

    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Razor_review_2022.Model.School> School { get; set; }

        public DbSet<Razor_review_2022.Model.Student> Student { get; set; }
    }
