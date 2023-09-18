using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace PetApp
{
    public partial class frmReporte : Form
    {

        string Datos;

        public frmReporte()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.SelectedRows.Count > 0)
            {
                // Obtén el IdMascota seleccionado en el DataGridView
                int idMascotaSeleccionado = (int)Data.SelectedRows[0].Cells["IdMascota"].Value;

                // Realiza la búsqueda en la tabla Vacunas usando el IdMascota
                using (var db = new PetAppContext())
                {
                    var fechaProxima = db.Vacunas
                        .Where(v => v.IdMascota == idMascotaSeleccionado)
                        .OrderByDescending(v => v.FechaProxima)
                        .Select(v => v.FechaProxima)
                        .FirstOrDefault();

                    if (fechaProxima != null)
                    {
                        MessageBox.Show($"La fecha próxima para la mascota seleccionada es: {fechaProxima:yyyy-MM-dd}");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros de vacunas para esta mascota.");
                    }
                }
            }
        }



        private void RefreshDataGridView()
        {
            using (var db = new PetAppContext())
            {
                var mascotas = db.Mascota
                    .Select(m => new
                    {
                        m.IdMascota,
                        m.Alias,
                        
                    })
                    .ToList();

                Data.DataSource = mascotas;
            }
        }



        private void Data_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (Data.SelectedRows.Count > 0)
            {
                string valorCelda = Data.SelectedRows[0].Cells[Data.CurrentCell.ColumnIndex].Value.ToString();
                txtDatos.Text = valorCelda;
                Datos = Data.Columns[Data.CurrentCell.ColumnIndex].Name;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            // Cargar todos los datos de mascotas al inicio
            RefreshDataGridView();
        }
    }
}
