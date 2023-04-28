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
    public partial class frmGastoMensual : Form
    {     //zona declaracion variables globales al formulario
        decimal varDeposito;
        decimal varAlquiler;
        decimal varImpuestos;
        decimal varComida;
        decimal varVarios;
        decimal varSaldoRestante;
        public frmGastoMensual()
        {
            InitializeComponent();
        }

        private void frmGastoMensual_Load(object sender, EventArgs e)
        {
            varDeposito = 0;
            varAlquiler = 0;
            varImpuestos = 0;
            varComida = 0;
            varVarios = 0;
            varSaldoRestante = 0;
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varAlquiler = Convert.ToDecimal(txtAlquier.Text);
            varImpuestos = Convert.ToDecimal(txtImpuestos.Text);
            varComida= Convert.ToDecimal(txtComida.Text);
            varVarios= Convert.ToDecimal(txtVarios.Text);
            varSaldoRestante = varDeposito -(varAlquiler + varImpuestos + varComida + varVarios);
            lblResultado.Text= varSaldoRestante.ToString();

            //concatenar - unir texto
            
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtDeposito.Text= string.Empty;
            txtAlquier.Text = string.Empty;
            txtImpuestos.Text = string.Empty;
            txtComida.Text = string.Empty;
            txtVarios.Text = string.Empty;
            lblResultado.Text= string.Empty;
        }
    }
}
