using AgueroCRM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgueroCRM.Data.Service
{
    public interface IApplicationData
    {
        IEnumerable<Application> GetAll();
        Application Get(int id);
        void Add(Application application);
        void Update(Application application);
        void Delete(int id);
    }
}
