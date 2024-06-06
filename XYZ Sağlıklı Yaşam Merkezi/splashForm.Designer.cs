namespace XYZ_Sağlıklı_Yaşam_Merkezi
{
    partial class splashForm
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
            this.components = new System.ComponentModel.Container();
            this.animate = new System.Windows.Forms.Timer(this.components);
            this.suffatech = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.suffatech)).BeginInit();
            this.SuspendLayout();
            // 
            // animate
            // 
            this.animate.Enabled = true;
            this.animate.Interval = 10;
            this.animate.Tick += new System.EventHandler(this.animate_Tick);
            // 
            // suffatech
            // 
            this.suffatech.Image = global::XYZ_Sağlıklı_Yaşam_Merkezi.Properties.Resources.SUFFA;
            this.suffatech.ImageRotate = 0F;
            this.suffatech.Location = new System.Drawing.Point(12, 79);
            this.suffatech.Name = "suffatech";
            this.suffatech.Size = new System.Drawing.Size(831, 200);
            this.suffatech.TabIndex = 0;
            this.suffatech.TabStop = false;
            // 
            // splashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(845, 459);
            this.Controls.Add(this.suffatech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.suffatech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox suffatech;
        private System.Windows.Forms.Timer animate;
    }
}