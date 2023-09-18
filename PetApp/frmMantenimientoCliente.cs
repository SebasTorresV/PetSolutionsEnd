using System;
using System.Windows.Forms;
using System.Linq;

namespace PetApp
{
    public partial class frmMantenimientoCliente : Form
    {
        int IdCliente;
        string NombreOriginal;

        public frmMantenimientoCliente()
        {
            InitializeComponent();
        }

        private void grdData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Data.SelectedRows.Count > 0)
            {
                string valorCelda = Data.SelectedRows[0].Cells[Data.CurrentCell.ColumnIndex].Value.ToString();
                txtEdit.Text = valorCelda;
                NombreOriginal = Data.Columns[Data.CurrentCell.ColumnIndex].Name;
            }
        }

        private void frmManteniminetoCliente_Load(object sender, EventArgs e)
        {
            // Cargar todos los datos al inicio
            RefreshDataGridView();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new PetAppContext())
            {
                string nuevoValor = txtEdit.Text;

                if (Data.SelectedRows.Count > 0)
                {
                    int idCliente = Convert.ToInt32(Data.SelectedRows[0].Cells["IdCliente"].Value);
                    var cliente = db.Cliente.Find(idCliente);

                    if (cliente != null)
                    {
                        if (NombreOriginal == "NombreCompleto")
                        {
                            cliente.NombreCompleto = nuevoValor;
                        }
                        else if (NombreOriginal == "Telefono")
                        {
                            cliente.Telefono = nuevoValor;
                        }
                        else if (NombreOriginal == "Email")
                        {
                            cliente.Email = nuevoValor;
                        }

                        db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        // Limpiar el TextBox
                        txtEdit.Text = string.Empty;

                        // Actualizar el DataGridView con todos los datos
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila en el DataGridView antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        int idCliente = Convert.ToInt32(Data.SelectedRows[0].Cells["IdCliente"].Value);
                        var cliente = db.Cliente.Find(idCliente);

                        if (cliente != null)
                        {
                            db.Cliente.Remove(cliente);
                            db.SaveChanges();

                            // Actualizar el DataGridView después de eliminar
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en el DataGridView antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            using (var db = new PetAppContext())
            {
                // Consulta los datos incluyendo la columna IdCliente
                var clientes = db.Cliente
                    .Select(c => new
                    {
                        c.IdCliente,
                        c.NombreCompleto,
                        c.Telefono,
                        c.Email
                    })
                    .ToList();

                Data.DataSource = clientes;
            }
        }
    }
}
