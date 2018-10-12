using App.DataAccess.Interfaces;
using App.Entities.Base;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using App.Entities.Queries;

namespace App.DataAccess.Repository
{
    public class CustomerRepository:
        GenericRepository<Customer>,ICustomerRepository
    {
        public CustomerRepository(DbContext context):base(context)
        {
        }

        public IEnumerable<Customer> GetListByName(string filtrobyname)
        {
            return ((AppModelDB)context).Customer.AsEnumerable()
                    .Where(item => item.FirstName.Contains(filtrobyname)
                                    || item.LastName.Contains(filtrobyname))
                                    .ToList();
        }


    }
}
