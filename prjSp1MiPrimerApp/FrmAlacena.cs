using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSp1MiPrimerApp
{
    public partial class frmAlacena : Form
    { //declaracion de variables globlales  

        string varLugar , varNombre; 
        int varCantidad, varCantidadMinima;
        DateTime varCaducidad;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            varLugar = lstLugar.Text;   
            varNombre = lstNombre.Text;
            //varCantidad= int.Parse(nudCntidad.Value);
            varCantidad= Convert.ToInt32(nudCantidad.Value);  
            varCantidadMinima=Convert.ToInt32(nudCantidadMinima.Value);
        
            varCaducidad = dtpCaducidad.Value;

            lstLista.Items.Add(varLugar + varNombre +   varCantidad +   varCantidadMinima +   varCaducidad);
            
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lstLugar.Text= string.Empty;
            lstNombre.Text = string.Empty;
            nudCantidad.Text = string.Empty;
            nudCantidadMinima.Text = string.Empty;
            chkCaduca.Text = string.Empty;
            dtpCaducidad.Text = string.Empty;
            lstLista.Items.Clear();
            btnComida.Text = string.Empty;
            btnLimpieza.Text = string.Empty;
            btnMedicamento.Text = string.Empty;


        }

        private void lstNombre_Click(object sender, EventArgs e)
        {
            lstNombre.Items.Clear();
            if (btnComida.Checked)
            {
                lstNombre.Items.Add("Dulce de Leche");
                lstNombre.Items.Add("Mermelada");
                lstNombre.Items.Add("Soda");
                lstNombre.Items.Add("Queso Rallado");
                lstNombre.Items.Add("Chocolate en Polvo");
                lstNombre.Items.Add("Azucar");
                lstNombre.Items.Add("Fideos");
                lstNombre.Items.Add("Café");
                lstNombre.Items.Add("Té");
                lstNombre.Items.Add("Arroz");
                lstNombre.Items.Add("Milanesas");
                lstNombre.Items.Add("Gaseosa");
                lstNombre.Items.Add("Leche");
                lstNombre.Items.Add("Aceite de Girasol");
                lstNombre.Items.Add("Aceite de Oliva");
                lstNombre.Items.Add("Vinagre");
                lstNombre.Items.Add("Avena");
                lstNombre.Items.Add("Cereales");
            }
            else
            {
                if (btnLimpieza.Checked)
                {
                    lstNombre.Items.Add("Lavandina");
                    lstNombre.Items.Add("Perfumina");
                    lstNombre.Items.Add("Jabon");
                    lstNombre.Items.Add("Detergente");
                    lstNombre.Items.Add("Pasta de Dientes");
                    lstNombre.Items.Add("Shampoo");
                    lstNombre.Items.Add("Acondicionador");

                }
                else
                {
                    if (btnMedicamento.Checked)
                    {
                        lstNombre.Items.Add("Ibuprofeno");
                        lstNombre.Items.Add("Novalgina");
                        lstNombre.Items.Add("Paracetamol");
                        lstNombre.Items.Add("Vendas");
                        lstNombre.Items.Add("Curitas");



                    }




                }


            }    
            

        }
        
        public frmAlacena()
        {
            InitializeComponent();
        }

     

        private void frmAlacena_Load(object sender, EventArgs e)
        {
            lstNombre.Items.Add("Azucar");
            lstNombre.Items.Add("Tè");
            lstNombre.Items.Add("Cafè");
            lstNombre.Items.Add("Fideos");
            lstNombre.Items.Add("Arroz");
            lstNombre.Items.Add("Milanesas");
            lstNombre.Items.Add("Gaseosa");
            lstNombre.Items.Add("Leche");
            lstNombre.Items.Add("Lavandina");
            lstNombre.Items.Add("Perfumina");
            lstNombre.Items.Add("Jabon");
            lstNombre.Items.Add("Detergente");
            lstNombre.Items.Add("Pasta de Dientes");
            lstNombre.Items.Add("Shampoo");
            lstNombre.Items.Add("Acondicionador");
            lstNombre.Items.Add("Dulce de Leche");
            lstNombre.Items.Add("Mermelada");
            lstNombre.Items.Add("Soda");
            lstNombre.Items.Add("Queso Rallado");
            lstNombre.Items.Add("Chocolate en Polvo");
            lstNombre.Items.Add("Sal");
            lstNombre.Items.Add("Aceite de Girasol");
            lstNombre.Items.Add("Aceite de Oliva");
            lstNombre.Items.Add("Vinagre");
            lstNombre.Items.Add("Avena");
            lstNombre.Items.Add("Cereales");
            lstNombre.Items.Add("Ibuprofeno");
            lstNombre.Items.Add("Novalgina");
            lstNombre.Items.Add("Paracetamol");
            lstNombre.Items.Add("Vendas");
            lstNombre.Items.Add("Curitas");











        }
    }
}
