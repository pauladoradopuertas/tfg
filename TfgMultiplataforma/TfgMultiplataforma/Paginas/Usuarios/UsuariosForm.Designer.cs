namespace TfgMultiplataforma.Paginas.Usuarios
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            tabControl_usuario = new TabControl();
            tabPage_usuario_equipo = new TabPage();
            listBox_miembros = new ListBox();
            button_abandonar_equipo = new Button();
            button_editar_equipo = new Button();
            label_miembros_equipo = new Label();
            textBox_nombre_equipo = new TextBox();
            label_nombre_equipo = new Label();
            label_usuario_nombre_equipo = new Label();
            tabPage_usuario_eventos = new TabPage();
            button_unir_torneo = new Button();
            label_estado_torneo = new Label();
            button_info_torneo = new Button();
            listBox_torneos = new ListBox();
            comboBox_eventos = new ComboBox();
            label_usuarios_torneo = new Label();
            button_ver_perfil = new Button();
            tabControl_usuario.SuspendLayout();
            tabPage_usuario_equipo.SuspendLayout();
            tabPage_usuario_eventos.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_usuario
            // 
            tabControl_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_usuario.Controls.Add(tabPage_usuario_equipo);
            tabControl_usuario.Controls.Add(tabPage_usuario_eventos);
            tabControl_usuario.Font = new Font("Segoe UI", 12F);
            tabControl_usuario.Location = new Point(3, 55);
            tabControl_usuario.Name = "tabControl_usuario";
            tabControl_usuario.SelectedIndex = 0;
            tabControl_usuario.Size = new Size(945, 662);
            tabControl_usuario.TabIndex = 0;
            // 
            // tabPage_usuario_equipo
            // 
            tabPage_usuario_equipo.BackColor = Color.White;
            tabPage_usuario_equipo.Controls.Add(listBox_miembros);
            tabPage_usuario_equipo.Controls.Add(button_abandonar_equipo);
            tabPage_usuario_equipo.Controls.Add(button_editar_equipo);
            tabPage_usuario_equipo.Controls.Add(label_miembros_equipo);
            tabPage_usuario_equipo.Controls.Add(textBox_nombre_equipo);
            tabPage_usuario_equipo.Controls.Add(label_nombre_equipo);
            tabPage_usuario_equipo.Controls.Add(label_usuario_nombre_equipo);
            tabPage_usuario_equipo.Location = new Point(4, 37);
            tabPage_usuario_equipo.Name = "tabPage_usuario_equipo";
            tabPage_usuario_equipo.Padding = new Padding(3);
            tabPage_usuario_equipo.Size = new Size(937, 621);
            tabPage_usuario_equipo.TabIndex = 0;
            tabPage_usuario_equipo.Text = "Equipo";
            // 
            // listBox_miembros
            // 
            listBox_miembros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox_miembros.BackColor = Color.White;
            listBox_miembros.BorderStyle = BorderStyle.FixedSingle;
            listBox_miembros.Cursor = Cursors.IBeam;
            listBox_miembros.Font = new Font("Segoe UI", 15F);
            listBox_miembros.FormattingEnabled = true;
            listBox_miembros.ItemHeight = 35;
            listBox_miembros.Location = new Point(200, 271);
            listBox_miembros.Name = "listBox_miembros";
            listBox_miembros.Size = new Size(706, 142);
            listBox_miembros.TabIndex = 19;
            // 
            // button_abandonar_equipo
            // 
            button_abandonar_equipo.Anchor = AnchorStyles.Top;
            button_abandonar_equipo.BackColor = Color.DodgerBlue;
            button_abandonar_equipo.Cursor = Cursors.Hand;
            button_abandonar_equipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_abandonar_equipo.Location = new Point(200, 524);
            button_abandonar_equipo.Name = "button_abandonar_equipo";
            button_abandonar_equipo.Size = new Size(180, 74);
            button_abandonar_equipo.TabIndex = 18;
            button_abandonar_equipo.Text = "Abandonar equipo";
            button_abandonar_equipo.UseVisualStyleBackColor = false;
            button_abandonar_equipo.Click += button_abandonar_equipo_Click;
            // 
            // button_editar_equipo
            // 
            button_editar_equipo.Anchor = AnchorStyles.Top;
            button_editar_equipo.BackColor = Color.DodgerBlue;
            button_editar_equipo.Cursor = Cursors.Hand;
            button_editar_equipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_editar_equipo.Location = new Point(716, 524);
            button_editar_equipo.Name = "button_editar_equipo";
            button_editar_equipo.Size = new Size(180, 74);
            button_editar_equipo.TabIndex = 17;
            button_editar_equipo.Text = "Editar equipo";
            button_editar_equipo.UseVisualStyleBackColor = false;
            button_editar_equipo.Click += button_editar_equipo_Click;
            // 
            // label_miembros_equipo
            // 
            label_miembros_equipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_miembros_equipo.AutoSize = true;
            label_miembros_equipo.Font = new Font("Segoe UI", 20F);
            label_miembros_equipo.ForeColor = Color.FromArgb(51, 51, 51);
            label_miembros_equipo.Location = new Point(3, 271);
            label_miembros_equipo.Name = "label_miembros_equipo";
            label_miembros_equipo.Size = new Size(172, 46);
            label_miembros_equipo.TabIndex = 10;
            label_miembros_equipo.Text = "Miembros";
            // 
            // textBox_nombre_equipo
            // 
            textBox_nombre_equipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_nombre_equipo.BackColor = Color.White;
            textBox_nombre_equipo.BorderStyle = BorderStyle.FixedSingle;
            textBox_nombre_equipo.Cursor = Cursors.IBeam;
            textBox_nombre_equipo.Enabled = false;
            textBox_nombre_equipo.Font = new Font("Segoe UI", 15F);
            textBox_nombre_equipo.Location = new Point(200, 150);
            textBox_nombre_equipo.Name = "textBox_nombre_equipo";
            textBox_nombre_equipo.Size = new Size(706, 41);
            textBox_nombre_equipo.TabIndex = 9;
            // 
            // label_nombre_equipo
            // 
            label_nombre_equipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_nombre_equipo.AutoSize = true;
            label_nombre_equipo.Font = new Font("Segoe UI", 20F);
            label_nombre_equipo.ForeColor = Color.FromArgb(51, 51, 51);
            label_nombre_equipo.Location = new Point(6, 150);
            label_nombre_equipo.Name = "label_nombre_equipo";
            label_nombre_equipo.Size = new Size(144, 46);
            label_nombre_equipo.TabIndex = 8;
            label_nombre_equipo.Text = "Nombre";
            // 
            // label_usuario_nombre_equipo
            // 
            label_usuario_nombre_equipo.Anchor = AnchorStyles.Top;
            label_usuario_nombre_equipo.AutoSize = true;
            label_usuario_nombre_equipo.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_usuario_nombre_equipo.ForeColor = Color.OliveDrab;
            label_usuario_nombre_equipo.Location = new Point(316, 19);
            label_usuario_nombre_equipo.Name = "label_usuario_nombre_equipo";
            label_usuario_nombre_equipo.Size = new Size(260, 67);
            label_usuario_nombre_equipo.TabIndex = 0;
            label_usuario_nombre_equipo.Text = "Mi Equipo";
            // 
            // tabPage_usuario_eventos
            // 
            tabPage_usuario_eventos.BackColor = Color.White;
            tabPage_usuario_eventos.Controls.Add(button_unir_torneo);
            tabPage_usuario_eventos.Controls.Add(label_estado_torneo);
            tabPage_usuario_eventos.Controls.Add(button_info_torneo);
            tabPage_usuario_eventos.Controls.Add(listBox_torneos);
            tabPage_usuario_eventos.Controls.Add(comboBox_eventos);
            tabPage_usuario_eventos.Controls.Add(label_usuarios_torneo);
            tabPage_usuario_eventos.Location = new Point(4, 37);
            tabPage_usuario_eventos.Name = "tabPage_usuario_eventos";
            tabPage_usuario_eventos.Padding = new Padding(3);
            tabPage_usuario_eventos.Size = new Size(937, 621);
            tabPage_usuario_eventos.TabIndex = 1;
            tabPage_usuario_eventos.Text = "Torneos";
            // 
            // button_unir_torneo
            // 
            button_unir_torneo.Anchor = AnchorStyles.Top;
            button_unir_torneo.BackColor = Color.DodgerBlue;
            button_unir_torneo.Cursor = Cursors.Hand;
            button_unir_torneo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_unir_torneo.Location = new Point(253, 518);
            button_unir_torneo.Name = "button_unir_torneo";
            button_unir_torneo.Size = new Size(151, 79);
            button_unir_torneo.TabIndex = 48;
            button_unir_torneo.Text = "Unirme a un torneo";
            button_unir_torneo.UseVisualStyleBackColor = false;
            button_unir_torneo.Click += button_unir_torneo_Click;
            // 
            // label_estado_torneo
            // 
            label_estado_torneo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_estado_torneo.AutoSize = true;
            label_estado_torneo.Font = new Font("Segoe UI", 20F);
            label_estado_torneo.ForeColor = Color.FromArgb(51, 51, 51);
            label_estado_torneo.Location = new Point(22, 141);
            label_estado_torneo.Name = "label_estado_torneo";
            label_estado_torneo.Size = new Size(120, 46);
            label_estado_torneo.TabIndex = 47;
            label_estado_torneo.Text = "Estado";
            // 
            // button_info_torneo
            // 
            button_info_torneo.Anchor = AnchorStyles.Top;
            button_info_torneo.BackColor = Color.DodgerBlue;
            button_info_torneo.Cursor = Cursors.Hand;
            button_info_torneo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_info_torneo.Location = new Point(556, 518);
            button_info_torneo.Name = "button_info_torneo";
            button_info_torneo.Size = new Size(151, 79);
            button_info_torneo.TabIndex = 4;
            button_info_torneo.Text = "Ver Información";
            button_info_torneo.UseVisualStyleBackColor = false;
            // 
            // listBox_torneos
            // 
            listBox_torneos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox_torneos.BackColor = Color.White;
            listBox_torneos.BorderStyle = BorderStyle.FixedSingle;
            listBox_torneos.Cursor = Cursors.Hand;
            listBox_torneos.Font = new Font("Segoe UI", 15F);
            listBox_torneos.FormattingEnabled = true;
            listBox_torneos.HorizontalScrollbar = true;
            listBox_torneos.ItemHeight = 35;
            listBox_torneos.Location = new Point(33, 249);
            listBox_torneos.Name = "listBox_torneos";
            listBox_torneos.Size = new Size(866, 177);
            listBox_torneos.TabIndex = 3;
            listBox_torneos.SelectedIndexChanged += listBox_torneos_SelectedIndexChanged;
            // 
            // comboBox_eventos
            // 
            comboBox_eventos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_eventos.BackColor = Color.White;
            comboBox_eventos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_eventos.Font = new Font("Segoe UI", 15F);
            comboBox_eventos.FormattingEnabled = true;
            comboBox_eventos.Location = new Point(173, 141);
            comboBox_eventos.Name = "comboBox_eventos";
            comboBox_eventos.Size = new Size(726, 43);
            comboBox_eventos.TabIndex = 2;
            comboBox_eventos.SelectedIndexChanged += comboBox_eventos_SelectedIndexChanged;
            // 
            // label_usuarios_torneo
            // 
            label_usuarios_torneo.Anchor = AnchorStyles.Top;
            label_usuarios_torneo.AutoSize = true;
            label_usuarios_torneo.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_usuarios_torneo.ForeColor = Color.OliveDrab;
            label_usuarios_torneo.Location = new Point(352, 18);
            label_usuarios_torneo.Name = "label_usuarios_torneo";
            label_usuarios_torneo.Size = new Size(209, 67);
            label_usuarios_torneo.TabIndex = 1;
            label_usuarios_torneo.Text = "Torneos";
            // 
            // button_ver_perfil
            // 
            button_ver_perfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_ver_perfil.BackColor = Color.Orange;
            button_ver_perfil.BackgroundImage = (Image)resources.GetObject("button_ver_perfil.BackgroundImage");
            button_ver_perfil.BackgroundImageLayout = ImageLayout.Stretch;
            button_ver_perfil.Cursor = Cursors.Hand;
            button_ver_perfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_ver_perfil.Location = new Point(871, 12);
            button_ver_perfil.Name = "button_ver_perfil";
            button_ver_perfil.Size = new Size(77, 80);
            button_ver_perfil.TabIndex = 18;
            button_ver_perfil.UseVisualStyleBackColor = false;
            button_ver_perfil.Click += button_ver_perfil_Click;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(960, 729);
            Controls.Add(button_ver_perfil);
            Controls.Add(tabControl_usuario);
            Name = "UsuariosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += UsuariosForm_Load;
            tabControl_usuario.ResumeLayout(false);
            tabPage_usuario_equipo.ResumeLayout(false);
            tabPage_usuario_equipo.PerformLayout();
            tabPage_usuario_eventos.ResumeLayout(false);
            tabPage_usuario_eventos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_usuario;
        private TabPage tabPage_usuario_equipo;
        private Label label_usuario_nombre_equipo;
        private TabPage tabPage_usuario_eventos;
        private TextBox textBox_rol2;
        private TextBox textBox_miembro2;
        private Label label_miembros_equipo;
        private TextBox textBox_nombre_equipo;
        private Label label_nombre_equipo;
        private Button button_abandonar_equipo;
        private Button button_editar_equipo;
        private Label label_usuarios_torneo;
        private ComboBox comboBox_eventos;
        private Button button_info_torneo;
        private ListBox listBox_torneos;
        private ListBox listBox_miembros;
        private Label label_estado_torneo;
        private Button button_unir_torneo;
        private Button button_ver_perfil;
    }
}