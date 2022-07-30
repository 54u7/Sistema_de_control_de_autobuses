namespace CapaPresentacion
{
    partial class Disponibles
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
            this.dgvChoferDispo = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnVincular = new System.Windows.Forms.Button();
            this.dgvRutasDispo = new System.Windows.Forms.DataGridView();
            this.dgvAutobusesDispo = new System.Windows.Forms.DataGridView();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobusesDispo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChoferDispo
            // 
            this.dgvChoferDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChoferDispo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChoferDispo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChoferDispo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChoferDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferDispo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChoferDispo.Location = new System.Drawing.Point(12, 12);
            this.dgvChoferDispo.Name = "dgvChoferDispo";
            this.dgvChoferDispo.RowHeadersVisible = false;
            this.dgvChoferDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoferDispo.Size = new System.Drawing.Size(542, 277);
            this.dgvChoferDispo.TabIndex = 1;
            this.dgvChoferDispo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvChoferDispo_MouseClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 361);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(352, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(854, 537);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(160, 53);
            this.btnVincular.TabIndex = 7;
            this.btnVincular.Text = "Vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // dgvRutasDispo
            // 
            this.dgvRutasDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutasDispo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRutasDispo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRutasDispo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRutasDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutasDispo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRutasDispo.Location = new System.Drawing.Point(1147, 12);
            this.dgvRutasDispo.Name = "dgvRutasDispo";
            this.dgvRutasDispo.RowHeadersVisible = false;
            this.dgvRutasDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutasDispo.Size = new System.Drawing.Size(542, 277);
            this.dgvRutasDispo.TabIndex = 8;
            this.dgvRutasDispo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvRutasDispo_MouseClick);
            // 
            // dgvAutobusesDispo
            // 
            this.dgvAutobusesDispo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutobusesDispo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAutobusesDispo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutobusesDispo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAutobusesDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutobusesDispo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAutobusesDispo.Location = new System.Drawing.Point(579, 12);
            this.dgvAutobusesDispo.Name = "dgvAutobusesDispo";
            this.dgvAutobusesDispo.RowHeadersVisible = false;
            this.dgvAutobusesDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutobusesDispo.Size = new System.Drawing.Size(542, 277);
            this.dgvAutobusesDispo.TabIndex = 9;
            this.dgvAutobusesDispo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAutobusesDispo_MouseClick);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(688, 361);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(433, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(1337, 361);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(352, 20);
            this.txtRuta.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(688, 537);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 53);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(688, 414);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(433, 20);
            this.txtPlaca.TabIndex = 22;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(202, 414);
            this.txtCedula.MaxLength = 13;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(352, 20);
            this.txtCedula.TabIndex = 23;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(89, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(621, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(89, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(618, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1273, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ruta";
            // 
            // Disponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1700, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.dgvAutobusesDispo);
            this.Controls.Add(this.dgvRutasDispo);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvChoferDispo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Disponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobusesDispo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChoferDispo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.DataGridView dgvRutasDispo;
        private System.Windows.Forms.DataGridView dgvAutobusesDispo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCedula;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}