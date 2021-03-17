using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EncryptWebSyte.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {}


        // public DbSet<CryptList> CryptLists { get; set;}
        public DbSet<Encrypt> Encrypts { get; set; }
        public DbSet<Descrypt> Descrypts { get; set; }
        
    }
}
