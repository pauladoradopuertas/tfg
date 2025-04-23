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
    public partial class InfoEquipo : Form
    {

        private int idEquipo;
        private string conexionString = "Server=localhost;Database=basedatos_tfg;Uid=root;Pwd=;";

        public InfoEquipo(int idEquipo)
        {
            InitializeComponent();
            this.idEquipo = idEquipo;
        }

        private void InfoEquipo_Load(object sender, EventArgs e)
        {
            CargarDatosEquipo();
        }

        private void CargarDatosEquipo()
        {
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();

                // Obtener datos del equipo
                string queryEquipo = "SELECT nombre, fecha_creacion, visible FROM equipos WHERE id_equipo = @id_equipo";
                using (MySqlCommand cmd = new MySqlCommand(queryEquipo, conn))
                {
                    cmd.Parameters.AddWithValue("@id_equipo", idEquipo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombreEquipo = reader["nombre"].ToString();
                            textBox_nombre_equipo_admin.Text = reader["nombre"].ToString();
                            textBox_creacion_equipo_admin.Text = Convert.ToDateTime(reader["fecha_creacion"]).ToShortDateString();
                            textBox_visible_equipo_admin.Text = reader["visible"].ToString();
                            label_titulo_equipo_admin.Text = $"Equipo: {nombreEquipo}";
                        }
                    }
                }

                // Obtener miembros del equipo y sus roles
                string queryMiembros = @"
            SELECT c.nombre, c.apellidos, c.usuario, ru.nombre AS rol
            FROM clientes c
            JOIN roles_usuario ru ON c.id_rol_usuario = ru.id_rol_usuario
            WHERE c.id_equipo = @id_equipo";

                using (MySqlCommand cmd = new MySqlCommand(queryMiembros, conn))
                {
                    cmd.Parameters.AddWithValue("@id_equipo", idEquipo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBox_miembros_equipo_admin.Items.Clear();

                        while (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string apellidos = reader["apellidos"].ToString();
                            string usuario = reader["usuario"].ToString();
                            string rol = reader["rol"].ToString();

                            listBox_miembros_equipo_admin.Items.Add($"{nombre} {apellidos} ({usuario}) - {rol}");
                        }

                        if (listBox_miembros_equipo_admin.Items.Count == 0)
                            listBox_miembros_equipo_admin.Items.Add("Sin miembros.");
                    }
                }
            }
        }

        private void button_volver_info_equipo_admin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
