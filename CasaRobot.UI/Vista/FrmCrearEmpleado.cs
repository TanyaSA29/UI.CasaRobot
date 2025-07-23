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
    public partial class FrmCrearEmpleado : Form

    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:5001/api/Empleados";

        public FrmCrearEmpleado()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

        }

        private void panelCrearUsuario_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtCargo_Enter(object sender, EventArgs e)
        {
            if (txtCargo.Text == "Cargo")
            {
                txtCargo.Text = "";
                txtCargo.ForeColor = Color.MidnightBlue;
            }
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                txtCargo.Text = "Cargo";
                txtCargo.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Teléfono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.MidnightBlue;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "Teléfono";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "Nombre de Usuario")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.MidnightBlue;
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                txtNombreUsuario.Text = "Nombre de Usuario";
                txtNombreUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Contraseña")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.MidnightBlue;

            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                txtClave.Text = "Contraseña";
                txtClave.ForeColor = Color.Gray;

            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var nuevoEmpleado = new EmpleadosDTO
            {
                Nombre = txtNombre.Text.Trim(),
                Cargo = txtCargo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Clave = txtClave.Text.Trim()
            };

            try
            {
                var respuesta = await _httpClient.PostAsJsonAsync(BaseUrl, nuevoEmpleado);
                if (respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Empleado creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    string errorMsg = await respuesta.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear empleado: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Ingrese el cargo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Ingrese la clave.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCargo.Text = "";
            txtTelefono.Text = "";
            txtNombreUsuario.Text = "";
            txtClave.Text = "";
        }
    }
}
