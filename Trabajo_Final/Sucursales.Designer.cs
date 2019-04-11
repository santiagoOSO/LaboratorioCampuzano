namespace Sucursales
{
    partial class Sucursales
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntregaResultadosSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntregaResultadosFinde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TomaMuestrasSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TomaMuestrasFinde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreSucursal,
            this.DireccionSucursal,
            this.TelefonoSucursal,
            this.EmailSucursal,
            this.EntregaResultadosSem,
            this.EntregaResultadosFinde,
            this.TomaMuestrasSem,
            this.TomaMuestrasFinde});
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(995, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 30);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // NombreSucursal
            // 
            this.NombreSucursal.HeaderText = "Sucursal";
            this.NombreSucursal.Name = "NombreSucursal";
            this.NombreSucursal.Width = 200;
            // 
            // DireccionSucursal
            // 
            this.DireccionSucursal.HeaderText = "Dirección";
            this.DireccionSucursal.Name = "DireccionSucursal";
            // 
            // TelefonoSucursal
            // 
            this.TelefonoSucursal.HeaderText = "Teléfono";
            this.TelefonoSucursal.Name = "TelefonoSucursal";
            // 
            // EmailSucursal
            // 
            this.EmailSucursal.HeaderText = "Email";
            this.EmailSucursal.Name = "EmailSucursal";
            // 
            // EntregaResultadosSem
            // 
            this.EntregaResultadosSem.HeaderText = "Entrega de resultados en semana";
            this.EntregaResultadosSem.Name = "EntregaResultadosSem";
            // 
            // EntregaResultadosFinde
            // 
            this.EntregaResultadosFinde.HeaderText = "Entrega de resultados fin de semana";
            this.EntregaResultadosFinde.Name = "EntregaResultadosFinde";
            // 
            // TomaMuestrasSem
            // 
            this.TomaMuestrasSem.HeaderText = "Toma de muestras en semana";
            this.TomaMuestrasSem.Name = "TomaMuestrasSem";
            // 
            // TomaMuestrasFinde
            // 
            this.TomaMuestrasFinde.HeaderText = "Toma de muestras fin de semana";
            this.TomaMuestrasFinde.Name = "TomaMuestrasFinde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 453);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntregaResultadosSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntregaResultadosFinde;
        private System.Windows.Forms.DataGridViewTextBoxColumn TomaMuestrasSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TomaMuestrasFinde;

    }
}

