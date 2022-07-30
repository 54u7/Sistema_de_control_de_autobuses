namespace CapaPresentacion
{
    partial class Ocupados
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
            this.dgvOcupados = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcupados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOcupados
            // 
            this.dgvOcupados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOcupados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOcupados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOcupados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOcupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcupados.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOcupados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOcupados.Location = new System.Drawing.Point(0, 0);
            this.dgvOcupados.Name = "dgvOcupados";
            this.dgvOcupados.RowHeadersVisible = false;
            this.dgvOcupados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOcupados.Size = new System.Drawing.Size(548, 214);
            this.dgvOcupados.TabIndex = 19;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(202, 286);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(146, 46);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Ocupados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(548, 405);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvOcupados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ocupados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PresentacionOcupados";
            this.Load += new System.EventHandler(this.Ocupados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcupados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOcupados;
        private System.Windows.Forms.Button btnAceptar;
    }
}