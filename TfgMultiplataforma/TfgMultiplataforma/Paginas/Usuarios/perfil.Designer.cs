namespace TfgMultiplataforma.Paginas.Usuarios
{
    partial class perfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_editar_perfil = new Button();
            textBox_usuario_perfil = new TextBox();
            label_usuario_perfil = new Label();
            titulo_perfil = new Label();
            tabControl_perfil = new TabControl();
            tabPage_perfil = new TabPage();
            button_volver_perfil = new Button();
            textBox_email_perfil = new TextBox();
            label_email_perfil = new Label();
            textBox_dni_perfil = new TextBox();
            label_dni_perfil = new Label();
            textBox_telefono_perfil = new TextBox();
            label_telefono_perfil = new Label();
            textBox_apellidos_perfil = new TextBox();
            label_apellidos_perfil = new Label();
            textBox_nombre_perfil = new TextBox();
            label_nombre_perfil = new Label();
            textBox_contrasena_perfil = new TextBox();
            label_contrasena_perfil = new Label();
            tabPage_historial = new TabPage();
            button_unir_torneo = new Button();
            label_estado_torneo = new Label();
            button_unir_evento = new Button();
            button_info_torneo = new Button();
            listBox_torneos = new ListBox();
            comboBox_eventos = new ComboBox();
            label_usuarios_torneo = new Label();
            Estadisticas = new TabPage();
            tabControl_perfil.SuspendLayout();
            tabPage_perfil.SuspendLayout();
            tabPage_historial.SuspendLayout();
            SuspendLayout();
            // 
            // button_editar_perfil
            // 
            button_editar_perfil.Font = new Font("Segoe UI", 12F);
            button_editar_perfil.Location = new Point(170, 537);
            button_editar_perfil.Name = "button_editar_perfil";
            button_editar_perfil.Size = new Size(149, 37);
            button_editar_perfil.TabIndex = 20;
            button_editar_perfil.Text = "Editar";
            button_editar_perfil.UseVisualStyleBackColor = true;
            button_editar_perfil.Click += button_editar_perfil_Click;
            // 
            // textBox_usuario_perfil
            // 
            textBox_usuario_perfil.Location = new Point(170, 77);
            textBox_usuario_perfil.Name = "textBox_usuario_perfil";
            textBox_usuario_perfil.Size = new Size(578, 27);
            textBox_usuario_perfil.TabIndex = 19;
            // 
            // label_usuario_perfil
            // 
            label_usuario_perfil.AutoSize = true;
            label_usuario_perfil.Font = new Font("Segoe UI", 15F);
            label_usuario_perfil.Location = new Point(24, 69);
            label_usuario_perfil.Name = "label_usuario_perfil";
            label_usuario_perfil.Size = new Size(100, 35);
            label_usuario_perfil.TabIndex = 18;
            label_usuario_perfil.Text = "Usuario";
            // 
            // titulo_perfil
            // 
            titulo_perfil.AutoSize = true;
            titulo_perfil.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titulo_perfil.Location = new Point(366, 3);
            titulo_perfil.Name = "titulo_perfil";
            titulo_perfil.Size = new Size(106, 46);
            titulo_perfil.TabIndex = 17;
            titulo_perfil.Text = "Perfil";
            titulo_perfil.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabControl_perfil
            // 
            tabControl_perfil.Controls.Add(tabPage_perfil);
            tabControl_perfil.Controls.Add(tabPage_historial);
            tabControl_perfil.Controls.Add(Estadisticas);
            tabControl_perfil.Location = new Point(12, 12);
            tabControl_perfil.Name = "tabControl_perfil";
            tabControl_perfil.SelectedIndex = 0;
            tabControl_perfil.Size = new Size(900, 633);
            tabControl_perfil.TabIndex = 21;
            // 
            // tabPage_perfil
            // 
            tabPage_perfil.Controls.Add(button_volver_perfil);
            tabPage_perfil.Controls.Add(textBox_email_perfil);
            tabPage_perfil.Controls.Add(label_email_perfil);
            tabPage_perfil.Controls.Add(textBox_dni_perfil);
            tabPage_perfil.Controls.Add(label_dni_perfil);
            tabPage_perfil.Controls.Add(textBox_telefono_perfil);
            tabPage_perfil.Controls.Add(label_telefono_perfil);
            tabPage_perfil.Controls.Add(textBox_apellidos_perfil);
            tabPage_perfil.Controls.Add(label_apellidos_perfil);
            tabPage_perfil.Controls.Add(textBox_nombre_perfil);
            tabPage_perfil.Controls.Add(label_nombre_perfil);
            tabPage_perfil.Controls.Add(textBox_contrasena_perfil);
            tabPage_perfil.Controls.Add(label_contrasena_perfil);
            tabPage_perfil.Controls.Add(textBox_usuario_perfil);
            tabPage_perfil.Controls.Add(label_usuario_perfil);
            tabPage_perfil.Controls.Add(button_editar_perfil);
            tabPage_perfil.Controls.Add(titulo_perfil);
            tabPage_perfil.Location = new Point(4, 29);
            tabPage_perfil.Name = "tabPage_perfil";
            tabPage_perfil.Padding = new Padding(3);
            tabPage_perfil.Size = new Size(892, 600);
            tabPage_perfil.TabIndex = 0;
            tabPage_perfil.Text = "Perfil";
            tabPage_perfil.UseVisualStyleBackColor = true;
            // 
            // button_volver_perfil
            // 
            button_volver_perfil.Font = new Font("Segoe UI", 12F);
            button_volver_perfil.Location = new Point(599, 537);
            button_volver_perfil.Name = "button_volver_perfil";
            button_volver_perfil.Size = new Size(149, 37);
            button_volver_perfil.TabIndex = 33;
            button_volver_perfil.Text = "Volver";
            button_volver_perfil.UseVisualStyleBackColor = true;
            button_volver_perfil.Click += button_volver_perfil_Click;
            // 
            // textBox_email_perfil
            // 
            textBox_email_perfil.Location = new Point(170, 479);
            textBox_email_perfil.Name = "textBox_email_perfil";
            textBox_email_perfil.Size = new Size(578, 27);
            textBox_email_perfil.TabIndex = 32;
            // 
            // label_email_perfil
            // 
            label_email_perfil.AutoSize = true;
            label_email_perfil.Font = new Font("Segoe UI", 15F);
            label_email_perfil.Location = new Point(24, 471);
            label_email_perfil.Name = "label_email_perfil";
            label_email_perfil.Size = new Size(75, 35);
            label_email_perfil.TabIndex = 31;
            label_email_perfil.Text = "Email";
            // 
            // textBox_dni_perfil
            // 
            textBox_dni_perfil.Location = new Point(170, 403);
            textBox_dni_perfil.Name = "textBox_dni_perfil";
            textBox_dni_perfil.Size = new Size(578, 27);
            textBox_dni_perfil.TabIndex = 30;
            // 
            // label_dni_perfil
            // 
            label_dni_perfil.AutoSize = true;
            label_dni_perfil.Font = new Font("Segoe UI", 15F);
            label_dni_perfil.Location = new Point(24, 395);
            label_dni_perfil.Name = "label_dni_perfil";
            label_dni_perfil.Size = new Size(53, 35);
            label_dni_perfil.TabIndex = 29;
            label_dni_perfil.Text = "Dni";
            // 
            // textBox_telefono_perfil
            // 
            textBox_telefono_perfil.Location = new Point(170, 335);
            textBox_telefono_perfil.Name = "textBox_telefono_perfil";
            textBox_telefono_perfil.Size = new Size(578, 27);
            textBox_telefono_perfil.TabIndex = 28;
            // 
            // label_telefono_perfil
            // 
            label_telefono_perfil.AutoSize = true;
            label_telefono_perfil.Font = new Font("Segoe UI", 15F);
            label_telefono_perfil.Location = new Point(24, 327);
            label_telefono_perfil.Name = "label_telefono_perfil";
            label_telefono_perfil.Size = new Size(110, 35);
            label_telefono_perfil.TabIndex = 27;
            label_telefono_perfil.Text = "Teléfono";
            // 
            // textBox_apellidos_perfil
            // 
            textBox_apellidos_perfil.Location = new Point(170, 267);
            textBox_apellidos_perfil.Name = "textBox_apellidos_perfil";
            textBox_apellidos_perfil.Size = new Size(578, 27);
            textBox_apellidos_perfil.TabIndex = 26;
            // 
            // label_apellidos_perfil
            // 
            label_apellidos_perfil.AutoSize = true;
            label_apellidos_perfil.Font = new Font("Segoe UI", 15F);
            label_apellidos_perfil.Location = new Point(24, 259);
            label_apellidos_perfil.Name = "label_apellidos_perfil";
            label_apellidos_perfil.Size = new Size(118, 35);
            label_apellidos_perfil.TabIndex = 25;
            label_apellidos_perfil.Text = "Apellidos";
            // 
            // textBox_nombre_perfil
            // 
            textBox_nombre_perfil.Location = new Point(170, 204);
            textBox_nombre_perfil.Name = "textBox_nombre_perfil";
            textBox_nombre_perfil.Size = new Size(578, 27);
            textBox_nombre_perfil.TabIndex = 24;
            // 
            // label_nombre_perfil
            // 
            label_nombre_perfil.AutoSize = true;
            label_nombre_perfil.Font = new Font("Segoe UI", 15F);
            label_nombre_perfil.Location = new Point(24, 196);
            label_nombre_perfil.Name = "label_nombre_perfil";
            label_nombre_perfil.Size = new Size(108, 35);
            label_nombre_perfil.TabIndex = 23;
            label_nombre_perfil.Text = "Nombre";
            // 
            // textBox_contrasena_perfil
            // 
            textBox_contrasena_perfil.Location = new Point(170, 143);
            textBox_contrasena_perfil.Name = "textBox_contrasena_perfil";
            textBox_contrasena_perfil.Size = new Size(578, 27);
            textBox_contrasena_perfil.TabIndex = 22;
            // 
            // label_contrasena_perfil
            // 
            label_contrasena_perfil.AutoSize = true;
            label_contrasena_perfil.Font = new Font("Segoe UI", 15F);
            label_contrasena_perfil.Location = new Point(24, 135);
            label_contrasena_perfil.Name = "label_contrasena_perfil";
            label_contrasena_perfil.Size = new Size(140, 35);
            label_contrasena_perfil.TabIndex = 21;
            label_contrasena_perfil.Text = "Contraseña";
            // 
            // tabPage_historial
            // 
            tabPage_historial.Controls.Add(button_unir_torneo);
            tabPage_historial.Controls.Add(label_estado_torneo);
            tabPage_historial.Controls.Add(button_unir_evento);
            tabPage_historial.Controls.Add(button_info_torneo);
            tabPage_historial.Controls.Add(listBox_torneos);
            tabPage_historial.Controls.Add(comboBox_eventos);
            tabPage_historial.Controls.Add(label_usuarios_torneo);
            tabPage_historial.Location = new Point(4, 29);
            tabPage_historial.Name = "tabPage_historial";
            tabPage_historial.Padding = new Padding(3);
            tabPage_historial.Size = new Size(892, 600);
            tabPage_historial.TabIndex = 1;
            tabPage_historial.Text = "Historial de partidas";
            tabPage_historial.UseVisualStyleBackColor = true;
            // 
            // button_unir_torneo
            // 
            button_unir_torneo.Location = new Point(213, 323);
            button_unir_torneo.Name = "button_unir_torneo";
            button_unir_torneo.Size = new Size(103, 52);
            button_unir_torneo.TabIndex = 48;
            button_unir_torneo.Text = "Unirme a un torneo";
            button_unir_torneo.UseVisualStyleBackColor = true;
            // 
            // label_estado_torneo
            // 
            label_estado_torneo.AutoSize = true;
            label_estado_torneo.Font = new Font("Segoe UI", 15F);
            label_estado_torneo.Location = new Point(25, 69);
            label_estado_torneo.Name = "label_estado_torneo";
            label_estado_torneo.Size = new Size(90, 35);
            label_estado_torneo.TabIndex = 47;
            label_estado_torneo.Text = "Estado";
            // 
            // button_unir_evento
            // 
            button_unir_evento.Font = new Font("Segoe UI", 12F);
            button_unir_evento.Location = new Point(313, 396);
            button_unir_evento.Name = "button_unir_evento";
            button_unir_evento.Size = new Size(195, 47);
            button_unir_evento.TabIndex = 5;
            button_unir_evento.Text = "Unirme a un evento";
            button_unir_evento.UseVisualStyleBackColor = true;
            // 
            // button_info_torneo
            // 
            button_info_torneo.Location = new Point(480, 323);
            button_info_torneo.Name = "button_info_torneo";
            button_info_torneo.Size = new Size(103, 52);
            button_info_torneo.TabIndex = 4;
            button_info_torneo.Text = "Ver Información";
            button_info_torneo.UseVisualStyleBackColor = true;
            // 
            // listBox_torneos
            // 
            listBox_torneos.Font = new Font("Segoe UI", 10F);
            listBox_torneos.FormattingEnabled = true;
            listBox_torneos.HorizontalScrollbar = true;
            listBox_torneos.ItemHeight = 23;
            listBox_torneos.Location = new Point(33, 135);
            listBox_torneos.Name = "listBox_torneos";
            listBox_torneos.Size = new Size(718, 165);
            listBox_torneos.TabIndex = 3;
            // 
            // comboBox_eventos
            // 
            comboBox_eventos.Font = new Font("Segoe UI", 12F);
            comboBox_eventos.FormattingEnabled = true;
            comboBox_eventos.Location = new Point(144, 66);
            comboBox_eventos.Name = "comboBox_eventos";
            comboBox_eventos.Size = new Size(578, 36);
            comboBox_eventos.TabIndex = 2;
            // 
            // label_usuarios_torneo
            // 
            label_usuarios_torneo.AutoSize = true;
            label_usuarios_torneo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label_usuarios_torneo.Location = new Point(329, 19);
            label_usuarios_torneo.Name = "label_usuarios_torneo";
            label_usuarios_torneo.Size = new Size(108, 35);
            label_usuarios_torneo.TabIndex = 1;
            label_usuarios_torneo.Text = "Torneos";
            // 
            // Estadisticas
            // 
            Estadisticas.Location = new Point(4, 29);
            Estadisticas.Name = "Estadisticas";
            Estadisticas.Padding = new Padding(3);
            Estadisticas.Size = new Size(892, 600);
            Estadisticas.TabIndex = 2;
            Estadisticas.Text = "Estadísticas";
            Estadisticas.UseVisualStyleBackColor = true;
            // 
            // perfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 657);
            Controls.Add(tabControl_perfil);
            Name = "perfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            Load += perfil_Load;
            tabControl_perfil.ResumeLayout(false);
            tabPage_perfil.ResumeLayout(false);
            tabPage_perfil.PerformLayout();
            tabPage_historial.ResumeLayout(false);
            tabPage_historial.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_editar_perfil;
        private TextBox textBox_usuario_perfil;
        private Label label_usuario_perfil;
        private Label titulo_perfil;
        private TabControl tabControl_perfil;
        private TabPage tabPage_perfil;
        private TabPage tabPage_historial;
        private Button button_unir_torneo;
        private Label label_estado_torneo;
        private Button button_unir_evento;
        private Button button_info_torneo;
        private ListBox listBox_torneos;
        private ComboBox comboBox_eventos;
        private Label label_usuarios_torneo;
        private TextBox textBox_dni_perfil;
        private Label label_dni_perfil;
        private TextBox textBox_telefono_perfil;
        private Label label_telefono_perfil;
        private TextBox textBox_apellidos_perfil;
        private Label label_apellidos_perfil;
        private TextBox textBox_nombre_perfil;
        private Label label_nombre_perfil;
        private TextBox textBox_contrasena_perfil;
        private Label label_contrasena_perfil;
        private TextBox textBox_email_perfil;
        private Label label_email_perfil;
        private Button button_volver_perfil;
        private TabPage Estadisticas;
    }
}