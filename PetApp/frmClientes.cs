using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PetApp
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtén los valores ingresados en los TextBox.
            string nombreCompleto = txtNom.Text;
            string telefono = txtTel.Text;
            string email = txtEmail.Text;

            // Validación de campos vacíos.
            if (string.IsNullOrWhiteSpace(nombreCompleto) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validación del formato de correo electrónico.
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor, ingrese un formato de correo electrónico válido.");
                return;
            }

            // Validación del número de teléfono (8 dígitos con guin enmedio).
            if (telefono.Length != 8 || !IsValidPhoneNumberDigits(telefono))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido (8 dígitos).");
                return;
            }

            using (var db = new PetAppContext())
            {
                // Crea un nuevo objeto Cliente con los valores ingresados.
                var nuevoCliente = new Cliente()
                {
                    NombreCompleto = nombreCompleto,
                    Telefono = telefono,
                    Email = email
                };

                // Agrega el nuevo cliente a la base de datos y guarda los cambios.
                db.Cliente.Add(nuevoCliente);
                db.SaveChanges();

                MessageBox.Show("Nuevo cliente registrado exitosamente.");
            }

            // Limpia los campos de texto después de guardar el cliente.
            txtNom.Clear();
            txtTel.Clear();
            txtEmail.Clear();
        }



        private bool IsValidPhoneNumberDigits(string phoneNumber)
        {
            // Verifica si el número de teléfono contiene solo dígitos.
            return phoneNumber.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }

}

