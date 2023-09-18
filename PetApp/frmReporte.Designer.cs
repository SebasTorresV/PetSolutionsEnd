namespace PetApp
{
    partial class frmReporte
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
            this.components = new System.ComponentModel.Container();
            this.gpbReporte = new System.Windows.Forms.GroupBox();
            this.Data = new System.Windows.Forms.DataGridView();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.petAppMascota = new PetApp.PetAppMascota();
            this.mascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotaTableAdapter = new PetApp.PetAppMascotaTableAdapters.MascotaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbReporte
            // 
            this.gpbReporte.Controls.Add(this.button1);
            this.gpbReporte.Controls.Add(this.cmbReporte);
            this.gpbReporte.Controls.Add(this.Data);
            this.gpbReporte.Location = new System.Drawing.Point(13, 13);
            this.gpbReporte.Name = "gpbReporte";
            this.gpbReporte.Size = new System.Drawing.Size(496, 345);
            this.gpbReporte.TabIndex = 0;
            this.gpbReporte.TabStop = false;
            this.gpbReporte.Text = "Reporte";
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.Data.Location = new System.Drawing.Point(0, 59);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(490, 273);
            this.Data.TabIndex = 0;
            // 
            // cmbReporte
            // 
            this.cmbReporte.DataSource = this.mascotaBindingSource;
            this.cmbReporte.DisplayMember = "Alias";
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Location = new System.Drawing.Point(0, 19);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(241, 21);
            this.cmbReporte.TabIndex = 1;
            this.cmbReporte.ValueMember = "Alias";
            // 
            // petAppMascota
            // 
            this.petAppMascota.DataSetName = "PetAppMascota";
            this.petAppMascota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mascotaBindingSource
            // 
            this.mascotaBindingSource.DataMember = "Mascota";
            this.mascotaBindingSource.DataSource = this.petAppMascota;
            // 
            // mascotaTableAdapter
            // 
            this.mascotaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar reporte de la mascota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 363);
            this.Controls.Add(this.gpbReporte);
            this.Name = "frmReporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.gpbReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petAppMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReporte;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.ComboBox cmbReporte;
        private PetAppMascota petAppMascota;
        private System.Windows.Forms.BindingSource mascotaBindingSource;
        private PetAppMascotaTableAdapters.MascotaTableAdapter mascotaTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}