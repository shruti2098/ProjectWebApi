using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SurfaceDevlopment.Authentication;
using SurfaceDevlopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<PropertyInformation> propertyInformation { get; set; }
        //public DbSet<CountryPagingList> CountryPagingLists { get; set; }
    //public DbSet<Type> Types { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
