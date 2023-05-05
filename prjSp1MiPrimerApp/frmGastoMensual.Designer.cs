namespace prjSp1MiPrimerApp
{
    partial class frmGastoMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastoMensual));
            this.mrcFinanzas = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSaldoRestante = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.mrcGastos = new System.Windows.Forms.GroupBox();
            this.txtVarios = new System.Windows.Forms.TextBox();
            this.lblVarios = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtAlquier = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcIngresoMensual = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcFinanzas.SuspendLayout();
            this.mrcGastos.SuspendLayout();
            this.mrcIngresoMensual.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcFinanzas
            // 
            this.mrcFinanzas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcFinanzas.Controls.Add(this.lblResultado);
            this.mrcFinanzas.Controls.Add(this.lblSaldoRestante);
            this.mrcFinanzas.Controls.Add(this.cmdCancelar);
            this.mrcFinanzas.Controls.Add(this.cmdCalcular);
            this.mrcFinanzas.Controls.Add(this.mrcGastos);
            this.mrcFinanzas.Controls.Add(this.mrcIngresoMensual);
            this.mrcFinanzas.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcFinanzas.Location = new System.Drawing.Point(1, 1);
            this.mrcFinanzas.Name = "mrcFinanzas";
            this.mrcFinanzas.Size = new System.Drawing.Size(586, 526);
            this.mrcFinanzas.TabIndex = 1;
            this.mrcFinanzas.TabStop = false;
            this.mrcFinanzas.Text = "Finanzas";
            this.mrcFinanzas.Enter += new System.EventHandler(this.mrcFinanzas_Enter);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(267, 474);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(133, 29);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "________";
            // 
            // lblSaldoRestante
            // 
            this.lblSaldoRestante.AutoSize = true;
            this.lblSaldoRestante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaldoRestante.Location = new System.Drawing.Point(27, 474);
            this.lblSaldoRestante.Name = "lblSaldoRestante";
            this.lblSaldoRestante.Size = new System.Drawing.Size(214, 29);
            this.lblSaldoRestante.TabIndex = 5;
            this.lblSaldoRestante.Text = "Saldo Restante $";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancelar.Location = new System.Drawing.Point(77, 402);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(139, 39);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmdCalcular.Location = new System.Drawing.Point(272, 402);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(137, 39);
            this.cmdCalcular.TabIndex = 3;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = false;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // mrcGastos
            // 
            this.mrcGastos.Controls.Add(this.txtVarios);
            this.mrcGastos.Controls.Add(this.lblVarios);
            this.mrcGastos.Controls.Add(this.lblComida);
            this.mrcGastos.Controls.Add(this.txtComida);
            this.mrcGastos.Controls.Add(this.txtImpuestos);
            this.mrcGastos.Controls.Add(this.lblImpuestos);
            this.mrcGastos.Controls.Add(this.txtAlquier);
            this.mrcGastos.Controls.Add(this.lblAlquiler);
            this.mrcGastos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastos.Location = new System.Drawing.Point(53, 134);
            this.mrcGastos.Name = "mrcGastos";
            this.mrcGastos.Size = new System.Drawing.Size(356, 242);
            this.mrcGastos.TabIndex = 2;
            this.mrcGastos.TabStop = false;
            this.mrcGastos.Text = "Gastos";
            // 
            // txtVarios
            // 
            this.txtVarios.Location = new System.Drawing.Point(175, 206);
            this.txtVarios.Name = "txtVarios";
            this.txtVarios.Size = new System.Drawing.Size(122, 33);
            this.txtVarios.TabIndex = 6;
            // 
            // lblVarios
            // 
            this.lblVarios.AutoSize = true;
            this.lblVarios.Location = new System.Drawing.Point(21, 214);
            this.lblVarios.Name = "lblVarios";
            this.lblVarios.Size = new System.Drawing.Size(97, 25);
            this.lblVarios.TabIndex = 5;
            this.lblVarios.Text = "Varios $";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(21, 165);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(112, 25);
            this.lblComida.TabIndex = 3;
            this.lblComida.Text = "Comida $";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(175, 157);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(122, 33);
            this.txtComida.TabIndex = 4;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(175, 103);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(122, 33);
            this.txtImpuestos.TabIndex = 3;
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(21, 111);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(142, 25);
            this.lblImpuestos.TabIndex = 2;
            this.lblImpuestos.Text = "Impuestos $";
            // 
            // txtAlquier
            // 
            this.txtAlquier.Location = new System.Drawing.Point(175, 50);
            this.txtAlquier.Name = "txtAlquier";
            this.txtAlquier.Size = new System.Drawing.Size(122, 33);
            this.txtAlquier.TabIndex = 1;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(21, 58);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(112, 25);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler $";
            // 
            // mrcIngresoMensual
            // 
            this.mrcIngresoMensual.Controls.Add(this.txtDeposito);
            this.mrcIngresoMensual.Controls.Add(this.lblDeposito);
            this.mrcIngresoMensual.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresoMensual.Location = new System.Drawing.Point(53, 48);
            this.mrcIngresoMensual.Name = "mrcIngresoMensual";
            this.mrcIngresoMensual.Size = new System.Drawing.Size(356, 80);
            this.mrcIngresoMensual.TabIndex = 1;
            this.mrcIngresoMensual.TabStop = false;
            this.mrcIngresoMensual.Text = "Ingreso Mensual";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(175, 29);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(119, 33);
            this.txtDeposito.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(22, 34);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(114, 23);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito $";
            // 
            // frmGastoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 539);
            this.Controls.Add(this.mrcFinanzas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGastoMensual";
            this.Text = "Gasto Mensual";
            this.Load += new System.EventHandler(this.frmGastoMensual_Load);
            this.mrcFinanzas.ResumeLayout(false);
            this.mrcFinanzas.PerformLayout();
            this.mrcGastos.ResumeLayout(false);
            this.mrcGastos.PerformLayout();
            this.mrcIngresoMensual.ResumeLayout(false);
            this.mrcIngresoMensual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcFinanzas;
        private System.Windows.Forms.GroupBox mrcIngresoMensual;
        private System.Windows.Forms.GroupBox mrcGastos;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtAlquier;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSaldoRestante;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.TextBox txtVarios;
        private System.Windows.Forms.Label lblVarios;
    }
}

