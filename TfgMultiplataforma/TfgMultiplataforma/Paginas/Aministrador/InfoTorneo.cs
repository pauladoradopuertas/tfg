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
    public partial class InfoTorneo : Form
    {
        private int idTorneo;

        public InfoTorneo(int idTorneo)
        {
            InitializeComponent();
            this.idTorneo = idTorneo;
        }

        private void InfoTorneo_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=basedatos_tfg;Uid=root;Pwd=;"))
            {
                conn.Open();

                // Datos del torneo
                string query = @"
            SELECT t.nombre, t.fecha_inicio, t.fecha_fin, t.dia_partida, t.max_equipos,
                   j.nombre AS juego, e.nombre AS estado
            FROM torneos t
            JOIN juegos j ON t.id_juego = j.id_juego
            JOIN estados e ON t.id_estado = e.id_estado
            WHERE t.id_torneo = @idTorneo";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTorneo", idTorneo);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox_nombre_info_torneo.Text = reader.GetString("nombre");
                            textBox_fechaIn_info_torneo.Text = reader.GetDateTime("fecha_inicio").ToShortDateString();
                            textBox_fechaFin_info_torneo.Text = reader.GetDateTime("fecha_fin").ToShortDateString();
                            textBox_partida_info_torneo.Text = reader.GetString("dia_partida");
                            textBox_cant_equipos_info_torneo.Text = reader.GetInt32("max_equipos").ToString();
                            textBox_juego_info_torneo.Text = reader.GetString("juego");
                            textBox_estado_info_torneo.Text = reader.GetString("estado");
                        }
                    }
                }

                // Equipos
                string queryEquipos = @"
            SELECT e.nombre
            FROM `equipos-torneos` et
            JOIN equipos e ON et.id_equipo = e.id_equipo
            WHERE et.id_torneo = @idTorneo";

                using (MySqlCommand cmd = new MySqlCommand(queryEquipos, conn))
                {
                    cmd.Parameters.AddWithValue("@idTorneo", idTorneo);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox_equipos_info_torneo.Items.Add(reader.GetString("nombre"));
                        }
                    }
                }
            }
        }

        private void button_volver_info_torneo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
