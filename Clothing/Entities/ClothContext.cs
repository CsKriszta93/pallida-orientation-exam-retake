using Clothing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing.Entities
{
    public class ClothContext : DbContext
    {
        public ClothContext(DbContextOptions<ClothContext> options) : base(options)
        {

        }

        public DbSet<Clothes> warehouse {get; set;}
    }
}
