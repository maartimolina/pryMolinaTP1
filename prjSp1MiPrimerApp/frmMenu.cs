using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSp1MiPrimerApp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnGastoMensual_Click(object sender, EventArgs e)
        {
            // CREAR "VARIABLE" TIPO FORMULARIO
            frmGastoMensual gasto = new frmGastoMensual();

            //MOSTRAR NUEVO FORMULARIO
            gasto.ShowDialog();
        }

        private void btnAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena Alacena= new frmAlacena();   
            Alacena.ShowDialog();   
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
