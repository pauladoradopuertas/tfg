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

namespace TfgMultiplataforma.Paginas.Usuarios
{
    public partial class unirseEquipo : Form
    {

        private string conexionString = "Server=localhost;Database=tfg_bbdd;Uid=root;Pwd=;";
        private int idUsuario;

        public unirseEquipo(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            CargarEquipos(""); // Cargar todos los equipos al iniciar
        }

        // Diccionario para mantener relación nombre-ID(variable de clase)
        private Dictionary<string, int> equiposDict = new Dictionary<string, int>();

        private void CargarEquipos(string filtroNombre)
        {
            listBox_buscar_equipos.Items.Clear();
            equiposDict.Clear(); // Limpiar diccionario

            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();
                string query = @"SELECT id_equipos, nombre FROM equipos 
                        WHERE visible = 'si' 
                        AND nombre LIKE @filtro
                        ORDER BY nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtroNombre}%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreEquipo = reader["nombre"].ToString();
                            int idEquipo = Convert.ToInt32(reader["id_equipos"]);

                            listBox_buscar_equipos.Items.Add(nombreEquipo); // Solo muestra el nombre
                            equiposDict[nombreEquipo] = idEquipo;    // Guarda relación nombre-ID
                        }
                    }
                }
            }
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            CargarEquipos(textBox_buscar_equipo.Text.Trim());
        }

        private void button_volver_buscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_unirse_Click(object sender, EventArgs e)
        {
            if (listBox_buscar_equipos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un equipo primero.");
                return;
            }

            string nombreEquipo = listBox_buscar_equipos.SelectedItem.ToString();
            int idEquipo = equiposDict[nombreEquipo]; // Obtiene ID desde el diccionario

            UnirseAEquipo(idUsuario, idEquipo); // Método existente
        }

        private void UnirseAEquipo(int idUsuario, int idEquipo)
        {
            using (MySqlConnection conn = new MySqlConnection(conexionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insertar relación en clientes-equipos
                    string queryInsert = "INSERT INTO `clientes-equipos` (id_cliente, id_equipo) VALUES (@idUsuario, @idEquipo)";
                    MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn, transaction);
                    cmdInsert.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmdInsert.Parameters.AddWithValue("@idEquipo", idEquipo);
                    cmdInsert.ExecuteNonQuery();

                    // 2. Actualizar estado Y ROL del usuario
                    string queryUpdate = @"UPDATE clientes 
                     SET id_estado_usuario = 1, 
                         id_rol_usuario = 2
                     WHERE id_cliente = @idUsuario";

                    MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn, transaction);
                    cmdUpdate.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmdUpdate.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Te has unido al equipo correctamente como Miembro.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al unirse al equipo: " + ex.Message);
                }
            }
        }
    }
}
