using App.DataAccess.Interfaces;
using App.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Entities.Base;
using System.Data.Entity;

namespace App.UUI.Windows
{
    public partial class FrmFindCustomer : Form
    {
        //Delegar
        public delegate void pasarToFormInvoice(int customerId, string customerName, string Address, string City,
            string State, string Country, string PostalCode);
        public event pasarToFormInvoice pasado;

        private readonly DbContext dbContext;
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;


        public FrmFindCustomer()
        {
            InitializeComponent();
            dbContext = new AppModelDB();
            customerRepository = new CustomerRepository(dbContext);
            unitOfWork = new UnitOfWork(dbContext);
            txtBuscarCustomer.Focus();
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.MultiSelect = false;
        }


        //private void btnBuscarCustomer_Click(object sender, EventArgs e)
        //{

        //    ConsultarNameCustomer();
        //}

        private void txtBuscarCustomer_TextChanged(object sender, EventArgs e)
        {
            ConsultarNameCustomer();
        }
        private void ConsultarNameCustomer()
            {
            dgvCustomers.DataSource = null;
            var filtroname = txtBuscarCustomer.Text;
            var listado = customerRepository.GetListByName(filtroname);
            var listadofinal = listado.Select(item => new
            {
                item.CustomerId,
                item.FirstName,
                item.LastName,
                item.Address,
                item.City,
                item.State,
                item.Country,
                item.PostalCode
            }).ToList();
            dgvCustomers.DataSource = listadofinal;
            dgvCustomers.Refresh();
        }

        private void btnElegirCustomer_Click(object sender, EventArgs e)
        {
            ElegirCustomer();

        }

        private void ElegirCustomer()
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgvCustomers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCustomers.Rows[selectedrowindex];
                int customerId = Convert.ToInt32(selectedRow.Cells[0].Value);
                string customerFirstName = Convert.ToString(selectedRow.Cells[1].Value);
                string customerLastName = Convert.ToString(selectedRow.Cells[2].Value);
                string customerAddress = Convert.ToString(selectedRow.Cells[3].Value);
                string customerCity = Convert.ToString(selectedRow.Cells[4].Value);
                string customerState = Convert.ToString(selectedRow.Cells[5].Value);
                string customerCountry = Convert.ToString(selectedRow.Cells[6].Value);
                string customerPostalCode = Convert.ToString(selectedRow.Cells[7].Value);
                pasado(customerId, customerFirstName + " " + customerLastName, customerAddress, customerCity
                    , customerState, customerCountry, customerPostalCode);
                this.Dispose();
            }

        }
    }
}
