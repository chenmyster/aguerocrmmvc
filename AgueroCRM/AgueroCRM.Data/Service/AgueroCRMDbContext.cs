using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public class AgueroCRMDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public DbSet<PotentialCustomer> PotentialCustomer { get; set; }

        public DbSet<CustomerContract> CustomerContract { get; set; }

        public DbSet<Application> Application { get; set; }

    }
}
