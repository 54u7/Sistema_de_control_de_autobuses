namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDisponibles = new System.Windows.Forms.Button();
            this.btnOcupados = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnAutobus = new System.Windows.Forms.Button();
            this.btnChoferes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisponibles
            // 
            this.btnDisponibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisponibles.Location = new System.Drawing.Point(250, 186);
            this.btnDisponibles.Name = "btnDisponibles";
            this.btnDisponibles.Size = new System.Drawing.Size(131, 33);
            this.btnDisponibles.TabIndex = 0;
            this.btnDisponibles.Text = "Ver disponibles";
            this.btnDisponibles.UseVisualStyleBackColor = true;
            this.btnDisponibles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOcupados
            // 
            this.btnOcupados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOcupados.Location = new System.Drawing.Point(60, 251);
            this.btnOcupados.Name = "btnOcupados";
            this.btnOcupados.Size = new System.Drawing.Size(131, 33);
            this.btnOcupados.TabIndex = 1;
            this.btnOcupados.Text = "Ver ocupados";
            this.btnOcupados.UseVisualStyleBackColor = true;
            this.btnOcupados.Click += new System.EventHandler(this.btnOcupados_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRuta.Location = new System.Drawing.Point(250, 126);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(131, 33);
            this.btnRuta.TabIndex = 2;
            this.btnRuta.Text = "Agregar ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAutobus
            // 
            this.btnAutobus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAutobus.Location = new System.Drawing.Point(60, 186);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Size = new System.Drawing.Size(131, 33);
            this.btnAutobus.TabIndex = 3;
            this.btnAutobus.Text = "Agregar autobus";
            this.btnAutobus.UseVisualStyleBackColor = true;
            this.btnAutobus.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnChoferes
            // 
            this.btnChoferes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChoferes.Location = new System.Drawing.Point(60, 126);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Size = new System.Drawing.Size(131, 33);
            this.btnChoferes.TabIndex = 4;
            this.btnChoferes.Text = "Agregar chofer";
            this.btnChoferes.UseVisualStyleBackColor = true;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(250, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema de control de autobuses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(440, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnChoferes);
            this.Controls.Add(this.btnAutobus);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnOcupados);
            this.Controls.Add(this.btnDisponibles);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisponibles;
        private System.Windows.Forms.Button btnOcupados;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnAutobus;
        private System.Windows.Forms.Button btnChoferes;
        private System.Windows.Forms.Button btnSalir;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
    }
}

