namespace App.UUI.Windows
{
    partial class FrmFindTrack
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
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarTrack = new System.Windows.Forms.TextBox();
            this.lblTrack = new System.Windows.Forms.Label();
            this.btnElegirTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTracks
            // 
            this.dgvTracks.AllowUserToDeleteRows = false;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Location = new System.Drawing.Point(12, 85);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.ReadOnly = true;
            this.dgvTracks.Size = new System.Drawing.Size(317, 158);
            this.dgvTracks.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarTrack);
            this.groupBox1.Controls.Add(this.lblTrack);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtBuscarTrack
            // 
            this.txtBuscarTrack.Location = new System.Drawing.Point(97, 25);
            this.txtBuscarTrack.Name = "txtBuscarTrack";
            this.txtBuscarTrack.Size = new System.Drawing.Size(199, 20);
            this.txtBuscarTrack.TabIndex = 1;
            this.txtBuscarTrack.TextChanged += new System.EventHandler(this.txtBuscarTrack_TextChanged);
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(6, 28);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(69, 13);
            this.lblTrack.TabIndex = 0;
            this.lblTrack.Text = "Track Name:";
            // 
            // btnElegirTrack
            // 
            this.btnElegirTrack.Location = new System.Drawing.Point(12, 252);
            this.btnElegirTrack.Name = "btnElegirTrack";
            this.btnElegirTrack.Size = new System.Drawing.Size(114, 23);
            this.btnElegirTrack.TabIndex = 2;
            this.btnElegirTrack.Text = "Elegir";
            this.btnElegirTrack.UseVisualStyleBackColor = true;
            this.btnElegirTrack.Click += new System.EventHandler(this.btnElegirTrack_Click);
            // 
            // FrmFindTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.btnElegirTrack);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFindTrack";
            this.Text = "Find Track";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnElegirTrack;
        private System.Windows.Forms.TextBox txtBuscarTrack;
        private System.Windows.Forms.Label lblTrack;
    }
}