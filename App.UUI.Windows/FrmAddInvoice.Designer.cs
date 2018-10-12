namespace App.UUI.Windows
{
    partial class FrmAddInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddInvoice));
            this.label2 = new System.Windows.Forms.Label();
            this.dtDateFactura = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCustomerFactura = new System.Windows.Forms.Button();
            this.txtCustomerFactura = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTrackPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTrackName = new System.Windows.Forms.TextBox();
            this.btnTrack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalTracks = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date:";
            // 
            // dtDateFactura
            // 
            this.dtDateFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFactura.Location = new System.Drawing.Point(107, 65);
            this.dtDateFactura.Name = "dtDateFactura";
            this.dtDateFactura.Size = new System.Drawing.Size(100, 20);
            this.dtDateFactura.TabIndex = 8;
            this.dtDateFactura.Value = new System.DateTime(2018, 10, 10, 18, 9, 56, 0);
            // 
            // btnBuscarCustomerFactura
            // 
            this.btnBuscarCustomerFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCustomerFactura.Image")));
            this.btnBuscarCustomerFactura.Location = new System.Drawing.Point(347, 14);
            this.btnBuscarCustomerFactura.Name = "btnBuscarCustomerFactura";
            this.btnBuscarCustomerFactura.Size = new System.Drawing.Size(43, 31);
            this.btnBuscarCustomerFactura.TabIndex = 7;
            this.btnBuscarCustomerFactura.UseVisualStyleBackColor = true;
            this.btnBuscarCustomerFactura.Click += new System.EventHandler(this.btnBuscarCustomerFactura_Click);
            // 
            // txtCustomerFactura
            // 
            this.txtCustomerFactura.Location = new System.Drawing.Point(107, 25);
            this.txtCustomerFactura.Name = "txtCustomerFactura";
            this.txtCustomerFactura.ReadOnly = true;
            this.txtCustomerFactura.Size = new System.Drawing.Size(150, 20);
            this.txtCustomerFactura.TabIndex = 6;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(48, 28);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Customer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtPostal);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 122);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(257, 52);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(257, 26);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(89, 79);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.ReadOnly = true;
            this.txtPostal.Size = new System.Drawing.Size(100, 20);
            this.txtPostal.TabIndex = 7;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(56, 52);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(137, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(73, 26);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(133, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Postal Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "State:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveTrack);
            this.groupBox2.Controls.Add(this.btnAddTrack);
            this.groupBox2.Controls.Add(this.nudQuantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTrackPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTrackName);
            this.groupBox2.Controls.Add(this.btnTrack);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(51, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 142);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Track";
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Location = new System.Drawing.Point(56, 113);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(115, 23);
            this.btnAddTrack.TabIndex = 19;
            this.btnAddTrack.Text = "Add";
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(289, 65);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(58, 20);
            this.nudQuantity.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quantity:";
            // 
            // txtTrackPrice
            // 
            this.txtTrackPrice.Location = new System.Drawing.Point(101, 64);
            this.txtTrackPrice.Name = "txtTrackPrice";
            this.txtTrackPrice.ReadOnly = true;
            this.txtTrackPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTrackPrice.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Price:";
            // 
            // txtTrackName
            // 
            this.txtTrackName.Location = new System.Drawing.Point(101, 21);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.ReadOnly = true;
            this.txtTrackName.Size = new System.Drawing.Size(150, 20);
            this.txtTrackName.TabIndex = 15;
            // 
            // btnTrack
            // 
            this.btnTrack.Image = ((System.Drawing.Image)(resources.GetObject("btnTrack.Image")));
            this.btnTrack.Location = new System.Drawing.Point(282, 10);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(43, 31);
            this.btnTrack.TabIndex = 15;
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Track:";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(51, 405);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(371, 178);
            this.dgvInvoice.TabIndex = 12;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Location = new System.Drawing.Point(51, 600);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInvoice.TabIndex = 13;
            this.btnSaveInvoice.Text = "Save";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total:";
            // 
            // lblTotalTracks
            // 
            this.lblTotalTracks.AutoSize = true;
            this.lblTotalTracks.Location = new System.Drawing.Point(367, 600);
            this.lblTotalTracks.Name = "lblTotalTracks";
            this.lblTotalTracks.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTracks.TabIndex = 15;
            this.lblTotalTracks.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "$";
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.Location = new System.Drawing.Point(208, 113);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(115, 23);
            this.btnRemoveTrack.TabIndex = 20;
            this.btnRemoveTrack.Text = "Remove";
            this.btnRemoveTrack.UseVisualStyleBackColor = true;
            this.btnRemoveTrack.Click += new System.EventHandler(this.btnRemoveTrack_Click);
            // 
            // FrmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 635);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalTracks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDateFactura);
            this.Controls.Add(this.btnBuscarCustomerFactura);
            this.Controls.Add(this.txtCustomerFactura);
            this.Controls.Add(this.lblCustomer);
            this.Name = "FrmAddInvoice";
            this.Text = "Agregar Factura";
            this.Load += new System.EventHandler(this.FrmAddInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDateFactura;
        private System.Windows.Forms.Button btnBuscarCustomerFactura;
        private System.Windows.Forms.TextBox txtCustomerFactura;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTrackPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.Label lblTotalTracks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemoveTrack;
    }
}