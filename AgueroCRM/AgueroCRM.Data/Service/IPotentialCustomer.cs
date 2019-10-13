using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public interface IPotentialCustomer
    {
        IEnumerable<PotentialCustomer> GetAll();
        PotentialCustomer Get(int id);
        void Add(PotentialCustomer potentialCustomer);
        void Update(PotentialCustomer potentialCustomer);
        void Delete(int id);
    }
}
