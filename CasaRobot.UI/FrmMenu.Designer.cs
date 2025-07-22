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
            panelMenu = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnCrearUsuario = new FontAwesome.Sharp.IconButton();
            btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CornflowerBlue;
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(btnIngresar);
            panelMenu.Controls.Add(btnCrearUsuario);
            panelMenu.Controls.Add(btnIniciarSesion);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassDollar;
            iconButton4.IconColor = Color.MidnightBlue;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 40;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 320);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(220, 60);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "Buscar Equipos";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += this.iconButton4_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Dock = DockStyle.Top;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnIngresar.IconColor = Color.MidnightBlue;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 40;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(0, 260);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(220, 60);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar Equipos";
            btnIngresar.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Dock = DockStyle.Top;
            btnCrearUsuario.FlatAppearance.BorderSize = 0;
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnCrearUsuario.IconColor = Color.MidnightBlue;
            btnCrearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearUsuario.IconSize = 40;
            btnCrearUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.Location = new Point(0, 200);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(220, 60);
            btnCrearUsuario.TabIndex = 2;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Dock = DockStyle.Top;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnIniciarSesion.IconColor = Color.MidnightBlue;
            btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIniciarSesion.IconSize = 40;
            btnIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.Location = new Point(0, 140);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(220, 60);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 140);
            panel1.TabIndex = 0;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "FrmMenu";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCrearUsuario;
    }
}
