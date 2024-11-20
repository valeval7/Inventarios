using Inventarios_VMG;
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
//using Manejador;

namespace Presentacion_TallerAutomotiz
{
    public partial class FrmMenu : Form
    {
        //FrmLogin LOG;
        string Formulario = "";
        Form Activo = null;

        public FrmMenu()
        {
            InitializeComponent();
            groupBox1.Visible = true;
            /*LOG = new FrmLogin();
            Formulario = ManejadorLogin.Formulario;*/

        }


        private void CerrarFormulario()
        {
            if (Activo != null)
            {
               Activo.Close();
            }
        }

        public void btnHerramientas_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
            groupBox1.Visible = false;
            /*FrmHerramientas b = new FrmHerramientas();
            if (Formulario.Equals("Herramientas") || Formulario.Equals("Refacciones y Herramientas") || Formulario.Equals("Administrador"))
            {
                b.Show();
                Activo = b;
            }

            else
            {
                MessageBox.Show("ERROR. Usted solo está ASIGNADO a los formularios: \n" + Formulario);
                this.Show();
            }*/
           
        }



        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
            groupBox1.Visible = false;
            /*FrmUsuarios c = new FrmUsuarios();
            if (Formulario.Equals("Administrador"))
            {
                c.Show();
                Activo = c;
                
            }
            else
            {
                MessageBox.Show("ERROR. Usted solo está ASIGNADO a los formularios: \n" + Formulario);
                this.Show();
            }*/
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEspacios_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
            groupBox1.Visible = false;

           
                FrmEspacios E = new FrmEspacios();
                E.Show();
                Activo = E;

        }
    }
}
