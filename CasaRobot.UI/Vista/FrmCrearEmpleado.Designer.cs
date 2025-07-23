namespace CasaRobot.UI.Vista
{
    partial class FrmCrearEmpleado
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
            btn2nousar = new Button();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            txtClave = new TextBox();
            txtCargo = new TextBox();
            txtNombreUsuario = new TextBox();
            panelCrearUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panelCrearUsuario
            // 
            panelCrearUsuario.Anchor = AnchorStyles.None;
            panelCrearUsuario.BackColor = Color.White;
            panelCrearUsuario.BackgroundImageLayout = ImageLayout.None;
            panelCrearUsuario.Controls.Add(button2);
            panelCrearUsuario.Controls.Add(button4);
            panelCrearUsuario.Controls.Add(button3);
            panelCrearUsuario.Controls.Add(button1);
            panelCrearUsuario.Controls.Add(btn2nousar);
            panelCrearUsuario.Controls.Add(txtTelefono);
            panelCrearUsuario.Controls.Add(txtNombre);
            panelCrearUsuario.Controls.Add(btnRegistrar);
            panelCrearUsuario.Controls.Add(txtClave);
            panelCrearUsuario.Controls.Add(txtCargo);
            panelCrearUsuario.Controls.Add(txtNombreUsuario);
            panelCrearUsuario.ForeColor = Color.White;
            panelCrearUsuario.Location = new Point(1, 0);
            panelCrearUsuario.Name = "panelCrearUsuario";
            panelCrearUsuario.Size = new Size(533, 370);
            panelCrearUsuario.TabIndex = 15;
            panelCrearUsuario.Paint += panelCrearUsuario_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Enabled = false;
            button2.Location = new Point(48, 53);
            button2.Name = "button2";
            button2.Size = new Size(400, 2);
            button2.TabIndex = 69;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.Enabled = false;
            button4.Location = new Point(48, 200);
            button4.Name = "button4";
            button4.Size = new Size(400, 2);
            button4.TabIndex = 62;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.Enabled = false;
            button3.Location = new Point(48, 248);
            button3.Name = "button3";
            button3.Size = new Size(400, 2);
            button3.TabIndex = 61;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Enabled = false;
            button1.Location = new Point(48, 154);
            button1.Name = "button1";
            button1.Size = new Size(400, 2);
            button1.TabIndex = 59;
            button1.UseVisualStyleBackColor = false;
            // 
            // btn2nousar
            // 
            btn2nousar.BackColor = Color.MidnightBlue;
            btn2nousar.Enabled = false;
            btn2nousar.Location = new Point(48, 108);
            btn2nousar.Name = "btn2nousar";
            btn2nousar.Size = new Size(400, 2);
            btn2nousar.TabIndex = 58;
            btn2nousar.UseVisualStyleBackColor = false;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.MidnightBlue;
            txtTelefono.Location = new Point(54, 116);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(360, 40);
            txtTelefono.TabIndex = 57;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Sans Serif Collection", 11.25F);
            txtNombre.ForeColor = Color.MidnightBlue;
            txtNombre.Location = new Point(54, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(381, 40);
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
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Sans Serif Collection", 11.25F);
            txtClave.ForeColor = Color.MidnightBlue;
            txtClave.Location = new Point(54, 210);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(255, 40);
            txtClave.TabIndex = 70;
            txtClave.Text = "Clave";
            txtClave.Enter += txtClave_Enter;
            txtClave.Leave += txtClave_Leave;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.White;
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Font = new Font("Sans Serif Collection", 11.25F);
            txtCargo.ForeColor = Color.MidnightBlue;
            txtCargo.Location = new Point(54, 70);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(381, 40);
            txtCargo.TabIndex = 71;
            txtCargo.Text = "Cargo";
            txtCargo.Enter += txtCargo_Enter;
            txtCargo.Leave += txtCargo_Leave;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.ForeColor = Color.MidnightBlue;
            txtNombreUsuario.Location = new Point(54, 162);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(381, 40);
            txtNombreUsuario.TabIndex = 67;
            txtNombreUsuario.Text = "Nombre de Usuario";
            txtNombreUsuario.Enter += txtNombreUsuario_Enter;
            txtNombreUsuario.Leave += txtNombreUsuario_Leave;
            // 
            // FrmCrearEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 331);
            Controls.Add(panelCrearUsuario);
            Name = "FrmCrearEmpleado";
            Text = "FrmEmpleado";
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
        private Button btn2nousar;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private TextBox txtNombreUsuario;
        private TextBox txtClave;
        private TextBox txtCargo;
    }
}