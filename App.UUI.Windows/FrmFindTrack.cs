using App.DataAccess.Interfaces;
using App.DataAccess.Repository;
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
    public partial class FrmFindTrack : Form
    {
        //Delegar
        public delegate void pasarToFormInvoiceT( int trackId, string trackName, float unitPrice);
        public event pasarToFormInvoiceT pasadoT;

        private readonly DbContext dbContext;
        private readonly ITrackRepository trackRepository;
        private readonly IUnitOfWork unitOfWork;
        public FrmFindTrack()
        {
            InitializeComponent();
            dbContext = new AppModelDB();
            trackRepository = new TrackRepository(dbContext);
            unitOfWork = new UnitOfWork(dbContext);
            txtBuscarTrack.Focus();
            dgvTracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTracks.MultiSelect = false;
        }

        private void btnElegirTrack_Click(object sender, EventArgs e)
        {
            ElegirTrack();
        }

        private void ElegirTrack()
        {
            if (dgvTracks.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgvTracks.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTracks.Rows[selectedrowindex];
                int trackId = Convert.ToInt32(selectedRow.Cells[0].Value);
                string trackName = Convert.ToString(selectedRow.Cells[1].Value);
                float trackUnitPrice = Convert.ToSingle(selectedRow.Cells[2].Value);

                pasadoT(trackId, trackName, trackUnitPrice);
                this.Dispose();
            }
        }

        private void txtBuscarTrack_TextChanged(object sender, EventArgs e)
        {
            ConsultarNameTrack();
        }

        private void ConsultarNameTrack()
        {
            dgvTracks.DataSource = null;
            var filtroname = txtBuscarTrack.Text;
            var listado = trackRepository.GetTracksByName(filtroname);
            
            var listadofinal = listado.Select(item => new
            {
                item.TrackId,
                item.Name,
                item.UnitPrice,
                item.Milliseconds,
                item.Bytes
            }).ToList();
            dgvTracks.DataSource = listadofinal;
            dgvTracks.Refresh();
        }
    }
}
