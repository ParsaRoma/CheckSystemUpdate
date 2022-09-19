using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>, IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        private readonly string MyDb1 = "Data Source=DESKTOP-E1O540S;Initial Catalog=SystemCheck_DB; Integrated Security = True";
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options) : base(options)
        {

        }
       
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(MyDb1);
            return new ApplicationDbContext(optionsBuilder.Options);
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(MyDb1);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }


    }
}