using System;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmRegistroVacunas : Form
    {
        public frmRegistroVacunas()
        {
            InitializeComponent();

            // Asociar el evento SelectedIndexChanged del ComboBox cmbIdMascota
            cmbIdMascota.SelectedIndexChanged += cmbIdMascota_SelectedIndexChanged;

            // Cargar el ComboBox cmbIdMascota con los alias de las mascotas
            using (var db = new PetAppContext())
            {
                var aliasMascotas = db.Mascota.Select(m => m.Alias).ToList();
                cmbIdMascota.DataSource = aliasMascotas;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbIdMascota.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string aliasMascota = cmbIdMascota.SelectedItem.ToString();
            DateTime fecha = dtpFecha.Value.Date;
            string enfermedad = txtEnfermedad.Text.Trim();
            DateTime fechaProxima = dtpFechaProx.Value.Date;

            // Validaciones adicionales si es necesario...

            using (var db = new PetAppContext())
            {
                var mascota = db.Mascota.FirstOrDefault(m => m.Alias == aliasMascota);

                if (mascota != null)
                {
                    var nuevaVacuna = new Vacunas
                    {
                        IdMascota = mascota.IdMascota,
                        Fecha = fecha,
                        Enfermedad = enfermedad,
                        FechaProxima = fechaProxima
                    };

                    db.Vacunas.Add(nuevaVacuna);
                    db.SaveChanges();

                    MessageBox.Show("Registro de vacuna guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los controles después de guardar si es necesario...
                    cmbIdMascota.SelectedIndex = -1;
                    dtpFecha.Value = DateTime.Today;
                    txtEnfermedad.Clear();
                    dtpFechaProx.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("No se encontró la mascota seleccionada en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbIdMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdMascota.SelectedIndex >= 0)
            {
                string aliasSeleccionado = cmbIdMascota.SelectedItem.ToString();

                // Puedes realizar acciones adicionales con el alias de la mascota seleccionada si es necesario.
            }
        }

        private void frmRegistroVacunas_Load(object sender, EventArgs e)
        {
            // TODO: Cargar datos adicionales si es necesario...
        }
    }
}
