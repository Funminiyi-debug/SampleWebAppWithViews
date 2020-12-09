using Microsoft.EntityFrameworkCore;
using SampleWebAppWithViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebAppWithViews.DTOs.Book;

namespace SampleWebAppWithViews.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
