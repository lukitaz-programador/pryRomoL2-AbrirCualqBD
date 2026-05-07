namespace pryRomoL2_AbrirCualqBD
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.btnAbrirBD = new System.Windows.Forms.Button();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblTablas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirBD
            // 
            this.btnAbrirBD.Location = new System.Drawing.Point(10, 10);
            this.btnAbrirBD.Name = "btnAbrirBD";
            this.btnAbrirBD.Size = new System.Drawing.Size(129, 30);
            this.btnAbrirBD.TabIndex = 0;
            this.btnAbrirBD.Text = "Abrir Base de Datos";
            this.btnAbrirBD.UseVisualStyleBackColor = true;
            this.btnAbrirBD.Click += new System.EventHandler(this.btnAbrirBD_Click);
            // 
            // cmbTablas
            // 
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(197, 15);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(172, 21);
            this.cmbTablas.TabIndex = 2;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(10, 52);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(651, 329);
            this.dgvDatos.TabIndex = 3;
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.Location = new System.Drawing.Point(154, 17);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(42, 13);
            this.lblTablas.TabIndex = 1;
            this.lblTablas.Text = "Tablas:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(386, 17);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Sin conexión...";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 400);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.btnAbrirBD);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de Base de Datos Access";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirBD;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.Label lblEstado;
    }
}