using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public interface ICustomerContract
    {
        IEnumerable<CustomerContract> GetAll();
        CustomerContract Get(int id);
        void Add(CustomerContract customerContract);
        void Update(CustomerContract customerContract);
        void Delete(int id);
    }
}
