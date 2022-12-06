using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProductType> productTypes { get; set; }
        public DbSet<specialTag> specialTags { get; set; }
        public DbSet<Products> products { get; set; }
    }
}
