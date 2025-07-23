using Microsoft.VisualBasic.Devices;
using CasaRobot.UI.Controlador;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CasaRobot.UI.Modelo.DTOs;


namespace CasaRobot.UI
{
    public partial class FrmIniciaSesion : Form
    {
        private readonly APIClientesCasaRobot _apiClientesCasaRobot;
        private const string BaseUrl = "https://localhost:5001/api/Empleados";
        public FrmIniciaSesion()
        {
            InitializeComponent();
            _apiClientesCasaRobot = new APIClientesCasaRobot(BaseUrl);
            this.Load += FrmIniciaSesion_Load;
        }
   


        private void FrmIniciaSesion_Load(object? sender, EventArgs e)
        {
           
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void textIngresarUsuario_Enter(object sender, EventArgs e)
        {
            if (txtIngresarUsuario.Text == "Usuario")
            {
                txtIngresarUsuario.Text = "";
                txtIngresarUsuario.ForeColor = Color.Black;
            }
        }

        private void textIngresarUsuario_Leave(object sender, EventArgs e)
        {
            if (txtIngresarUsuario.Text == "")
            {
                txtIngresarUsuario.Text = "Usuario";
                txtIngresarUsuario.ForeColor = Color.Silver;
            }
        }

       

        private async void btnIngresar_Click(object sender, EventArgs e) 
        { 
        
            try
                {
                // Validar que no estén vacíos los campos
                if (string.IsNullOrWhiteSpace(txtIngresarUsuario.Text) || txtIngresarUsuario.Text == "Usuario" ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text) || txtContraseña.Text == "Contraseña")
                {
                    MessageBox.Show("Por favor, ingresa usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto con credenciales
                var loginData = new
                {
                    NombreUsuario = txtIngresarUsuario.Text.Trim(),
                    Clave = txtContraseña.Text.Trim()
                };

                // Llamar a la API, asumiendo que PostAsync devuelve bool
                bool resultado = await _apiClientesCasaRobot.PostAsync<bool>("Login", loginData);

                if (resultado)
                {
                    MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aquí iría la lógica para continuar a la siguiente ventana
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                catch (Exception ex)
                 {
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
