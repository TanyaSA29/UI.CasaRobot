namespace CasaRobot.UI.Vista
{
    partial class FrmCrearCliente
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
            panelCrearUsuario = new Panel();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            txtDireccion = new TextBox();
            panelCrearUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panelCrearUsuario
            // 
            panelCrearUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCrearUsuario.BackColor = Color.White;
            panelCrearUsuario.BackgroundImageLayout = ImageLayout.None;
            panelCrearUsuario.Controls.Add(button2);
            panelCrearUsuario.Controls.Add(button4);
            panelCrearUsuario.Controls.Add(button3);
            panelCrearUsuario.Controls.Add(button1);
            panelCrearUsuario.Controls.Add(txtTelefono);
            panelCrearUsuario.Controls.Add(txtCorreo);
            panelCrearUsuario.Controls.Add(txtNombre);
            panelCrearUsuario.Controls.Add(btnRegistrar);
            panelCrearUsuario.Controls.Add(txtDireccion);
            panelCrearUsuario.ForeColor = Color.White;
            panelCrearUsuario.Location = new Point(-5, -14);
            panelCrearUsuario.Name = "panelCrearUsuario";
            panelCrearUsuario.Size = new Size(542, 388);
            panelCrearUsuario.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Enabled = false;
            button2.Location = new Point(48, 53);
            button2.Name = "button2";
            button2.Size = new Size(450, 10);
            button2.TabIndex = 69;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.Enabled = false;
            button4.Location = new Point(48, 154);
            button4.Name = "button4";
            button4.Size = new Size(450, 11);
            button4.TabIndex = 62;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.Enabled = false;
            button3.Location = new Point(48, 200);
            button3.Name = "button3";
            button3.Size = new Size(450, 11);
            button3.TabIndex = 61;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Enabled = false;
            button1.Location = new Point(48, 108);
            button1.Name = "button1";
            button1.Size = new Size(450, 11);
            button1.TabIndex = 59;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.MidnightBlue;
            txtTelefono.Location = new Point(54, 116);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(269, 40);
            txtTelefono.TabIndex = 57;
            txtTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.MidnightBlue;
            txtCorreo.Location = new Point(54, 70);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(539, 40);
            txtCorreo.TabIndex = 54;
            txtCorreo.Text = "Correo";
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Sans Serif Collection", 11.25F);
            txtNombre.ForeColor = Color.MidnightBlue;
            txtNombre.Location = new Point(54, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 40);
            txtNombre.TabIndex = 52;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.FromArgb(255, 170, 200);
            btnRegistrar.Location = new Point(138, 273);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(227, 46);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.White;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.ForeColor = Color.MidnightBlue;
            txtDireccion.Location = new Point(54, 162);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(444, 40);
            txtDireccion.TabIndex = 67;
            txtDireccion.Text = "Direccion";
            txtDireccion.Enter += txtDireccion_Enter;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // FrmCrearCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 331);
            Controls.Add(panelCrearUsuario);
            Name = "FrmCrearCliente";
            Text = "FrmCliente";
            panelCrearUsuario.ResumeLayout(false);
            panelCrearUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCrearUsuario;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button1;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private TextBox txtDireccion;
    }
}