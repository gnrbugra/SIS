namespace XYZ_Sağlıklı_Yaşam_Merkezi
{
    partial class FormSeansYonetimi
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
            this.z = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblUzman = new System.Windows.Forms.Label();
            this.listSeanslar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.Transparent;
            this.z.BorderColor = System.Drawing.Color.White;
            this.z.BorderRadius = 6;
            this.z.BorderThickness = 0;
            this.z.DisabledState.BorderColor = System.Drawing.Color.Yellow;
            this.z.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.z.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.z.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.z.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.z.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.z.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.z.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.z.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.z.ForeColor = System.Drawing.Color.White;
            this.z.ItemHeight = 25;
            this.z.Items.AddRange(new object[] {
            "E",
            "K"});
            this.z.Location = new System.Drawing.Point(283, 23);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(250, 31);
            this.z.StartIndex = 0;
            this.z.TabIndex = 95;
            // 
            // lblUzman
            // 
            this.lblUzman.AutoSize = true;
            this.lblUzman.BackColor = System.Drawing.Color.Transparent;
            this.lblUzman.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzman.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUzman.Location = new System.Drawing.Point(135, 24);
            this.lblUzman.Name = "lblUzman";
            this.lblUzman.Size = new System.Drawing.Size(58, 20);
            this.lblUzman.TabIndex = 96;
            this.lblUzman.Text = "Uzman:";
            // 
            // listSeanslar
            // 
            this.listSeanslar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.listSeanslar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSeanslar.ForeColor = System.Drawing.SystemColors.Menu;
            this.listSeanslar.FormattingEnabled = true;
            this.listSeanslar.Location = new System.Drawing.Point(139, 108);
            this.listSeanslar.Name = "listSeanslar";
            this.listSeanslar.ScrollAlwaysVisible = true;
            this.listSeanslar.Size = new System.Drawing.Size(394, 442);
            this.listSeanslar.TabIndex = 97;
            // 
            // FormSeansYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(694, 628);
            this.Controls.Add(this.listSeanslar);
            this.Controls.Add(this.lblUzman);
            this.Controls.Add(this.z);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSeansYonetimi";
            this.Text = "FormSeansYonetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox z;
        private System.Windows.Forms.Label lblUzman;
        private System.Windows.Forms.ListBox listSeanslar;
    }
}