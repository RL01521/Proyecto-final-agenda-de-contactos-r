using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;
using BLL;

namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly ContactoBLL _contactoBLL = new ContactoBLL();

        public Form1()
        {
            InitializeComponent();
            dtpNacimiento.Value = DateTime.Today.AddYears(-18); // Establecer fecha por defecto (18 años atrás)
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación mejorada
            if (!ValidarDatos())
                return;

            try
            {
                var nuevoPaciente = new Paciente(
                    nombre: txtNombre.Text.Trim(),
                    apellido: txtApellido.Text.Trim(),
                    telefono: txtTelefono.Text.Trim(),
                    correo: txtCorreo.Text.Trim(),
                    fechaNacimiento: dtpNacimiento.Value.Date,
                    historialClinico: txtHistorialClinico.Text.Trim()
                );

                _contactoBLL.Insertar(nuevoPaciente);

                MessageBox.Show("Paciente agregado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                // O this.Close() si deseas cerrar después de agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el paciente: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (dtpNacimiento.Value > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNacimiento.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtHistorialClinico.Clear();
            dtpNacimiento.Value = DateTime.Today.AddYears(-18);
            txtNombre.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
