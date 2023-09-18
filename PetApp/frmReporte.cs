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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el valor seleccionado en el ComboBox cmbReporte
            string reporteSeleccionado = cmbReporte.SelectedItem.ToString();

            // Realiza la consulta en función del reporte seleccionado
            switch (reporteSeleccionado)
            {
                case "Reporte 1": // NombreCompleto, Telefono, Email
                    using (var db = new PetAppContext())
                    {
                        var resultados = db.Cliente.Select(c => new
                        {
                            c.NombreCompleto,
                            c.Telefono,
                            c.Email
                        }).ToList();

                        Data.DataSource = resultados;
                    }
                    break;

                case "Reporte 2": // Alias, Peso
                    using (var db = new PetAppContext())
                    {
                        var resultados = db.Mascota.Join(
                            db.Pesos,
                            mascota => mascota.IdMascota,
                            peso => peso.IdMascota,
                            (mascota, peso) => new
                            {
                                mascota.Alias,
                                peso.Peso
                            }).ToList();

                        Data.DataSource = resultados;
                    }
                    break;

                case "Reporte 3": // Alias, Enfermedad, FechaProxima
                    using (var db = new PetAppContext())
                    {
                        var resultados = db.Mascota.Join(
                            db.Vacunas,
                            mascota => mascota.IdMascota,
                            vacuna => vacuna.IdMascota,
                            (mascota, vacuna) => new
                            {
                                mascota.Alias,
                                vacuna.Enfermedad,
                                vacuna.FechaProxima
                            }).ToList();

                        Data.DataSource = resultados;
                    }
                    break;

                default:
                    // Reporte no reconocido, puedes manejarlo según tus necesidades.
                    break;
            }
        }
    }
}
