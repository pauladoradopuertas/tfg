namespace TfgMultiplataforma.Paginas.Aministrador
{
    partial class AdminForm
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
            tabControl_usuario = new TabControl();
            tabPage_usuario_admin = new TabPage();
            button_borrar_usuario_admin = new Button();
            label_estado_admin = new Label();
            button_info_usuario_admin = new Button();
            listBox_usuarios_admin = new ListBox();
            comboBox_estado_admin = new ComboBox();
            label_usuario_nombre_equipo = new Label();
            tabPage_equipo_admin = new TabPage();
            button_unir_torneo = new Button();
            label_estado_torneo = new Label();
            button_unir_evento = new Button();
            button_info_torneo = new Button();
            listBox_torneos = new ListBox();
            comboBox_eventos = new ComboBox();
            label_usuarios_torneo = new Label();
            tabPage_torneo_admin = new TabPage();
            label1 = new Label();
            tabPage_crear_admin = new TabPage();
            label2 = new Label();
            tabControl_usuario.SuspendLayout();
            tabPage_usuario_admin.SuspendLayout();
            tabPage_equipo_admin.SuspendLayout();
            tabPage_torneo_admin.SuspendLayout();
            tabPage_crear_admin.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_usuario
            // 
            tabControl_usuario.Controls.Add(tabPage_usuario_admin);
            tabControl_usuario.Controls.Add(tabPage_equipo_admin);
            tabControl_usuario.Controls.Add(tabPage_torneo_admin);
            tabControl_usuario.Controls.Add(tabPage_crear_admin);
            tabControl_usuario.Location = new Point(2, 11);
            tabControl_usuario.Name = "tabControl_usuario";
            tabControl_usuario.SelectedIndex = 0;
            tabControl_usuario.Size = new Size(797, 429);
            tabControl_usuario.TabIndex = 1;
            // 
            // tabPage_usuario_admin
            // 
            tabPage_usuario_admin.Controls.Add(button_borrar_usuario_admin);
            tabPage_usuario_admin.Controls.Add(label_estado_admin);
            tabPage_usuario_admin.Controls.Add(button_info_usuario_admin);
            tabPage_usuario_admin.Controls.Add(listBox_usuarios_admin);
            tabPage_usuario_admin.Controls.Add(comboBox_estado_admin);
            tabPage_usuario_admin.Controls.Add(label_usuario_nombre_equipo);
            tabPage_usuario_admin.Location = new Point(4, 29);
            tabPage_usuario_admin.Name = "tabPage_usuario_admin";
            tabPage_usuario_admin.Padding = new Padding(3);
            tabPage_usuario_admin.Size = new Size(789, 396);
            tabPage_usuario_admin.TabIndex = 0;
            tabPage_usuario_admin.Text = "Usuarios";
            tabPage_usuario_admin.UseVisualStyleBackColor = true;
            // 
            // button_borrar_usuario_admin
            // 
            button_borrar_usuario_admin.Location = new Point(178, 322);
            button_borrar_usuario_admin.Name = "button_borrar_usuario_admin";
            button_borrar_usuario_admin.Size = new Size(103, 52);
            button_borrar_usuario_admin.TabIndex = 53;
            button_borrar_usuario_admin.Text = "Borrar";
            button_borrar_usuario_admin.UseVisualStyleBackColor = true;
            button_borrar_usuario_admin.Click += button_borrar_usuario_admin_Click;
            // 
            // label_estado_admin
            // 
            label_estado_admin.AutoSize = true;
            label_estado_admin.Font = new Font("Segoe UI", 15F);
            label_estado_admin.Location = new Point(29, 69);
            label_estado_admin.Name = "label_estado_admin";
            label_estado_admin.Size = new Size(90, 35);
            label_estado_admin.TabIndex = 52;
            label_estado_admin.Text = "Estado";
            // 
            // button_info_usuario_admin
            // 
            button_info_usuario_admin.Location = new Point(497, 322);
            button_info_usuario_admin.Name = "button_info_usuario_admin";
            button_info_usuario_admin.Size = new Size(103, 52);
            button_info_usuario_admin.TabIndex = 51;
            button_info_usuario_admin.Text = "Ver Información";
            button_info_usuario_admin.UseVisualStyleBackColor = true;
            button_info_usuario_admin.Click += button_info_usuario_admin_Click;
            // 
            // listBox_usuarios_admin
            // 
            listBox_usuarios_admin.Font = new Font("Segoe UI", 10F);
            listBox_usuarios_admin.FormattingEnabled = true;
            listBox_usuarios_admin.HorizontalScrollbar = true;
            listBox_usuarios_admin.ItemHeight = 23;
            listBox_usuarios_admin.Location = new Point(40, 138);
            listBox_usuarios_admin.Name = "listBox_usuarios_admin";
            listBox_usuarios_admin.Size = new Size(718, 165);
            listBox_usuarios_admin.TabIndex = 50;
            // 
            // comboBox_estado_admin
            // 
            comboBox_estado_admin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_estado_admin.Font = new Font("Segoe UI", 12F);
            comboBox_estado_admin.FormattingEnabled = true;
            comboBox_estado_admin.Location = new Point(151, 69);
            comboBox_estado_admin.Name = "comboBox_estado_admin";
            comboBox_estado_admin.Size = new Size(578, 36);
            comboBox_estado_admin.TabIndex = 49;
            // 
            // label_usuario_nombre_equipo
            // 
            label_usuario_nombre_equipo.AutoSize = true;
            label_usuario_nombre_equipo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label_usuario_nombre_equipo.Location = new Point(275, 16);
            label_usuario_nombre_equipo.Name = "label_usuario_nombre_equipo";
            label_usuario_nombre_equipo.Size = new Size(212, 35);
            label_usuario_nombre_equipo.TabIndex = 0;
            label_usuario_nombre_equipo.Text = "Lista de Usuarios";
            // 
            // tabPage_equipo_admin
            // 
            tabPage_equipo_admin.Controls.Add(button_unir_torneo);
            tabPage_equipo_admin.Controls.Add(label_estado_torneo);
            tabPage_equipo_admin.Controls.Add(button_unir_evento);
            tabPage_equipo_admin.Controls.Add(button_info_torneo);
            tabPage_equipo_admin.Controls.Add(listBox_torneos);
            tabPage_equipo_admin.Controls.Add(comboBox_eventos);
            tabPage_equipo_admin.Controls.Add(label_usuarios_torneo);
            tabPage_equipo_admin.Location = new Point(4, 29);
            tabPage_equipo_admin.Name = "tabPage_equipo_admin";
            tabPage_equipo_admin.Padding = new Padding(3);
            tabPage_equipo_admin.Size = new Size(789, 396);
            tabPage_equipo_admin.TabIndex = 1;
            tabPage_equipo_admin.Text = "Equipos";
            tabPage_equipo_admin.UseVisualStyleBackColor = true;
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
            comboBox_eventos.DropDownStyle = ComboBoxStyle.DropDownList;
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
            label_usuarios_torneo.Location = new Point(257, 15);
            label_usuarios_torneo.Name = "label_usuarios_torneo";
            label_usuarios_torneo.Size = new Size(204, 35);
            label_usuarios_torneo.TabIndex = 1;
            label_usuarios_torneo.Text = "Lista de Equipos";
            // 
            // tabPage_torneo_admin
            // 
            tabPage_torneo_admin.Controls.Add(label1);
            tabPage_torneo_admin.Location = new Point(4, 29);
            tabPage_torneo_admin.Name = "tabPage_torneo_admin";
            tabPage_torneo_admin.Padding = new Padding(3);
            tabPage_torneo_admin.Size = new Size(789, 396);
            tabPage_torneo_admin.TabIndex = 2;
            tabPage_torneo_admin.Text = "Torneos";
            tabPage_torneo_admin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(261, 23);
            label1.Name = "label1";
            label1.Size = new Size(205, 35);
            label1.TabIndex = 1;
            label1.Text = "Lista de Torneos";
            // 
            // tabPage_crear_admin
            // 
            tabPage_crear_admin.Controls.Add(label2);
            tabPage_crear_admin.Location = new Point(4, 29);
            tabPage_crear_admin.Name = "tabPage_crear_admin";
            tabPage_crear_admin.Padding = new Padding(3);
            tabPage_crear_admin.Size = new Size(789, 396);
            tabPage_crear_admin.TabIndex = 3;
            tabPage_crear_admin.Text = "Crear cuenta admin";
            tabPage_crear_admin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(235, 16);
            label2.Name = "label2";
            label2.Size = new Size(254, 35);
            label2.TabIndex = 1;
            label2.Text = "Crear Administrador";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl_usuario);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Load += AdminForm_Load;
            tabControl_usuario.ResumeLayout(false);
            tabPage_usuario_admin.ResumeLayout(false);
            tabPage_usuario_admin.PerformLayout();
            tabPage_equipo_admin.ResumeLayout(false);
            tabPage_equipo_admin.PerformLayout();
            tabPage_torneo_admin.ResumeLayout(false);
            tabPage_torneo_admin.PerformLayout();
            tabPage_crear_admin.ResumeLayout(false);
            tabPage_crear_admin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_usuario;
        private TabPage tabPage_usuario_admin;
        private Label label_usuario_nombre_equipo;
        private TabPage tabPage_equipo_admin;
        private Button button_unir_torneo;
        private Label label_estado_torneo;
        private Button button_unir_evento;
        private Button button_info_torneo;
        private ListBox listBox_torneos;
        private ComboBox comboBox_eventos;
        private Label label_usuarios_torneo;
        private TabPage tabPage_torneo_admin;
        private TabPage tabPage_crear_admin;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label_estado_admin;
        private Button button_info_usuario_admin;
        private ListBox listBox_usuarios_admin;
        private ComboBox comboBox_estado_admin;
        private Button button_borrar_usuario_admin;
    }
}