namespace XYZ_Sağlıklı_Yaşam_Merkezi
{
    partial class FormParolaDegistir
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
            this.lblEskiParola = new System.Windows.Forms.Label();
            this.lblYeniParolaTekrar = new System.Windows.Forms.Label();
            this.lblYeniParola = new System.Windows.Forms.Label();
            this.btnDegistir = new Guna.UI2.WinForms.Guna2Button();
            this.checkShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtYeniSifreTekrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblEskiParola
            // 
            this.lblEskiParola.AutoSize = true;
            this.lblEskiParola.BackColor = System.Drawing.Color.Transparent;
            this.lblEskiParola.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEskiParola.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEskiParola.Location = new System.Drawing.Point(138, 59);
            this.lblEskiParola.Name = "lblEskiParola";
            this.lblEskiParola.Size = new System.Drawing.Size(84, 20);
            this.lblEskiParola.TabIndex = 100;
            this.lblEskiParola.Text = "Eski parola:";
            this.lblEskiParola.Click += new System.EventHandler(this.lblEskiParola_Click);
            // 
            // lblYeniParolaTekrar
            // 
            this.lblYeniParolaTekrar.AutoSize = true;
            this.lblYeniParolaTekrar.BackColor = System.Drawing.Color.Transparent;
            this.lblYeniParolaTekrar.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniParolaTekrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYeniParolaTekrar.Location = new System.Drawing.Point(138, 174);
            this.lblYeniParolaTekrar.Name = "lblYeniParolaTekrar";
            this.lblYeniParolaTekrar.Size = new System.Drawing.Size(133, 20);
            this.lblYeniParolaTekrar.TabIndex = 99;
            this.lblYeniParolaTekrar.Text = "Eski parola(Tekrar):";
            this.lblYeniParolaTekrar.Click += new System.EventHandler(this.lblYeniParolaTekrar_Click);
            // 
            // lblYeniParola
            // 
            this.lblYeniParola.AutoSize = true;
            this.lblYeniParola.BackColor = System.Drawing.Color.Transparent;
            this.lblYeniParola.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniParola.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYeniParola.Location = new System.Drawing.Point(138, 114);
            this.lblYeniParola.Name = "lblYeniParola";
            this.lblYeniParola.Size = new System.Drawing.Size(86, 20);
            this.lblYeniParola.TabIndex = 98;
            this.lblYeniParola.Text = "Yeni parola:";
            this.lblYeniParola.Click += new System.EventHandler(this.lblYeniParola_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Animated = true;
            this.btnDegistir.AnimatedGIF = true;
            this.btnDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnDegistir.BorderRadius = 5;
            this.btnDegistir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDegistir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDegistir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDegistir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDegistir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDegistir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.ForeColor = System.Drawing.Color.White;
            this.btnDegistir.ImageSize = new System.Drawing.Size(24, 23);
            this.btnDegistir.Location = new System.Drawing.Point(142, 282);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(415, 40);
            this.btnDegistir.TabIndex = 101;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // checkShowPass
            // 
            this.checkShowPass.AutoSize = true;
            this.checkShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.checkShowPass.CheckedState.BorderRadius = 2;
            this.checkShowPass.CheckedState.BorderThickness = 0;
            this.checkShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.checkShowPass.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.checkShowPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkShowPass.Location = new System.Drawing.Point(142, 226);
            this.checkShowPass.Name = "checkShowPass";
            this.checkShowPass.Size = new System.Drawing.Size(106, 21);
            this.checkShowPass.TabIndex = 102;
            this.checkShowPass.Text = "Şifreyi Göster";
            this.checkShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.checkShowPass.UncheckedState.BorderRadius = 2;
            this.checkShowPass.UncheckedState.BorderThickness = 0;
            this.checkShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.checkShowPass.CheckedChanged += new System.EventHandler(this.checkShowPass_CheckedChanged);
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Animated = true;
            this.txtYeniSifreTekrar.BorderRadius = 6;
            this.txtYeniSifreTekrar.BorderThickness = 0;
            this.txtYeniSifreTekrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYeniSifreTekrar.DefaultText = "";
            this.txtYeniSifreTekrar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYeniSifreTekrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYeniSifreTekrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYeniSifreTekrar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYeniSifreTekrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtYeniSifreTekrar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtYeniSifreTekrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtYeniSifreTekrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYeniSifreTekrar.IconLeft = global::XYZ_Sağlıklı_Yaşam_Merkezi.Properties.Resources._lock;
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(307, 174);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.PasswordChar = '*';
            this.txtYeniSifreTekrar.PlaceholderText = "Yeni Şifre(Tekrar)";
            this.txtYeniSifreTekrar.SelectedText = "";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(250, 33);
            this.txtYeniSifreTekrar.TabIndex = 105;
            this.txtYeniSifreTekrar.TextChanged += new System.EventHandler(this.txtYeniSifreTekrar_TextChanged);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Animated = true;
            this.txtOldPass.BorderRadius = 6;
            this.txtOldPass.BorderThickness = 0;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.DefaultText = "";
            this.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtOldPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.IconLeft = global::XYZ_Sağlıklı_Yaşam_Merkezi.Properties.Resources._lock;
            this.txtOldPass.Location = new System.Drawing.Point(307, 59);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.PlaceholderText = "Eski Şifre";
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.Size = new System.Drawing.Size(250, 33);
            this.txtOldPass.TabIndex = 104;
            this.txtOldPass.TextChanged += new System.EventHandler(this.txtOldPass_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Animated = true;
            this.txtNewPassword.BorderRadius = 6;
            this.txtNewPassword.BorderThickness = 0;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNewPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.IconLeft = global::XYZ_Sağlıklı_Yaşam_Merkezi.Properties.Resources._lock;
            this.txtNewPassword.Location = new System.Drawing.Point(307, 114);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderText = "Yeni Şifre";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(250, 33);
            this.txtNewPassword.TabIndex = 103;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // FormParolaDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(694, 628);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.checkShowPass);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.lblEskiParola);
            this.Controls.Add(this.lblYeniParolaTekrar);
            this.Controls.Add(this.lblYeniParola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormParolaDegistir";
            this.Text = "FormParaloDegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEskiParola;
        private System.Windows.Forms.Label lblYeniParolaTekrar;
        private System.Windows.Forms.Label lblYeniParola;
        private Guna.UI2.WinForms.Guna2Button btnDegistir;
        private Guna.UI2.WinForms.Guna2CheckBox checkShowPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPass;
        private Guna.UI2.WinForms.Guna2TextBox txtYeniSifreTekrar;
    }
}