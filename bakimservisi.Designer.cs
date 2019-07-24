namespace Rent_A_Car
{
    partial class bakimservisi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.araclar_datagrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bakimlar_datagrid = new System.Windows.Forms.DataGridView();
            this.bakim_lbl = new System.Windows.Forms.Label();
            this.arac_lbl = new System.Windows.Forms.Label();
            this.yenibakim_btn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.araclar_datagrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakimlar_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.araclar_datagrid);
            this.groupBox3.Location = new System.Drawing.Point(31, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 214);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARAÇ BİLGİLERİ";
            // 
            // araclar_datagrid
            // 
            this.araclar_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.araclar_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.araclar_datagrid.Location = new System.Drawing.Point(4, 35);
            this.araclar_datagrid.Margin = new System.Windows.Forms.Padding(1);
            this.araclar_datagrid.Name = "araclar_datagrid";
            this.araclar_datagrid.ReadOnly = true;
            this.araclar_datagrid.RowTemplate.Height = 40;
            this.araclar_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.araclar_datagrid.Size = new System.Drawing.Size(861, 161);
            this.araclar_datagrid.TabIndex = 56;
            this.araclar_datagrid.Click += new System.EventHandler(this.araclar_datagrid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bakimlar_datagrid);
            this.groupBox1.Location = new System.Drawing.Point(31, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 198);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAKIM BİLGİLERİ";
            // 
            // bakimlar_datagrid
            // 
            this.bakimlar_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.bakimlar_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakimlar_datagrid.Location = new System.Drawing.Point(3, 34);
            this.bakimlar_datagrid.Margin = new System.Windows.Forms.Padding(1);
            this.bakimlar_datagrid.Name = "bakimlar_datagrid";
            this.bakimlar_datagrid.ReadOnly = true;
            this.bakimlar_datagrid.RowTemplate.Height = 40;
            this.bakimlar_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bakimlar_datagrid.Size = new System.Drawing.Size(862, 150);
            this.bakimlar_datagrid.TabIndex = 56;
            // 
            // bakim_lbl
            // 
            this.bakim_lbl.AutoSize = true;
            this.bakim_lbl.Location = new System.Drawing.Point(31, 542);
            this.bakim_lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.bakim_lbl.Name = "bakim_lbl";
            this.bakim_lbl.Size = new System.Drawing.Size(382, 13);
            this.bakim_lbl.TabIndex = 68;
            this.bakim_lbl.Text = "....54 TŞ 54.... plakalı aracın toplam ...2... kaydı ve ...2500... tl bakım masra" +
    "fı var";
            // 
            // arac_lbl
            // 
            this.arac_lbl.AutoSize = true;
            this.arac_lbl.Location = new System.Drawing.Point(458, 288);
            this.arac_lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.arac_lbl.Name = "arac_lbl";
            this.arac_lbl.Size = new System.Drawing.Size(156, 13);
            this.arac_lbl.TabIndex = 67;
            this.arac_lbl.Text = "bakımda ...2... araç bulunmakta";
            // 
            // yenibakim_btn
            // 
            this.yenibakim_btn.Location = new System.Drawing.Point(544, 526);
            this.yenibakim_btn.Margin = new System.Windows.Forms.Padding(1);
            this.yenibakim_btn.Name = "yenibakim_btn";
            this.yenibakim_btn.Size = new System.Drawing.Size(140, 44);
            this.yenibakim_btn.TabIndex = 65;
            this.yenibakim_btn.Text = "YENİ BAKIM";
            this.yenibakim_btn.UseVisualStyleBackColor = true;
            this.yenibakim_btn.Click += new System.EventHandler(this.yenibakim_btn_Click);
            // 
            // bakimservisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bakim_lbl);
            this.Controls.Add(this.arac_lbl);
            this.Controls.Add(this.yenibakim_btn);
            this.Name = "bakimservisi";
            this.Size = new System.Drawing.Size(1021, 587);
            this.Load += new System.EventHandler(this.bakimservisi_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.araclar_datagrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bakimlar_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView araclar_datagrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bakimlar_datagrid;
        private System.Windows.Forms.Label bakim_lbl;
        private System.Windows.Forms.Label arac_lbl;
        private System.Windows.Forms.Button yenibakim_btn;
    }
}
