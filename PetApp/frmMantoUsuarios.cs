using System;
using System.Linq;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmMantoUsuarios : Form
    {
        public frmMantoUsuarios()
        {
            InitializeComponent();
        }

        private string EmailOriginal; // Variable para almacenar el valor original del Email

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
                    // Obtén el valor original del Email
                    string emailOriginal = EmailOriginal;

                    // Busca el usuario en la base de datos por su Email original
                    var usuario = db.Usuarios.FirstOrDefault(u => u.Email == emailOriginal);

                    if (usuario != null)
                    {
                        // Carga una nueva instancia del usuario
                        var usuarioActualizado = db.Usuarios.FirstOrDefault(u => u.Email == emailOriginal);

                        // Actualiza el valor del campo Email
                        usuarioActualizado.Email = nuevoValor;

                        // Guarda los cambios en el contexto
                        db.SaveChanges();

                        // Actualiza el DataGridView con los nuevos datos
                        var usuarios = db.Usuarios
                            .Select(u => new
                            {
                                u.Email
                            })
                            .ToList();

                        Data.DataSource = usuarios;

                        // Limpia el TextBox
                        txtEdit.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila en el DataGridView antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmMantoUsuarios_Load(object sender, EventArgs e)
        {
            using (var db = new PetAppContext())
            {
                var usuarios = db.Usuarios
                    .Select(u => new
                    {
                        u.Email
                    })
                    .ToList();

                Data.DataSource = usuarios;
            }
        }

        private void Data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Data.SelectedRows.Count > 0)
            {
                string valorCelda = Data.SelectedRows[0].Cells[0].Value.ToString();
                txtEdit.Text = valorCelda;
                EmailOriginal = valorCelda; // Almacena el valor original del Email
            }
        }
    }
}
