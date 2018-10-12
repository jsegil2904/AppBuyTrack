using App.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
    public class UnitOfWork: IUnitOfWork
    {

        private readonly DbContext _context;

        public ICustomerRepository CustomerRepository { get; private set; }

        public IInvoiceRepository InvoiceRepository { get; private set; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            CustomerRepository = new CustomerRepository(_context);
            InvoiceRepository = new InvoiceRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
