using CasaRobot.UI.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaRobot.UI
{
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
            cmbTipoUsuario.Items.Add("Cliente");
            cmbTipoUsuario.Items.Add("Empleado");
            cmbTipoUsuario.SelectedIndex = -1;
            cmbTipoUsuario.ItemHeight = 20;
            cmbTipoUsuario.MaxDropDownItems = 2;
            cmbTipoUsuario.SelectedIndexChanged += cmbTipoUsuario_SelectedIndexChanged;
          

        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoUsuario.SelectedItem.ToString();

            if (tipo == "Cliente")
            {
                FrmCrearCliente frmCliente = new FrmCrearCliente();
                CargarFormularioEnPanel(frmCliente);
            }
            else if (tipo == "Empleado")
            {
                FrmCrearEmpleado frmEmpleado = new FrmCrearEmpleado();
                CargarFormularioEnPanel(frmEmpleado);
            }
        }
            private void CargarFormularioEnPanel(Form formulario)
            {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Limpiar y mostrar el nuevo formulario
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }
   
    
    }
}
