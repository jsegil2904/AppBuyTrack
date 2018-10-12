namespace App.UUI.Windows
{
    partial class FrmFindCustomer
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnElegirCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(21, 85);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(317, 158);
            this.dgvCustomers.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarCustomer);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtBuscarCustomer
            // 
            this.txtBuscarCustomer.Location = new System.Drawing.Point(97, 25);
            this.txtBuscarCustomer.Name = "txtBuscarCustomer";
            this.txtBuscarCustomer.Size = new System.Drawing.Size(201, 20);
            this.txtBuscarCustomer.TabIndex = 1;
            this.txtBuscarCustomer.TextChanged += new System.EventHandler(this.txtBuscarCustomer_TextChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(6, 28);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(85, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Name:";
            // 
            // btnElegirCustomer
            // 
            this.btnElegirCustomer.Location = new System.Drawing.Point(21, 259);
            this.btnElegirCustomer.Name = "btnElegirCustomer";
            this.btnElegirCustomer.Size = new System.Drawing.Size(139, 23);
            this.btnElegirCustomer.TabIndex = 7;
            this.btnElegirCustomer.Text = "Elegir";
            this.btnElegirCustomer.UseVisualStyleBackColor = true;
            this.btnElegirCustomer.Click += new System.EventHandler(this.btnElegirCustomer_Click);
            // 
            // FrmFindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 304);
            this.Controls.Add(this.btnElegirCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFindCustomer";
            this.Text = "Find Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnElegirCustomer;
    }
}