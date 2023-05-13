namespace prjSp1MiPrimerApp
{
    partial class frmAlacena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.btnComida = new System.Windows.Forms.RadioButton();
            this.btnLimpieza = new System.Windows.Forms.RadioButton();
            this.btnMedicamento = new System.Windows.Forms.RadioButton();
            this.lstLugar = new System.Windows.Forms.ComboBox();
            this.lstNombre = new System.Windows.Forms.ComboBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadMinima = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadMinima = new System.Windows.Forms.Label();
            this.chkCaduca = new System.Windows.Forms.CheckBox();
            this.dtpCaducidad = new System.Windows.Forms.DateTimePicker();
            this.lblCalucidad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcTipodeProducto = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMinima)).BeginInit();
            this.mrcTipodeProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComida
            // 
            this.btnComida.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.Location = new System.Drawing.Point(15, 34);
            this.btnComida.Margin = new System.Windows.Forms.Padding(4);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(175, 55);
            this.btnComida.TabIndex = 0;
            this.btnComida.TabStop = true;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnLimpieza
            // 
            this.btnLimpieza.AutoSize = true;
            this.btnLimpieza.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpieza.Location = new System.Drawing.Point(197, 46);
            this.btnLimpieza.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpieza.Name = "btnLimpieza";
            this.btnLimpieza.Size = new System.Drawing.Size(138, 33);
            this.btnLimpieza.TabIndex = 1;
            this.btnLimpieza.TabStop = true;
            this.btnLimpieza.Text = "Limpieza";
            this.btnLimpieza.UseVisualStyleBackColor = true;
            // 
            // btnMedicamento
            // 
            this.btnMedicamento.AutoSize = true;
            this.btnMedicamento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamento.Location = new System.Drawing.Point(388, 46);
            this.btnMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicamento.Name = "btnMedicamento";
            this.btnMedicamento.Size = new System.Drawing.Size(192, 33);
            this.btnMedicamento.TabIndex = 2;
            this.btnMedicamento.TabStop = true;
            this.btnMedicamento.Text = "Medicamento";
            this.btnMedicamento.UseVisualStyleBackColor = true;
            // 
            // lstLugar
            // 
            this.lstLugar.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Items.AddRange(new object[] {
            "Alacena\t",
            "Freezer\t",
            "Heladera\t\t",
            "Cajon de Medicamentos \t",
            "Alacena Limpieza",
            "Lavadero"});
            this.lstLugar.Location = new System.Drawing.Point(245, 151);
            this.lstLugar.Margin = new System.Windows.Forms.Padding(4);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(159, 34);
            this.lstLugar.TabIndex = 4;
            // 
            // lstNombre
            // 
            this.lstNombre.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(245, 226);
            this.lstNombre.Margin = new System.Windows.Forms.Padding(4);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(159, 34);
            this.lstNombre.TabIndex = 5;
            this.lstNombre.Click += new System.EventHandler(this.lstNombre_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(16, 156);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(80, 29);
            this.lblLugar.TabIndex = 6;
            this.lblLugar.Text = "Lugar";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 231);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 29);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(245, 301);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(79, 34);
            this.nudCantidad.TabIndex = 8;
            // 
            // nudCantidadMinima
            // 
            this.nudCantidadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadMinima.Location = new System.Drawing.Point(245, 366);
            this.nudCantidadMinima.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidadMinima.Name = "nudCantidadMinima";
            this.nudCantidadMinima.Size = new System.Drawing.Size(79, 32);
            this.nudCantidadMinima.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(16, 306);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(118, 29);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCantidadMinima
            // 
            this.lblCantidadMinima.AutoSize = true;
            this.lblCantidadMinima.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMinima.Location = new System.Drawing.Point(16, 369);
            this.lblCantidadMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadMinima.Name = "lblCantidadMinima";
            this.lblCantidadMinima.Size = new System.Drawing.Size(210, 29);
            this.lblCantidadMinima.TabIndex = 11;
            this.lblCantidadMinima.Text = "Cantidad Minima";
            // 
            // chkCaduca
            // 
            this.chkCaduca.AutoSize = true;
            this.chkCaduca.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaduca.Location = new System.Drawing.Point(21, 446);
            this.chkCaduca.Margin = new System.Windows.Forms.Padding(4);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(123, 33);
            this.chkCaduca.TabIndex = 12;
            this.chkCaduca.Text = "Caduca";
            this.chkCaduca.UseVisualStyleBackColor = true;
            // 
            // dtpCaducidad
            // 
            this.dtpCaducidad.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCaducidad.Location = new System.Drawing.Point(240, 508);
            this.dtpCaducidad.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCaducidad.Name = "dtpCaducidad";
            this.dtpCaducidad.Size = new System.Drawing.Size(303, 29);
            this.dtpCaducidad.TabIndex = 13;
            // 
            // lblCalucidad
            // 
            this.lblCalucidad.AutoSize = true;
            this.lblCalucidad.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalucidad.Location = new System.Drawing.Point(7, 511);
            this.lblCalucidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalucidad.Name = "lblCalucidad";
            this.lblCalucidad.Size = new System.Drawing.Size(137, 29);
            this.lblCalucidad.TabIndex = 14;
            this.lblCalucidad.Text = "Caducidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(375, 578);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 43);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(180, 578);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 43);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mrcTipodeProducto
            // 
            this.mrcTipodeProducto.Controls.Add(this.btnMedicamento);
            this.mrcTipodeProducto.Controls.Add(this.btnLimpieza);
            this.mrcTipodeProducto.Controls.Add(this.btnComida);
            this.mrcTipodeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTipodeProducto.Location = new System.Drawing.Point(21, 15);
            this.mrcTipodeProducto.Margin = new System.Windows.Forms.Padding(4);
            this.mrcTipodeProducto.Name = "mrcTipodeProducto";
            this.mrcTipodeProducto.Padding = new System.Windows.Forms.Padding(4);
            this.mrcTipodeProducto.Size = new System.Drawing.Size(604, 100);
            this.mrcTipodeProducto.TabIndex = 17;
            this.mrcTipodeProducto.TabStop = false;
            this.mrcTipodeProducto.Text = "Tipo de Producto";
            // 
            // lstLista
            // 
            this.lstLista.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 25;
            this.lstLista.Location = new System.Drawing.Point(625, 122);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(459, 479);
            this.lstLista.TabIndex = 18;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 661);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.mrcTipodeProducto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCalucidad);
            this.Controls.Add(this.dtpCaducidad);
            this.Controls.Add(this.chkCaduca);
            this.Controls.Add(this.lblCantidadMinima);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCantidadMinima);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.lstLugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMinima)).EndInit();
            this.mrcTipodeProducto.ResumeLayout(false);
            this.mrcTipodeProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnComida;
        private System.Windows.Forms.RadioButton btnLimpieza;
        private System.Windows.Forms.RadioButton btnMedicamento;
        private System.Windows.Forms.ComboBox lstLugar;
        private System.Windows.Forms.ComboBox lstNombre;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidadMinima;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadMinima;
        private System.Windows.Forms.CheckBox chkCaduca;
        private System.Windows.Forms.DateTimePicker dtpCaducidad;
        private System.Windows.Forms.Label lblCalucidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox mrcTipodeProducto;
        private System.Windows.Forms.ListBox lstLista;
    }
}