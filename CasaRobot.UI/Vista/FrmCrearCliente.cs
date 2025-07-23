using CasaRobot.UI.Modelo.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaRobot.UI.Vista
{
    public partial class FrmCrearCliente : Form

    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:5001/api/Clientes";

        public FrmCrearCliente()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.MidnightBlue;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.MidnightBlue;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.MidnightBlue;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.Gray;
            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var nuevoCliente = new ClientesDTO
            {
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Direccion = txtDireccion.Text.Trim()
            };

            try
            {
                var respuesta = await _httpClient.PostAsJsonAsync(BaseUrl, nuevoCliente);
                if (respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    string errorMsg = await respuesta.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear cliente: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == "Nombre")
            {
                MessageBox.Show("Ingrese el nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || txtCorreo.Text == "Correo")
            {
                MessageBox.Show("Ingrese el correo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text == "Teléfono")
            {
                MessageBox.Show("Ingrese el teléfono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text) || txtDireccion.Text == "Dirección")
            {
                MessageBox.Show("Ingrese la dirección.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "Nombre";
            txtCorreo.Text = "Correo";
            txtTelefono.Text = "Teléfono";
            txtDireccion.Text = "Dirección";

            txtNombre.ForeColor = Color.Gray;
            txtCorreo.ForeColor = Color.Gray;
            txtTelefono.ForeColor = Color.Gray;
            txtDireccion.ForeColor = Color.Gray;
        }
    }

}
    