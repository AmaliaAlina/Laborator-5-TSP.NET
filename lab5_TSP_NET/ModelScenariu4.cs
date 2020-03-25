using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_TSP_NET
{
    class ModelScenariu4: DbContext
    {
        public virtual DbSet<Business> Businesses { get; set; }
    }
}
