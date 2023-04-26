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
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGastoMensual VentanaGastoMensual = frmGastoMensual();
            VentanaGastoMensual.ShowDialog();
        }

        private frmGastoMensual frmGastoMensual()
        {
            throw new NotImplementedException();
        }

        private void btnAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena VentanaAlacena = frmAlacena();
              VentanaAlacena.ShowDialog();

        }

        private frmAlacena frmAlacena()
        {
            throw new NotImplementedException();
        }
    }
}
