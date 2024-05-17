using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab33.Models
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}