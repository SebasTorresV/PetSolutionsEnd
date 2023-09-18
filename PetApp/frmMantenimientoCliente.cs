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
                    .Where(X => X.NombreCompleto.Contains(txtEdit.Text))
                    .ToList();

                Data.DataSource = clientes;
            }
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

                        Data.DataSource = db.Cliente.ToList();
                        txtEdit.Text = string.Empty;
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
    }
}
