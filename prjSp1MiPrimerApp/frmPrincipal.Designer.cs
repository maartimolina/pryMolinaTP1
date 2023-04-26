namespace prjSp1MiPrimerApp
{
    partial class fmrPrincipal
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
            this.btnGastoMensual = new System.Windows.Forms.Button();
            this.btnAlacena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGastoMensual
            // 
            this.btnGastoMensual.BackColor = System.Drawing.SystemColors.Control;
            this.btnGastoMensual.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastoMensual.Location = new System.Drawing.Point(86, 79);
            this.btnGastoMensual.Name = "btnGastoMensual";
            this.btnGastoMensual.Size = new System.Drawing.Size(404, 124);
            this.btnGastoMensual.TabIndex = 0;
            this.btnGastoMensual.Text = "Gasto Mensual";
            this.btnGastoMensual.UseVisualStyleBackColor = false;
            this.btnGastoMensual.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlacena
            // 
            this.btnAlacena.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlacena.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlacena.Location = new System.Drawing.Point(86, 263);
            this.btnAlacena.Name = "btnAlacena";
            this.btnAlacena.Size = new System.Drawing.Size(404, 125);
            this.btnAlacena.TabIndex = 1;
            this.btnAlacena.Text = "Alacena";
            this.btnAlacena.UseVisualStyleBackColor = false;
            this.btnAlacena.Click += new System.EventHandler(this.btnAlacena_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btnAlacena);
            this.Controls.Add(this.btnGastoMensual);
            this.Name = "fmrPrincipal";
            this.Text = "Pincipal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGastoMensual;
        private System.Windows.Forms.Button btnAlacena;
    }
}