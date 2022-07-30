namespace CapaPresentacion
{
    partial class Rutas
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarRutas = new System.Windows.Forms.Button();
            this.dgvAgregarRutas = new System.Windows.Forms.DataGridView();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(65, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 45);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarRutas
            // 
            this.btnAgregarRutas.Location = new System.Drawing.Point(259, 360);
            this.btnAgregarRutas.Name = "btnAgregarRutas";
            this.btnAgregarRutas.Size = new System.Drawing.Size(128, 45);
            this.btnAgregarRutas.TabIndex = 14;
            this.btnAgregarRutas.Text = "Agregar";
            this.btnAgregarRutas.UseVisualStyleBackColor = true;
            this.btnAgregarRutas.Click += new System.EventHandler(this.btnAgregarRutas_Click);
            // 
            // dgvAgregarRutas
            // 
            this.dgvAgregarRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgregarRutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAgregarRutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgregarRutas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAgregarRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarRutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAgregarRutas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAgregarRutas.Location = new System.Drawing.Point(0, 0);
            this.dgvAgregarRutas.Name = "dgvAgregarRutas";
            this.dgvAgregarRutas.RowHeadersVisible = false;
            this.dgvAgregarRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregarRutas.Size = new System.Drawing.Size(484, 214);
            this.dgvAgregarRutas.TabIndex = 18;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRuta.Location = new System.Drawing.Point(62, 241);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(42, 16);
            this.lblRuta.TabIndex = 20;
            this.lblRuta.Text = "Rutas";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(130, 241);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(257, 20);
            this.txtRuta.TabIndex = 19;
            // 
            // Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.dgvAgregarRutas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.Rutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarRutas;
        private System.Windows.Forms.DataGridView dgvAgregarRutas;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
    }
}