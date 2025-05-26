namespace TfgMultiplataforma.Paginas.Usuarios
{
    partial class crearEquipo
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
            textBox_nombre_crear = new TextBox();
            button_cancelar_crear = new Button();
            button_editar_crear = new Button();
            comboBox_visible_crear = new ComboBox();
            label_visible_crear = new Label();
            button_anadir_crear = new Button();
            label_editar_nombre = new Label();
            listBox_miembros_crear = new ListBox();
            label_miembros_crear = new Label();
            label_nombre_crear = new Label();
            label_titulo_crear = new Label();
            SuspendLayout();
            // 
            // textBox_nombre_crear
            // 
            textBox_nombre_crear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_nombre_crear.BackColor = Color.White;
            textBox_nombre_crear.BorderStyle = BorderStyle.FixedSingle;
            textBox_nombre_crear.Cursor = Cursors.IBeam;
            textBox_nombre_crear.Font = new Font("Segoe UI", 15F);
            textBox_nombre_crear.Location = new Point(205, 142);
            textBox_nombre_crear.Name = "textBox_nombre_crear";
            textBox_nombre_crear.Size = new Size(777, 41);
            textBox_nombre_crear.TabIndex = 42;
            // 
            // button_cancelar_crear
            // 
            button_cancelar_crear.Anchor = AnchorStyles.Top;
            button_cancelar_crear.BackColor = Color.FromArgb(255, 0, 127);
            button_cancelar_crear.Cursor = Cursors.Hand;
            button_cancelar_crear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_cancelar_crear.Location = new Point(205, 605);
            button_cancelar_crear.Name = "button_cancelar_crear";
            button_cancelar_crear.Size = new Size(162, 72);
            button_cancelar_crear.TabIndex = 41;
            button_cancelar_crear.Text = "Cancelar";
            button_cancelar_crear.UseVisualStyleBackColor = false;
            button_cancelar_crear.Click += button_cancelar_crear_Click;
            // 
            // button_editar_crear
            // 
            button_editar_crear.Anchor = AnchorStyles.Top;
            button_editar_crear.BackColor = Color.DodgerBlue;
            button_editar_crear.Cursor = Cursors.Hand;
            button_editar_crear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_editar_crear.Location = new Point(672, 605);
            button_editar_crear.Name = "button_editar_crear";
            button_editar_crear.Size = new Size(164, 72);
            button_editar_crear.TabIndex = 40;
            button_editar_crear.Text = "Crear equipo";
            button_editar_crear.UseVisualStyleBackColor = false;
            button_editar_crear.Click += button_editar_crear_Click;
            // 
            // comboBox_visible_crear
            // 
            comboBox_visible_crear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_visible_crear.BackColor = Color.White;
            comboBox_visible_crear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_visible_crear.Font = new Font("Segoe UI", 15F);
            comboBox_visible_crear.FormattingEnabled = true;
            comboBox_visible_crear.Location = new Point(476, 502);
            comboBox_visible_crear.Name = "comboBox_visible_crear";
            comboBox_visible_crear.Size = new Size(506, 43);
            comboBox_visible_crear.TabIndex = 39;
            // 
            // label_visible_crear
            // 
            label_visible_crear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_visible_crear.AutoSize = true;
            label_visible_crear.Font = new Font("Segoe UI", 20F);
            label_visible_crear.ForeColor = Color.FromArgb(51, 51, 51);
            label_visible_crear.Location = new Point(26, 497);
            label_visible_crear.Name = "label_visible_crear";
            label_visible_crear.Size = new Size(436, 46);
            label_visible_crear.TabIndex = 38;
            label_visible_crear.Text = "Visible para otros jugadores";
            // 
            // button_anadir_crear
            // 
            button_anadir_crear.Anchor = AnchorStyles.Top;
            button_anadir_crear.BackColor = Color.Orange;
            button_anadir_crear.Cursor = Cursors.Hand;
            button_anadir_crear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_anadir_crear.Location = new Point(476, 389);
            button_anadir_crear.Name = "button_anadir_crear";
            button_anadir_crear.Size = new Size(137, 71);
            button_anadir_crear.TabIndex = 37;
            button_anadir_crear.Text = "Añadir miembro";
            button_anadir_crear.UseVisualStyleBackColor = false;
            button_anadir_crear.Click += button_anadir_crear_Click;
            // 
            // label_editar_nombre
            // 
            label_editar_nombre.AutoSize = true;
            label_editar_nombre.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label_editar_nombre.Location = new Point(339, -65);
            label_editar_nombre.Name = "label_editar_nombre";
            label_editar_nombre.Size = new Size(134, 35);
            label_editar_nombre.TabIndex = 36;
            label_editar_nombre.Text = "Mi Equipo";
            // 
            // listBox_miembros_crear
            // 
            listBox_miembros_crear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox_miembros_crear.BackColor = Color.White;
            listBox_miembros_crear.BorderStyle = BorderStyle.FixedSingle;
            listBox_miembros_crear.Font = new Font("Segoe UI", 15F);
            listBox_miembros_crear.FormattingEnabled = true;
            listBox_miembros_crear.ItemHeight = 35;
            listBox_miembros_crear.Location = new Point(205, 231);
            listBox_miembros_crear.Name = "listBox_miembros_crear";
            listBox_miembros_crear.Size = new Size(777, 142);
            listBox_miembros_crear.TabIndex = 35;
            // 
            // label_miembros_crear
            // 
            label_miembros_crear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_miembros_crear.AutoSize = true;
            label_miembros_crear.Font = new Font("Segoe UI", 20F);
            label_miembros_crear.ForeColor = Color.FromArgb(51, 51, 51);
            label_miembros_crear.Location = new Point(26, 231);
            label_miembros_crear.Name = "label_miembros_crear";
            label_miembros_crear.Size = new Size(172, 46);
            label_miembros_crear.TabIndex = 34;
            label_miembros_crear.Text = "Miembros";
            // 
            // label_nombre_crear
            // 
            label_nombre_crear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_nombre_crear.AutoSize = true;
            label_nombre_crear.Font = new Font("Segoe UI", 20F);
            label_nombre_crear.ForeColor = Color.FromArgb(51, 51, 51);
            label_nombre_crear.Location = new Point(26, 136);
            label_nombre_crear.Name = "label_nombre_crear";
            label_nombre_crear.Size = new Size(144, 46);
            label_nombre_crear.TabIndex = 33;
            label_nombre_crear.Text = "Nombre";
            // 
            // label_titulo_crear
            // 
            label_titulo_crear.Anchor = AnchorStyles.Top;
            label_titulo_crear.AutoSize = true;
            label_titulo_crear.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titulo_crear.ForeColor = Color.OliveDrab;
            label_titulo_crear.Location = new Point(331, 9);
            label_titulo_crear.Name = "label_titulo_crear";
            label_titulo_crear.Size = new Size(323, 67);
            label_titulo_crear.TabIndex = 43;
            label_titulo_crear.Text = "Crear Equipo";
            // 
            // crearEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1011, 701);
            Controls.Add(label_titulo_crear);
            Controls.Add(textBox_nombre_crear);
            Controls.Add(button_cancelar_crear);
            Controls.Add(button_editar_crear);
            Controls.Add(comboBox_visible_crear);
            Controls.Add(label_visible_crear);
            Controls.Add(button_anadir_crear);
            Controls.Add(label_editar_nombre);
            Controls.Add(listBox_miembros_crear);
            Controls.Add(label_miembros_crear);
            Controls.Add(label_nombre_crear);
            Name = "crearEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Equipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_nombre_crear;
        private Button button_cancelar_crear;
        private Button button_editar_crear;
        private ComboBox comboBox_visible_crear;
        private Label label_visible_crear;
        private Button button_anadir_crear;
        private Label label_editar_nombre;
        private ListBox listBox_miembros_crear;
        private Label label_miembros_crear;
        private Label label_nombre_crear;
        private Label label_titulo_crear;
    }
}