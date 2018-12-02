using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineEclub.Models;

namespace OnlineEclub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OnlineEclub.Models.Content> Content { get; set; }
        public DbSet<OnlineEclub.Models.Category> Category { get; set; }
        public DbSet<OnlineEclub.Models.Group> Group { get; set; }
    }
}
