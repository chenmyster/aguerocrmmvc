using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public class SqlPotentialCustomerData : IPotentialCustomerData
    {
        private readonly AgueroCRMDbContext db;

        public SqlPotentialCustomerData(AgueroCRMDbContext db)
        {
            this.db = db;
        }

        public void Add(PotentialCustomer potentialCustomer)
        {
            db.PotentialCustomer.Add(potentialCustomer);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var potentialCustomer = db.PotentialCustomer.Find(id);
            db.PotentialCustomer.Remove(potentialCustomer);
            db.SaveChanges();
        }

        public PotentialCustomer Get(int id)
        {
            return db.PotentialCustomer.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<PotentialCustomer> GetAll()
        {
            return from r in db.PotentialCustomer
                   orderby r.Id
                   select r;
        }

        public void Update(PotentialCustomer potentialCustomer)
        {
            var entry = db.Entry(potentialCustomer);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
