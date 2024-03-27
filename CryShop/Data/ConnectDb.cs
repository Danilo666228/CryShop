using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryShop.Data
{
    public class ConnectDb : DbContext
    {
        public ConnectDb() : base("DbConnectionString")
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
