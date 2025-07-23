namespace CasaRobot.UI
{
    partial class FrmCrearUsuario
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
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panelContenedor = new Panel();
            iconRegistrate = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            cmbTipoUsuario = new ComboBox();
            lblTitleR = new Label();
            panelCrearUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRegistrate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCrearUsuario
            // 
            panelCrearUsuario.Anchor = AnchorStyles.None;
            panelCrearUsuario.BackColor = Color.White;
            panelCrearUsuario.BackgroundImageLayout = ImageLayout.None;
            panelCrearUsuario.Controls.Add(iconPictureBox2);
            panelCrearUsuario.Controls.Add(panelContenedor);
            panelCrearUsuario.Controls.Add(cmbTipoUsuario);
            panelCrearUsuario.Controls.Add(lblTitleR);
            panelCrearUsuario.ForeColor = Color.White;
            panelCrearUsuario.Location = new Point(42, 35);
            panelCrearUsuario.Name = "panelCrearUsuario";
            panelCrearUsuario.Size = new Size(701, 580);
            panelCrearUsuario.TabIndex = 14;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.FromArgb(255, 170, 200);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            iconPictureBox2.IconColor = Color.FromArgb(255, 170, 200);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 34;
            iconPictureBox2.Location = new Point(173, 112);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(34, 39);
            iconPictureBox2.TabIndex = 72;
            iconPictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenedor.Controls.Add(iconRegistrate);
            panelContenedor.Controls.Add(iconPictureBox1);
            panelContenedor.Location = new Point(80, 157);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(533, 370);
            panelContenedor.TabIndex = 71;
            // 
            // iconRegistrate
            // 
            iconRegistrate.BackColor = Color.White;
            iconRegistrate.ForeColor = Color.FromArgb(255, 170, 200);
            iconRegistrate.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            iconRegistrate.IconColor = Color.FromArgb(255, 170, 200);
            iconRegistrate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRegistrate.IconSize = 38;
            iconRegistrate.Location = new Point(244, 159);
            iconRegistrate.Name = "iconRegistrate";
            iconRegistrate.Size = new Size(38, 41);
            iconRegistrate.TabIndex = 65;
            iconRegistrate.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(255, 170, 215);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            iconPictureBox1.IconColor = Color.FromArgb(255, 170, 215);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 182;
            iconPictureBox1.Location = new Point(174, 102);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(186, 182);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.MaxDropDownItems = 2;
            cmbTipoUsuario.FlatStyle = FlatStyle.Flat;
            cmbTipoUsuario.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.IntegralHeight = false;
            cmbTipoUsuario.ItemHeight = 5;
            cmbTipoUsuario.Location = new Point(213, 112);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(255, 49);
            cmbTipoUsuario.TabIndex = 70;
            cmbTipoUsuario.SelectedIndexChanged += cmbTipoUsuario_SelectedIndexChanged;
            // 
            // lblTitleR
            // 
            lblTitleR.AutoSize = true;
            lblTitleR.Font = new Font("Sans Serif Collection", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleR.ForeColor = Color.FromArgb(255, 170, 215);
            lblTitleR.Location = new Point(153, 18);
            lblTitleR.Name = "lblTitleR";
            lblTitleR.Size = new Size(384, 91);
            lblTitleR.TabIndex = 66;
            lblTitleR.Text = "RELLENA EL FORMULARIO";
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 711);
            Controls.Add(panelCrearUsuario);
            Name = "FrmCrearUsuario";
            Text = "Registrate";
            panelCrearUsuario.ResumeLayout(false);
            panelCrearUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconRegistrate).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCrearUsuario;
        private Label lblTitleR;
        private ComboBox cmbTipoUsuario;
        private Panel panelContenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconRegistrate;
    }
}