namespace Rent_A_Car
{
    partial class Bildiri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bildiri));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.yazitxt = new System.Windows.Forms.Label();
            this.zamandoldu = new System.Windows.Forms.Timer(this.components);
            this.kapatzamanı = new System.Windows.Forms.Timer(this.components);
            this.goruntulezamanı = new System.Windows.Forms.Timer(this.components);
            this.resimlistesi = new System.Windows.Forms.ImageList(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // yazitxt
            // 
            this.yazitxt.AutoSize = true;
            this.yazitxt.BackColor = System.Drawing.Color.Transparent;
            this.yazitxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazitxt.ForeColor = System.Drawing.Color.White;
            this.yazitxt.Location = new System.Drawing.Point(82, 28);
            this.yazitxt.Name = "yazitxt";
            this.yazitxt.Size = new System.Drawing.Size(121, 20);
            this.yazitxt.TabIndex = 10;
            this.yazitxt.Text = "Merhaba Millet";
            this.yazitxt.TextChanged += new System.EventHandler(this.yazitxt_TextChanged);
            // 
            // zamandoldu
            // 
            this.zamandoldu.Enabled = true;
            this.zamandoldu.Interval = 5000;
            this.zamandoldu.Tick += new System.EventHandler(this.zamandoldu_Tick);
            // 
            // kapatzamanı
            // 
            this.kapatzamanı.Interval = 20;
            this.kapatzamanı.Tick += new System.EventHandler(this.kapatzamanı_Tick);
            // 
            // goruntulezamanı
            // 
            this.goruntulezamanı.Interval = 20;
            this.goruntulezamanı.Tick += new System.EventHandler(this.goruntulezamanı_Tick);
            // 
            // resimlistesi
            // 
            this.resimlistesi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("resimlistesi.ImageStream")));
            this.resimlistesi.TransparentColor = System.Drawing.Color.Transparent;
            this.resimlistesi.Images.SetKeyName(0, "if_Error_381599.png");
            this.resimlistesi.Images.SetKeyName(1, "if_icon-61-warning_315983.png");
            this.resimlistesi.Images.SetKeyName(2, "if_sign-info_299086.png");
            this.resimlistesi.Images.SetKeyName(3, "if_success_1646004.png");
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(322, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(64, 64);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 9;
            this.icon.TabStop = false;
            // 
            // Bildiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(355, 90);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.yazitxt);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bildiri";
            this.Text = "Bildiri";
            this.Activated += new System.EventHandler(this.Bildiri_Activated);
            this.Load += new System.EventHandler(this.Bildiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label yazitxt;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Timer zamandoldu;
        private System.Windows.Forms.Timer kapatzamanı;
        private System.Windows.Forms.Timer goruntulezamanı;
        private System.Windows.Forms.ImageList resimlistesi;
    }
}