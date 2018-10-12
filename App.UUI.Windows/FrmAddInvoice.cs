using App.DataAccess.Interfaces;
using App.DataAccess.Repository;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UUI.Windows
{
    public partial class FrmAddInvoice : Form
    {
        float unitPriceF = 0;
        int i = 0;
        int TrackIdF = 0;
        int customerIdFinal=0;
        double sum = 0;
        private readonly DbContext dbContext;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IUnitOfWork unitOfWork;

        public FrmAddInvoice()
        {
            InitializeComponent();

            dbContext = new AppModelDB();
            invoiceRepository = new InvoiceRepository(dbContext);

            unitOfWork = new UnitOfWork(dbContext);

            dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoice.MultiSelect = false;
            dgvInvoice.ColumnCount = 5;
            dgvInvoice.Columns[0].Name = "TrackId";
            dgvInvoice.Columns[1].Name = "Name";
            dgvInvoice.Columns[2].Name = "Price";
            dgvInvoice.Columns[3].Name = "Quantity";
            dgvInvoice.Columns[4].Name = "Total";
            lblTotalTracks.Text = "0.00";

        }

        private void btnBuscarCustomerFactura_Click(object sender, EventArgs e)
        {

            DevuelveCustomer();
            
        }
        private void DevuelveCustomer()
        {
            FrmFindCustomer frmCustomer = new FrmFindCustomer();
            frmCustomer.pasado += new FrmFindCustomer.pasarToFormInvoice(FrmCustomer_pasado);
            frmCustomer.Show();
        }

        private void FrmCustomer_pasado(int customerId, string customerName, string customerAddress, string customerCity
            , string customerState, string customerCountry, string customerPostalCode)
        {
            txtCustomerFactura.Text = customerName;
            txtAddress.Text = customerAddress;
            txtCity.Text = customerCity;
            txtCountry.Text = customerCountry;
            txtState.Text = customerState;
            txtPostal.Text = customerPostalCode;
            customerIdFinal = customerId;
        }

        private void FrmAddInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            DevuelveTrack();
        }

        private void DevuelveTrack()
        {
            FrmFindTrack frmTrack = new FrmFindTrack();
            frmTrack.pasadoT += new FrmFindTrack.pasarToFormInvoiceT(FrmTrack_pasado);
            frmTrack.Show();
        }

        private void FrmTrack_pasado(int trackId, string trackName, float unitPrice)
        {
            txtTrackName.Text = trackName;
            txtTrackPrice.Text = unitPrice.ToString();
            unitPriceF = unitPrice;
            TrackIdF = trackId;

        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            
            int QuantityF = Convert.ToInt32(Math.Round(nudQuantity.Value, 0));
            dgvInvoice.Rows.Add();
            dgvInvoice.Rows[i].Cells[0].Value = TrackIdF;
            dgvInvoice.Rows[i].Cells[1].Value = txtTrackName.Text;
            dgvInvoice.Rows[i].Cells[2].Value = unitPriceF;
            dgvInvoice.Rows[i].Cells[3].Value = QuantityF;
            dgvInvoice.Rows[i].Cells[4].Value = (unitPriceF * QuantityF).ToString();
            i = i + 1;
            sum = 0;
            for (int j= 0; j < dgvInvoice.Rows.Count; ++j)
            {
                sum += Convert.ToDouble(dgvInvoice.Rows[j].Cells[4].Value);
            }

            lblTotalTracks.Text = sum.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            var invoice = new Invoice();
            invoice.CustomerId = customerIdFinal;
            invoice.InvoiceDate = Convert.ToDateTime(dtDateFactura.Value.ToString());
            invoice.BillingAddress = txtAddress.Text;
            invoice.BillingCity = txtCity.Text;
            invoice.BillingState = txtState.Text;
            invoice.BillingCountry = txtCountry.Text;
            invoice.BillingPostalCode = txtPostal.Text;
            invoice.Total = Convert.ToDecimal(sum);

            invoice.InvoiceLine = new List<InvoiceLine>();

            for (int x = 0; x < i; ++x)
            {
                invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = Convert.ToInt32(dgvInvoice.Rows[x].Cells[0].Value),
                    UnitPrice = Convert.ToDecimal(dgvInvoice.Rows[x].Cells[2].Value),
                    Quantity = Convert.ToInt32(dgvInvoice.Rows[x].Cells[3].Value)
                });

            }

            unitOfWork.InvoiceRepository.Add(invoice);
            unitOfWork.Complete();
            unitOfWork.Dispose();


            ClearFactura();

            MessageBox.Show("Invoice Saved Success!!");

        }

        private void ClearFactura()
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

            }

            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

            }
            nudQuantity.Value = 0;
            txtCustomerFactura.Text = "";

        }

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.Rows.Count > 1)
                {
                    int rowIndex = dgvInvoice.CurrentRow.Index;
                    dgvInvoice.Rows.RemoveAt(rowIndex);
                    i = i - 1;
                }
                else
                {
                    MessageBox.Show("Please add Tracks!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select track to remove!");
            }

            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
