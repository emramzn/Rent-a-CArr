namespace Rent_A_Car
{
    partial class teslimatagorearaclar
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
            this.bugun_time = new System.Windows.Forms.DateTimePicker();
            this.tum_araclar_btn = new System.Windows.Forms.Button();
            this.belli_time = new System.Windows.Forms.DateTimePicker();
            this.butarihgoster_lnk = new System.Windows.Forms.LinkLabel();
            this.bugungoster_lnk = new System.Windows.Forms.LinkLabel();
            this.araclar_datagrid = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.araclar_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bugun_time);
            this.groupBox3.Controls.Add(this.tum_araclar_btn);
            this.groupBox3.Controls.Add(this.belli_time);
            this.groupBox3.Controls.Add(this.butarihgoster_lnk);
            this.groupBox3.Controls.Add(this.bugungoster_lnk);
            this.groupBox3.Location = new System.Drawing.Point(21, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 122);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARAÇ BİLGİLERİ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // bugun_time
            // 
            this.bugun_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bugun_time.Location = new System.Drawing.Point(107, 30);
            this.bugun_time.Margin = new System.Windows.Forms.Padding(1);
            this.bugun_time.Name = "bugun_time";
            this.bugun_time.Size = new System.Drawing.Size(104, 20);
            this.bugun_time.TabIndex = 4;
            this.bugun_time.Visible = false;
            // 
            // tum_araclar_btn
            // 
            this.tum_araclar_btn.Location = new System.Drawing.Point(633, 27);
            this.tum_araclar_btn.Margin = new System.Windows.Forms.Padding(1);
            this.tum_araclar_btn.Name = "tum_araclar_btn";
            this.tum_araclar_btn.Size = new System.Drawing.Size(205, 55);
            this.tum_araclar_btn.TabIndex = 3;
            this.tum_araclar_btn.Text = "TESLİM ALINACAK TÜM ARAÇLAR";
            this.tum_araclar_btn.UseVisualStyleBackColor = true;
            this.tum_araclar_btn.Click += new System.EventHandler(this.tum_araclar_btn_Click);
            // 
            // belli_time
            // 
            this.belli_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.belli_time.Location = new System.Drawing.Point(111, 69);
            this.belli_time.Margin = new System.Windows.Forms.Padding(1);
            this.belli_time.Name = "belli_time";
            this.belli_time.Size = new System.Drawing.Size(104, 20);
            this.belli_time.TabIndex = 2;
            // 
            // butarihgoster_lnk
            // 
            this.butarihgoster_lnk.AutoSize = true;
            this.butarihgoster_lnk.Location = new System.Drawing.Point(287, 69);
            this.butarihgoster_lnk.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.butarihgoster_lnk.Name = "butarihgoster_lnk";
            this.butarihgoster_lnk.Size = new System.Drawing.Size(273, 13);
            this.butarihgoster_lnk.TabIndex = 1;
            this.butarihgoster_lnk.TabStop = true;
            this.butarihgoster_lnk.Text = "BU TARİHTE TESLİM EDİLECEK ARAÇLARI GÖSTER";
            this.butarihgoster_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.butarihgoster_lnk_LinkClicked);
            // 
            // bugungoster_lnk
            // 
            this.bugungoster_lnk.AutoSize = true;
            this.bugungoster_lnk.Location = new System.Drawing.Point(287, 30);
            this.bugungoster_lnk.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.bugungoster_lnk.Name = "bugungoster_lnk";
            this.bugungoster_lnk.Size = new System.Drawing.Size(250, 13);
            this.bugungoster_lnk.TabIndex = 0;
            this.bugungoster_lnk.TabStop = true;
            this.bugungoster_lnk.Text = "BU GÜN TESLİM EDİLECEK ARAÇLARI GÖSTER";
            this.bugungoster_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bugungoster_lnk_LinkClicked);
            // 
            // araclar_datagrid
            // 
            this.araclar_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.araclar_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.araclar_datagrid.Location = new System.Drawing.Point(21, 230);
            this.araclar_datagrid.Margin = new System.Windows.Forms.Padding(1);
            this.araclar_datagrid.Name = "araclar_datagrid";
            this.araclar_datagrid.ReadOnly = true;
            this.araclar_datagrid.RowTemplate.Height = 40;
            this.araclar_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.araclar_datagrid.Size = new System.Drawing.Size(885, 317);
            this.araclar_datagrid.TabIndex = 59;
            // 
            // teslimatagorearaclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.araclar_datagrid);
            this.Name = "teslimatagorearaclar";
            this.Size = new System.Drawing.Size(1021, 587);
            this.Load += new System.EventHandler(this.teslimatagorearaclar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.araclar_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker bugun_time;
        private System.Windows.Forms.Button tum_araclar_btn;
        private System.Windows.Forms.DateTimePicker belli_time;
        private System.Windows.Forms.LinkLabel butarihgoster_lnk;
        private System.Windows.Forms.LinkLabel bugungoster_lnk;
        private System.Windows.Forms.DataGridView araclar_datagrid;
    }
}
