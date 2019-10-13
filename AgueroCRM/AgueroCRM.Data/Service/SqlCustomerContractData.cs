using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public class SqlCustomerContractData : ICustomerContractData
    {
        private readonly AgueroCRMDbContext db;

        public SqlCustomerContractData(AgueroCRMDbContext db)
        {
            this.db = db;
        }

        public void Add(CustomerContract customerContract)
        {
            db.CustomerContract.Add(customerContract);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var customerContract = db.CustomerContract.Find(id);
            db.CustomerContract.Remove(customerContract);
            db.SaveChanges();
        }

        public CustomerContract Get(int id)
        {
            return db.CustomerContract.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<CustomerContract> GetAll()
        {
            return from r in db.CustomerContract
                   orderby r.Id
                   select r;
        }

        public void Update(CustomerContract customerContract)
        {
            var entry = db.Entry(customerContract);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
