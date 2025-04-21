using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TfgMultiplataforma.Paginas.Aministrador
{
    public partial class AdminForm : Form
    {
        private string conexionString = "Server=localhost;Database=basedatos_tfg;Uid=root;Pwd=;";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            CargarEstadosUsuario();
        }

        private void CargarEstadosUsuario()
        {
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();

                string query = "SELECT id_estado_usuario, nombre FROM estados_usuario";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable estados = new DataTable();
                    estados.Load(reader);

                    comboBox_estado_admin.DisplayMember = "nombre";
                    comboBox_estado_admin.ValueMember = "id_estado_usuario";
                    comboBox_estado_admin.DataSource = estados;
                }
            }

            // Evento de cambio de selección
            comboBox_estado_admin.SelectedIndexChanged += comboBox_estado_admin_SelectedIndexChanged;

            // Establecer el valor por defecto como 'activo' (id = 1)
            comboBox_estado_admin.SelectedValue = 1;

            // Cargar usuarios activos al inicio
            CargarUsuariosPorEstado(1);
        }



        private void comboBox_estado_admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_estado_admin.SelectedValue is int estadoSeleccionado)
            {
                CargarUsuariosPorEstado(estadoSeleccionado);
            }
        }

        private void CargarUsuariosPorEstado(int idEstado)
        {
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();

                string query;

                if (idEstado == 1) // Activo: con equipo
                {
                    query = @"
                        SELECT nombre, apellidos, usuario 
                        FROM clientes 
                        WHERE id_estado_usuario = @estado 
                        AND id_equipo IS NOT NULL";
                }
                else if (idEstado == 2) // Inactivo: sin equipo
                {
                    query = @"
                        SELECT nombre, apellidos, usuario 
                        FROM clientes 
                        WHERE id_estado_usuario = @estado 
                        AND id_equipo IS NULL";
                }
                else
                {
                    listBox_usuarios_admin.Items.Clear();
                    return;
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@estado", idEstado);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBox_usuarios_admin.Items.Clear();

                        while (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string apellidos = reader["apellidos"].ToString();
                            string usuario = reader["usuario"].ToString();

                            string info = $"{nombre} {apellidos} ({usuario})";
                            listBox_usuarios_admin.Items.Add(info);
                        }
                    }
                }
            }
        }

        private void button_borrar_usuario_admin_Click(object sender, EventArgs e)
        {
            if (listBox_usuarios_admin.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario de la lista.");
                return;
            }

            // Extraer el nombre de usuario entre paréntesis
            string item = listBox_usuarios_admin.SelectedItem.ToString();
            int start = item.IndexOf('(') + 1;
            int end = item.IndexOf(')');
            string usuario = item.Substring(start, end - start);

            DialogResult resultado = MessageBox.Show(
                $"¿Quieres eliminar al usuario '{usuario}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                EliminarUsuario(usuario);
            }
        }

        private void EliminarUsuario(string usuario)
        {
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();

                string query = "DELETE FROM clientes WHERE usuario = @usuario";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");

                        // Refrescar la lista según el estado actual seleccionado
                        if (comboBox_estado_admin.SelectedValue is int idEstado)
                        {
                            CargarUsuariosPorEstado(idEstado);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.");
                    }
                }
            }
        }

        private void button_info_usuario_admin_Click(object sender, EventArgs e)
        {
            if (listBox_usuarios_admin.SelectedItem != null)
            {
                // Extraer el nombre de usuario entre paréntesis del texto del listBox
                string item = listBox_usuarios_admin.SelectedItem.ToString();
                int start = item.IndexOf('(') + 1;
                int end = item.IndexOf(')');
                string usuario = item.Substring(start, end - start);

                // Abrir el formulario InfoUsuario pasándole el nombre de usuario
                InfoUsuario infoUsuarioForm = new InfoUsuario(usuario);
                infoUsuarioForm.ShowDialog(); // Lo puedes cambiar por .Show() si no quieres que sea modal
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para ver su información.");
            }
        }
    }
}
