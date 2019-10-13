using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public class SqlCustomerData : ICustomerData
    {
        private readonly AgueroCRMDbContext db;

        public SqlCustomerData(AgueroCRMDbContext db)
        {
            this.db = db;
        }

        public void Add(Customer customer)
        {
            db.Customer.Add(customer);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = db.PotentialCustomer.Find(id);
            db.PotentialCustomer.Remove(customer);
            db.SaveChanges();
        }

        public Customer Get(int id)
        {
            return db.Customer.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return from r in db.Customer
                   orderby r.Id
                   select r;
        }

        public void Update(Customer customer)
        {
            var entry = db.Entry(customer);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
