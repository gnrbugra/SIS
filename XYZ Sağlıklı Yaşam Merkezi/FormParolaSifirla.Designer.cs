namespace XYZ_Sağlıklı_Yaşam_Merkezi
{
    partial class FormParolaSıfırla
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
            this.checkShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnDegistir = new Guna.UI2.WinForms.Guna2Button();
            this.lblEskiParola = new System.Windows.Forms.Label();
            this.lblYeniParola = new System.Windows.Forms.Label();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.checkShowPass.Location = new System.Drawing.Point(142, 218);
            this.checkShowPass.Name = "checkShowPass";
            this.checkShowPass.Size = new System.Drawing.Size(106, 21);
            this.checkShowPass.TabIndex = 110;
            this.checkShowPass.Text = "Şifreyi Göster";
            this.checkShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.checkShowPass.UncheckedState.BorderRadius = 2;
            this.checkShowPass.UncheckedState.BorderThickness = 0;
            this.checkShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.checkShowPass.CheckedChanged += new System.EventHandler(this.checkShowPass_CheckedChanged);
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
            this.btnDegistir.Location = new System.Drawing.Point(142, 274);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(415, 40);
            this.btnDegistir.TabIndex = 109;
            this.btnDegistir.Text = "Değiştir";
            // 
            // lblEskiParola
            // 
            this.lblEskiParola.AutoSize = true;
            this.lblEskiParola.BackColor = System.Drawing.Color.Transparent;
            this.lblEskiParola.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEskiParola.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEskiParola.Location = new System.Drawing.Point(138, 89);
            this.lblEskiParola.Name = "lblEskiParola";
            this.lblEskiParola.Size = new System.Drawing.Size(54, 20);
            this.lblEskiParola.TabIndex = 108;
            this.lblEskiParola.Text = "Eposta";
            // 
            // lblYeniParola
            // 
            this.lblYeniParola.AutoSize = true;
            this.lblYeniParola.BackColor = System.Drawing.Color.Transparent;
            this.lblYeniParola.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniParola.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYeniParola.Location = new System.Drawing.Point(138, 144);
            this.lblYeniParola.Name = "lblYeniParola";
            this.lblYeniParola.Size = new System.Drawing.Size(86, 20);
            this.lblYeniParola.TabIndex = 106;
            this.lblYeniParola.Text = "Yeni parola:";
            // 
            // txtMail
            // 
            this.txtMail.Animated = true;
            this.txtMail.BorderRadius = 6;
            this.txtMail.BorderThickness = 0;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Location = new System.Drawing.Point(307, 89);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '*';
            this.txtMail.PlaceholderText = "Eski Şifre";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(250, 33);
            this.txtMail.TabIndex = 112;
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
            this.txtNewPassword.Location = new System.Drawing.Point(307, 144);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderText = "Yeni Şifre";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(250, 33);
            this.txtNewPassword.TabIndex = 111;
            // 
            // FormParolaSıfırla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(694, 628);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.checkShowPass);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.lblEskiParola);
            this.Controls.Add(this.lblYeniParola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormParolaSıfırla";
            this.Text = "FormParolaSıfırla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2CheckBox checkShowPass;
        private Guna.UI2.WinForms.Guna2Button btnDegistir;
        private System.Windows.Forms.Label lblEskiParola;
        private System.Windows.Forms.Label lblYeniParola;
    }
}