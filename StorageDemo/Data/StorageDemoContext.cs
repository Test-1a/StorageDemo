using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StorageDemo.Models
{
    public class StorageDemoContext : DbContext
    {
        public StorageDemoContext (DbContextOptions<StorageDemoContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
