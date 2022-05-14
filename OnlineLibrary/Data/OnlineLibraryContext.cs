using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineLibrary.Models;

namespace OnlineLibrary.Data
{
    public class OnlineLibraryContext : DbContext
    {
        public OnlineLibraryContext (DbContextOptions<OnlineLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineLibrary.Models.Book>? Book { get; set; }
    }
}
