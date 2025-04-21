using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TfgMultiplataforma.Paginas.Aministrador
{
    public partial class InfoUsuario : Form
    {

        private string usuario;
        private string conexionString = "Server=localhost;Database=basedatos_tfg;Uid=root;Pwd=;";

        public InfoUsuario(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void InfoUsuario_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();

        }

        // Método para cargar los datos del usuario
        private void CargarDatosUsuario()
        {
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();

                // Consulta para obtener los datos del usuario
                string query = "SELECT nombre, apellidos, telefono, dni, email, contrasena FROM clientes WHERE usuario = @usuario";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Asignar los datos a los TextBox
                            textBox_info_nombre_admin.Text = reader["nombre"].ToString();
                            textBox_info_apellidos_admin.Text = reader["apellidos"].ToString();
                            textBox_info_telefono_admin.Text = reader["telefono"].ToString();
                            textBox_info_dni_admin.Text = reader["dni"].ToString();
                            textBox_info_email_admin.Text = reader["email"].ToString();
                            textBox_info_usuario_admin.Text = usuario;
                            textBox_info_contrasena_admin.Text = reader["contrasena"].ToString();

                            // Modificar el título para incluir el nombre del usuario
                            titulo_usuario_admin.Text = $"Datos del Usuario: {usuario}";
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para este usuario.");
                        }
                    }
                }
            }
        }

        private void button_volver_perfil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
