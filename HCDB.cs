using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HotCopper
{
    public class HCDB : DbContext
    {
        public DbSet<HCDB_Authors> Authors { get; set; }
        public DbSet<HCDB_Threads> Threads { get; set; }
        public DbSet<HCDB_MarketData> MarketData { get; set; }
        public DbSet<HCDB_Posts> Posts { get; set; }
    }
}
