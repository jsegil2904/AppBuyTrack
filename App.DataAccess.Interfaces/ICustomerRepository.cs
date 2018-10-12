using App.Entities.Base;
using App.Entities.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Interfaces
{
    public interface ICustomerRepository: IGenericRepository<Customer>
    {
        IEnumerable<Customer> GetListByName(string name);
    }
}
