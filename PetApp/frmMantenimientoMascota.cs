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
    public partial class frmMantenimientoMascota : Form
    {

        string NombreOriginal;

        public frmMantenimientoMascota()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new PetAppContext())
            {
                string nuevoValor = txtEdit.Text;

                if (Data.SelectedRows.Count > 0)
                {
                    int idMascota = Convert.ToInt32(Data.SelectedRows[0].Cells["IdMascota"].Value);
                    var mascota = db.Mascota.Find(idMascota);

                    if (mascota != null)
                    {
                        if (NombreOriginal == "Alias")
                        {
                            mascota.Alias = nuevoValor;
                        }
                        else if (NombreOriginal == "Especie")
                        {
                            mascota.Especie = nuevoValor;
                        }
                        else if (NombreOriginal == "Raza")
                        {
                            mascota.Raza = nuevoValor;
                        }
                        else if (NombreOriginal == "ColorPelo")
                        {
                            mascota.ColorPelo = nuevoValor;
                        }
                        else if (NombreOriginal == "FechaNacimiento")
                        {
                            if (DateTime.TryParse(nuevoValor, out DateTime fechaNacimiento))
                            {
                                mascota.FechaNacimiento = fechaNacimiento;
                            }
                            else
                            {
                                MessageBox.Show("Formato de fecha incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        db.Entry(mascota).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        // Limpiar el TextBox
                        txtEdit.Text = string.Empty;

                        // Actualizar el DataGridView con todos los datos
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la mascota en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila en el DataGridView antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Data.SelectedRows.Count > 0)
            {
                string valorCelda = Data.SelectedRows[0].Cells[Data.CurrentCell.ColumnIndex].Value.ToString();
                txtEdit.Text = valorCelda;
                NombreOriginal = Data.Columns[Data.CurrentCell.ColumnIndex].Name;
            }
        }

        private void frmManteniminetoMascota_Load(object sender, EventArgs e)
        {
            // Cargar todos los datos de mascotas al inicio
            RefreshDataGridView();

            // Ocultar la columna IdMascota
            Data.Columns["IdMascota"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grpEdit.Visible == true)
            {
                grpEdit.Visible = false;
                btnEditar.Text = "Editar";
            }
            else
            {
                grpEdit.Visible = true;
                btnEditar.Text = "Cancelar";
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
                        m.Especie,
                        m.Raza,
                        m.ColorPelo,
                        m.FechaNacimiento
                    })
                    .ToList();

                Data.DataSource = mascotas;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Data.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (var db = new PetAppContext())
                    {
                        int idMascota = Convert.ToInt32(Data.SelectedRows[0].Cells["IdMascota"].Value);
                        var mascota = db.Mascota.Find(idMascota);

                        if (mascota != null)
                        {
                            db.Mascota.Remove(mascota);
                            db.SaveChanges();

                            // Actualizar el DataGridView después de eliminar
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la mascota en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en el DataGridView antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
