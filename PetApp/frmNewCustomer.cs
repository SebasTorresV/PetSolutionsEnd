using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petAppMascota.Mascota' table. You can move, or remove it, as needed.
            this.mascotaTableAdapter.Fill(this.petAppMascota.Mascota);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el Alias de la mascota seleccionada en el ComboBox
            string aliasMascota = cmbMascota.SelectedItem.ToString().Trim();

            // Agrega un MessageBox para verificar el valor seleccionado en el ComboBox
            MessageBox.Show("Alias seleccionado en ComboBox: " + aliasMascota);

            using (var db = new PetAppContext())
            {
                // Continúa con la búsqueda en la base de datos y el proceso de guardado
                var mascota = db.Mascota.FirstOrDefault(m => m.Alias == aliasMascota);

                if (mascota != null)
                {
                    // Si se encontró la mascota, obtén el ID de la misma
                    int idMascota = mascota.IdMascota;

                    // Obtén los otros valores que necesitas guardar
                    DateTime fecha = FechaInicial.Value;
                    string enfermedad = txtEnfermedad.Text;
                    DateTime fechaProxima = dtFechaProx.Value;

                    // Ahora, puedes guardar los datos en la tabla de "Vacunas"
                    var nuevaVacuna = new Vacunas()
                    {
                        IdMascota = idMascota,
                        Fecha = fecha,
                        Enfermedad = enfermedad,
                        FechaProxima = fechaProxima
                    };

                    db.Vacunas.Add(nuevaVacuna);
                    db.SaveChanges();

                    MessageBox.Show("Nueva vacuna registrada exitosamente.");
                }
                else
                {
                    MessageBox.Show("La mascota seleccionada no fue encontrada en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Limpia los campos después de guardar la vacuna
            txtEnfermedad.Clear();
            FechaInicial.Value = DateTime.Now;
            dtFechaProx.Value = DateTime.Now;
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
