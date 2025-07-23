namespace CasaRobot.UI
{
    partial class FrmIniciaSesion
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
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            btnnousar = new Button();
            BtnEntrarUsuario = new Button();
            txtUsuario = new TextBox();
            iconUsuario = new FontAwesome.Sharp.IconPictureBox();
            panelIniciar = new Panel();
            iconUser = new FontAwesome.Sharp.IconPictureBox();
            btn2nousar = new Button();
            linkLabel1 = new LinkLabel();
            no = new Button();
            txtContraseña = new TextBox();
            txtIngresarUsuario = new TextBox();
            btnIngresar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).BeginInit();
            panelIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnnousar);
            panel2.Controls.Add(BtnEntrarUsuario);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(iconUsuario);
            panel2.Enabled = false;
            panel2.ForeColor = Color.CornflowerBlue;
            panel2.Location = new Point(133, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Enabled = false;
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(64, 371);
            button1.Name = "button1";
            button1.Size = new Size(325, 2);
            button1.TabIndex = 47;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SkyBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.MidnightBlue;
            textBox1.Location = new Point(76, 330);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 43);
            textBox1.TabIndex = 46;
            textBox1.Text = "Contraseña";
            // 
            // btnnousar
            // 
            btnnousar.BackColor = Color.MidnightBlue;
            btnnousar.Enabled = false;
            btnnousar.ForeColor = Color.CornflowerBlue;
            btnnousar.Location = new Point(64, 305);
            btnnousar.Name = "btnnousar";
            btnnousar.Size = new Size(325, 2);
            btnnousar.TabIndex = 45;
            btnnousar.UseVisualStyleBackColor = false;
            // 
            // BtnEntrarUsuario
            // 
            BtnEntrarUsuario.BackColor = Color.SkyBlue;
            BtnEntrarUsuario.FlatStyle = FlatStyle.Flat;
            BtnEntrarUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEntrarUsuario.ForeColor = Color.MidnightBlue;
            BtnEntrarUsuario.Location = new Point(132, 420);
            BtnEntrarUsuario.Name = "BtnEntrarUsuario";
            BtnEntrarUsuario.Size = new Size(184, 44);
            BtnEntrarUsuario.TabIndex = 4;
            BtnEntrarUsuario.Text = "Iniciar";
            BtnEntrarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.SkyBlue;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.MidnightBlue;
            txtUsuario.Location = new Point(76, 264);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(274, 43);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            // 
            // iconUsuario
            // 
            iconUsuario.BackColor = Color.SkyBlue;
            iconUsuario.ForeColor = Color.MidnightBlue;
            iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconUsuario.IconColor = Color.MidnightBlue;
            iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsuario.IconSize = 184;
            iconUsuario.Location = new Point(147, 15);
            iconUsuario.Name = "iconUsuario";
            iconUsuario.Size = new Size(184, 212);
            iconUsuario.TabIndex = 1;
            iconUsuario.TabStop = false;
            // 
            // panelIniciar
            // 
            panelIniciar.Anchor = AnchorStyles.None;
            panelIniciar.BackColor = Color.White;
            panelIniciar.BackgroundImageLayout = ImageLayout.None;
            panelIniciar.Controls.Add(iconUser);
            panelIniciar.Controls.Add(btn2nousar);
            panelIniciar.Controls.Add(linkLabel1);
            panelIniciar.Controls.Add(no);
            panelIniciar.Controls.Add(txtContraseña);
            panelIniciar.Controls.Add(txtIngresarUsuario);
            panelIniciar.Controls.Add(btnIngresar);
            panelIniciar.Location = new Point(117, 25);
            panelIniciar.Name = "panelIniciar";
            panelIniciar.Size = new Size(405, 504);
            panelIniciar.TabIndex = 11;
            // 
            // iconUser
            // 
            iconUser.BackColor = Color.White;
            iconUser.ForeColor = Color.FromArgb(200, 170, 250);
            iconUser.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconUser.IconColor = Color.FromArgb(200, 170, 250);
            iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUser.IconSize = 144;
            iconUser.Location = new Point(134, 44);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(147, 144);
            iconUser.TabIndex = 12;
            iconUser.TabStop = false;
            // 
            // btn2nousar
            // 
            btn2nousar.BackColor = Color.MidnightBlue;
            btn2nousar.Enabled = false;
            btn2nousar.Location = new Point(34, 339);
            btn2nousar.Name = "btn2nousar";
            btn2nousar.Size = new Size(325, 2);
            btn2nousar.TabIndex = 11;
            btn2nousar.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ControlText;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(117, 452);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(164, 16);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste la Contraseña?";
            // 
            // no
            // 
            no.BackColor = Color.MidnightBlue;
            no.Enabled = false;
            no.Location = new Point(34, 260);
            no.Name = "no";
            no.Size = new Size(325, 2);
            no.TabIndex = 8;
            no.Text = "button1";
            no.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.MidnightBlue;
            txtContraseña.Location = new Point(38, 298);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(347, 43);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "Contraseña";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // txtIngresarUsuario
            // 
            txtIngresarUsuario.BackColor = Color.White;
            txtIngresarUsuario.BorderStyle = BorderStyle.None;
            txtIngresarUsuario.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIngresarUsuario.ForeColor = Color.MidnightBlue;
            txtIngresarUsuario.Location = new Point(38, 219);
            txtIngresarUsuario.Name = "txtIngresarUsuario";
            txtIngresarUsuario.Size = new Size(325, 43);
            txtIngresarUsuario.TabIndex = 1;
            txtIngresarUsuario.Text = "Usuario";
            txtIngresarUsuario.Enter += txtIngresarUsuario_Enter;
            txtIngresarUsuario.Leave += txtIngresarUsuario_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(200, 170, 250);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(134, 384);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(147, 40);
            btnIngresar.TabIndex = 3;
            btnIngresar.TabStop = false;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmIniciaSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(685, 541);
            Controls.Add(panelIniciar);
            Controls.Add(panel2);
            Name = "FrmIniciaSesion";
            Text = "Inicia Sesion";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).EndInit();
            panelIniciar.ResumeLayout(false);
            panelIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconUsuario;
        private Button BtnEntrarUsuario;
        private TextBox txtUsuario;
        private Button btnnousar;
        private Button button1;
        private TextBox textBox1;
        private Panel panelIniciar;
        private LinkLabel linkLabel1;
        private Button no;
        private TextBox txtContraseña;
        private TextBox txtIngresarUsuario;
        private Button btnIngresar;
        private Button btn2nousar;
        private FontAwesome.Sharp.IconPictureBox iconUser;
    }
}