using System.Collections.Generic;
using System.Net;
using LuukAPICase.Models;
using Microsoft.EntityFrameworkCore;

namespace LuukAPICase.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> configuration) : base(configuration)
        {

        }
    }
}
