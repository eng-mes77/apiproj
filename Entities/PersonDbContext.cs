using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Configuration;

namespace Entities
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions options) :
        base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
        public DbSet<Person> Persons { get; set; }
    }
}
