using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petAppMascota.Mascota' table. You can move, or remove it, as needed.
            this.mascotaTableAdapter.Fill(this.petAppMascota.Mascota);
            // TODO: This line of code loads data into the 'petAppMascota.Mascota' table. You can move, or remove it, as needed.
            this.mascotaTableAdapter.Fill(this.petAppMascota.Mascota);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbReporte.SelectedIndex >= 0)
            {
                // Obtener el alias seleccionado
                string aliasSeleccionado = cmbReporte.SelectedItem.ToString();

                // Mostrar el alias seleccionado en un MessageBox (esto es para depuración)
                MessageBox.Show("Alias seleccionado: " + aliasSeleccionado);

                // Aquí debes buscar en tu base de datos el IdMascota correspondiente al alias seleccionado
                // y luego buscar la fecha próxima en la tabla Vacunas
                using (var db = new PetAppContext())
                {
                    // Supongamos que tienes una entidad Mascota con un campo Alias

                    var mascota = db.Mascota.FirstOrDefault(m => m.Alias == aliasSeleccionado);

                    if (mascota != null)
                    {
                        // Ahora que tienes el IdMascota, puedes buscar la fecha próxima en Vacunas
                        var fechaProxima = db.Vacunas
                                .Where(v => v.IdMascota == mascota.IdMascota)
                                .OrderByDescending(v => v.FechaProxima)
                                .Select(v => v.FechaProxima)
                                .FirstOrDefault();

                        // Mostrar la fecha próxima en el TextBox txtVacuna
                        txtVacuna.Text = fechaProxima?.ToString("yyyy-MM-dd") ?? "No disponible";
                    }
                    else
                    {
                        txtVacuna.Text = "No se encontró la mascota.";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
