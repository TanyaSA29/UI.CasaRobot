namespace CasaRobot.UI
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelMenu = new Panel();
            btnBuscarEquipos = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnCrearUsuario = new FontAwesome.Sharp.IconButton();
            btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnLogo = new PictureBox();
            panelBarra = new Panel();
            iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            iconMaximizar = new FontAwesome.Sharp.IconPictureBox();
            iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            IconoCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelSombra = new Panel();
            panelDesktop = new Panel();
            label2 = new Label();
            lblVision = new Label();
            LblContenido = new Label();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogo).BeginInit();
            panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconoCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CornflowerBlue;
            panelMenu.Controls.Add(btnBuscarEquipos);
            panelMenu.Controls.Add(btnIngresar);
            panelMenu.Controls.Add(btnCrearUsuario);
            panelMenu.Controls.Add(btnIniciarSesion);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 659);
            panelMenu.TabIndex = 0;
            // 
            // btnBuscarEquipos
            // 
            btnBuscarEquipos.Dock = DockStyle.Top;
            btnBuscarEquipos.FlatAppearance.BorderSize = 0;
            btnBuscarEquipos.FlatStyle = FlatStyle.Flat;
            btnBuscarEquipos.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarEquipos.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarEquipos.IconColor = Color.MidnightBlue;
            btnBuscarEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarEquipos.IconSize = 40;
            btnBuscarEquipos.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarEquipos.Location = new Point(0, 320);
            btnBuscarEquipos.Name = "btnBuscarEquipos";
            btnBuscarEquipos.Padding = new Padding(10, 0, 0, 0);
            btnBuscarEquipos.Size = new Size(220, 60);
            btnBuscarEquipos.TabIndex = 4;
            btnBuscarEquipos.Text = "Buscar Equipos";
            btnBuscarEquipos.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarEquipos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarEquipos.UseVisualStyleBackColor = true;
            btnBuscarEquipos.Click += btnBuscarEquipos_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Dock = DockStyle.Top;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnIngresar.IconColor = Color.MidnightBlue;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 40;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(0, 260);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Padding = new Padding(10, 0, 0, 0);
            btnIngresar.Size = new Size(220, 60);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar Equipos";
            btnIngresar.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Dock = DockStyle.Top;
            btnCrearUsuario.FlatAppearance.BorderSize = 0;
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnCrearUsuario.IconColor = Color.MidnightBlue;
            btnCrearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearUsuario.IconSize = 40;
            btnCrearUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.Location = new Point(0, 200);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Padding = new Padding(10, 0, 0, 0);
            btnCrearUsuario.Size = new Size(220, 60);
            btnCrearUsuario.TabIndex = 2;
            btnCrearUsuario.Text = "Registrate";
            btnCrearUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Dock = DockStyle.Top;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnIniciarSesion.IconColor = Color.MidnightBlue;
            btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIniciarSesion.IconSize = 40;
            btnIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.Location = new Point(0, 140);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Padding = new Padding(10, 0, 0, 0);
            btnIniciarSesion.Size = new Size(220, 60);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(100, 149, 250);
            panelLogo.Controls.Add(btnLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            btnLogo.Image = (Image)resources.GetObject("btnLogo.Image");
            btnLogo.Location = new Point(52, 23);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(99, 80);
            btnLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogo.TabIndex = 0;
            btnLogo.TabStop = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // panelBarra
            // 
            panelBarra.BackColor = Color.FromArgb(100, 139, 230);
            panelBarra.Controls.Add(iconCerrar);
            panelBarra.Controls.Add(iconMaximizar);
            panelBarra.Controls.Add(iconMinimizar);
            panelBarra.Controls.Add(lblTitleChildForm);
            panelBarra.Controls.Add(IconoCurrentChildForm);
            panelBarra.Dock = DockStyle.Top;
            panelBarra.Location = new Point(220, 0);
            panelBarra.Name = "panelBarra";
            panelBarra.Size = new Size(701, 70);
            panelBarra.TabIndex = 1;
            panelBarra.MouseDown += panelBarra_MouseDown;
            // 
            // iconCerrar
            // 
            iconCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconCerrar.BackColor = Color.FromArgb(100, 139, 215);
            iconCerrar.ForeColor = SystemColors.ControlText;
            iconCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            iconCerrar.IconColor = SystemColors.ControlText;
            iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCerrar.IconSize = 22;
            iconCerrar.Location = new Point(679, 0);
            iconCerrar.Margin = new Padding(0);
            iconCerrar.Name = "iconCerrar";
            iconCerrar.Size = new Size(22, 22);
            iconCerrar.TabIndex = 4;
            iconCerrar.TabStop = false;
            iconCerrar.Click += iconCerrar_Click;
            // 
            // iconMaximizar
            // 
            iconMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaximizar.BackColor = Color.FromArgb(100, 139, 215);
            iconMaximizar.ForeColor = SystemColors.ControlText;
            iconMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            iconMaximizar.IconColor = SystemColors.ControlText;
            iconMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMaximizar.IconSize = 22;
            iconMaximizar.Location = new Point(656, 0);
            iconMaximizar.Margin = new Padding(0);
            iconMaximizar.Name = "iconMaximizar";
            iconMaximizar.Size = new Size(22, 22);
            iconMaximizar.TabIndex = 3;
            iconMaximizar.TabStop = false;
            iconMaximizar.Click += iconMaximizar_Click;
            // 
            // iconMinimizar
            // 
            iconMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimizar.BackColor = Color.FromArgb(100, 139, 215);
            iconMinimizar.ForeColor = SystemColors.InfoText;
            iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconMinimizar.IconColor = SystemColors.InfoText;
            iconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimizar.IconSize = 22;
            iconMinimizar.Location = new Point(632, 0);
            iconMinimizar.Margin = new Padding(0);
            iconMinimizar.Name = "iconMinimizar";
            iconMinimizar.Size = new Size(22, 22);
            iconMinimizar.TabIndex = 2;
            iconMinimizar.TabStop = false;
            iconMinimizar.Click += iconMinimizar_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleChildForm.Location = new Point(83, 23);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(51, 44);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Inicio";
            // 
            // IconoCurrentChildForm
            // 
            IconoCurrentChildForm.BackColor = Color.FromArgb(100, 139, 230);
            IconoCurrentChildForm.ForeColor = Color.MidnightBlue;
            IconoCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            IconoCurrentChildForm.IconColor = Color.MidnightBlue;
            IconoCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoCurrentChildForm.Location = new Point(45, 23);
            IconoCurrentChildForm.Name = "IconoCurrentChildForm";
            IconoCurrentChildForm.Size = new Size(32, 32);
            IconoCurrentChildForm.TabIndex = 0;
            IconoCurrentChildForm.TabStop = false;
            // 
            // panelSombra
            // 
            panelSombra.BackColor = Color.FromArgb(100, 139, 220);
            panelSombra.Dock = DockStyle.Top;
            panelSombra.Location = new Point(220, 70);
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(701, 9);
            panelSombra.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(label1);
            panelDesktop.Controls.Add(label2);
            panelDesktop.Controls.Add(lblVision);
            panelDesktop.Controls.Add(LblContenido);
            panelDesktop.Location = new Point(220, 79);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(701, 580);
            panelDesktop.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(245, 250, 255);
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 49);
            label2.Name = "label2";
            label2.Size = new Size(215, 72);
            label2.TabIndex = 4;
            label2.Text = "¿Quienes Somos?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVision
            // 
            lblVision.Anchor = AnchorStyles.None;
            lblVision.AutoSize = true;
            lblVision.BackColor = Color.FromArgb(249, 250, 255);
            lblVision.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVision.Location = new Point(22, 279);
            lblVision.Margin = new Padding(0);
            lblVision.Name = "lblVision";
            lblVision.Size = new Size(382, 132);
            lblVision.TabIndex = 0;
            lblVision.Text = "        VISION\r\nSer una empresa confiable y reconocida por nuestra eficiencia,\r\n compromiso y atención cercana.";
            lblVision.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblContenido
            // 
            LblContenido.Anchor = AnchorStyles.None;
            LblContenido.AutoSize = true;
            LblContenido.BackColor = Color.FromArgb(245, 250, 255);
            LblContenido.FlatStyle = FlatStyle.Popup;
            LblContenido.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContenido.Location = new Point(51, 121);
            LblContenido.Margin = new Padding(0);
            LblContenido.Name = "LblContenido";
            LblContenido.Size = new Size(638, 102);
            LblContenido.TabIndex = 0;
            LblContenido.Text = "Somos una empresa local especializada en el mantenimiento y reparación de computadoras.\r\n Ofrecemos soluciones rápidas, confiables y personalizadas para hogares y negocios.";
            LblContenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(249, 255, 255);
            label1.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 423);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(393, 132);
            label1.TabIndex = 5;
            label1.Text = "        MISION  \r\nBrindar servicios técnicos de calidad que mejoren el rendimiento\r\n y vida útil de los equipos de nuestros clientes..";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(921, 659);
            Controls.Add(panelDesktop);
            Controls.Add(panelSombra);
            Controls.Add(panelBarra);
            Controls.Add(panelMenu);
            Name = "FrmMenu";
            Text = "Menu";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnLogo).EndInit();
            panelBarra.ResumeLayout(false);
            panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconoCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscarEquipos;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCrearUsuario;
        private Panel panelBarra;
        private FontAwesome.Sharp.IconPictureBox IconoCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelLogo;
        private PictureBox btnLogo;
        private Panel panelSombra;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private FontAwesome.Sharp.IconPictureBox iconMaximizar;
        private Label LblContenido;
        private Label label2;
        private Label lblVision;
        private Label label1;
    }
}
