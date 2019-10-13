using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public class SqlApplicationData : IApplicationData
    {
        private readonly AgueroCRMDbContext db;

        public SqlApplicationData(AgueroCRMDbContext db)
        {
            this.db = db;
        }

        public void Add(Application application)
        {
            db.Application.Add(application);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var application = db.Application.Find(id);
            db.Application.Remove(application);
            db.SaveChanges();
        }

        public Application Get(int id)
        {
            return db.Application.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Application> GetAll()
        {
            return from r in db.Application
                   orderby r.Id
                   select r;
        }

        public void Update(Application application)
        {
            var entry = db.Entry(application);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
