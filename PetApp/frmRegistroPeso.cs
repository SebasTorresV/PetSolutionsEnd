using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmRegistroPeso : Form
    {
        public frmRegistroPeso()
        {
            InitializeComponent();

            // Llenar el ComboBox cmbPeso con los alias de las mascotas
            CargarComboBoxAlias();
        }

        private void CargarComboBoxAlias()
        {
            using (var db = new PetAppContext())
            {
                // Obtener los alias de las mascotas
                var aliasMascotas = db.Mascota.Select(m => m.Alias).ToList();

                // Establecer los alias como origen de datos del ComboBox
                cmbPeso.DataSource = aliasMascotas;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el alias de la mascota seleccionada en el ComboBox
            string aliasMascota = cmbPeso.SelectedItem as string;

            if (string.IsNullOrEmpty(aliasMascota))
            {
                MessageBox.Show("Por favor, seleccione una mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ID de la mascota a partir del alias
            int idMascota = ObtenerIdMascotaPorAlias(aliasMascota);

            if (idMascota == -1)
            {
                MessageBox.Show("No se encontró la mascota en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la fecha ingresada
            DateTime fecha = dtpFecha.Value.Date;

            // Validar el valor ingresado en 'Peso'
            if (!decimal.TryParse(txtPeso.Text, out decimal peso))
            {
                MessageBox.Show("El valor ingresado en 'Peso' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir el valor de 'peso' a string
            string pesoStr = peso.ToString();

            // Guardar el registro de peso en la tabla Pesos
            using (var db = new PetAppContext())
            {
                var nuevoPeso = new Pesos
                {
                    IdMascota = idMascota,
                    Fecha = fecha,
                    Peso = pesoStr // Asignar el valor convertido a string
                };

                db.Pesos.Add(nuevoPeso);
                db.SaveChanges();

                MessageBox.Show("Registro de peso guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los controles después de guardar
                cmbPeso.SelectedIndex = -1;
                dtpFecha.Value = DateTime.Today;
                txtPeso.Clear();
            }
        }



        private int ObtenerIdMascotaPorAlias(string alias)
        {
            using (var db = new PetAppContext())
            {
                var mascota = db.Mascota.FirstOrDefault(m => m.Alias == alias);
                return mascota?.IdMascota ?? -1;
            }
        }

        private void frmRegistroPeso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petAppMascota.Mascota' table. You can move, or remove it, as needed.
            this.mascotaTableAdapter.Fill(this.petAppMascota.Mascota);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    