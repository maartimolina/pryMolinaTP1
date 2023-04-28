namespace prjSp1MiPrimerApp
{
    partial class frmMenu
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
            this.btnAlacena = new System.Windows.Forms.Button();
            this.btnGastoMensual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlacena
            // 
            this.btnAlacena.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlacena.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlacena.Location = new System.Drawing.Point(74, 203);
            this.btnAlacena.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlacena.Name = "btnAlacena";
            this.btnAlacena.Size = new System.Drawing.Size(303, 102);
            this.btnAlacena.TabIndex = 3;
            this.btnAlacena.Text = "Alacena";
            this.btnAlacena.UseVisualStyleBackColor = false;
            this.btnAlacena.Click += new System.EventHandler(this.btnAlacena_Click);
            // 
            // btnGastoMensual
            // 
            this.btnGastoMensual.BackColor = System.Drawing.SystemColors.Control;
            this.btnGastoMensual.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastoMensual.Location = new System.Drawing.Point(74, 53);
            this.btnGastoMensual.Margin = new System.Windows.Forms.Padding(2);
            this.btnGastoMensual.Name = "btnGastoMensual";
            this.btnGastoMensual.Size = new System.Drawing.Size(303, 101);
            this.btnGastoMensual.TabIndex = 2;
            this.btnGastoMensual.Text = "Gasto Mensual";
            this.btnGastoMensual.UseVisualStyleBackColor = false;
            this.btnGastoMensual.Click += new System.EventHandler(this.btnGastoMensual_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 366);
            this.Controls.Add(this.btnAlacena);
            this.Controls.Add(this.btnGastoMensual);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlacena;
        private System.Windows.Forms.Button btnGastoMensual;
    }
}