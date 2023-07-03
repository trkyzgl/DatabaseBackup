
namespace BetechBackup
{
    partial class BetechBackup_Form
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_database = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.btn_sec = new System.Windows.Forms.Button();
            this.btn_yedekle = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDBName = new System.Windows.Forms.ComboBox();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seçilen Veritabanı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dosya Yolu : ";
            // 
            // textBox_database
            // 
            this.textBox_database.Location = new System.Drawing.Point(155, 123);
            this.textBox_database.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_database.Name = "textBox_database";
            this.textBox_database.Size = new System.Drawing.Size(336, 22);
            this.textBox_database.TabIndex = 4;
            this.textBox_database.Text = "Seçilen Database";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(155, 166);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(260, 22);
            this.textBox_path.TabIndex = 5;
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(424, 166);
            this.btn_sec.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(68, 28);
            this.btn_sec.TabIndex = 6;
            this.btn_sec.Text = "...";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // btn_yedekle
            // 
            this.btn_yedekle.Location = new System.Drawing.Point(155, 206);
            this.btn_yedekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yedekle.Name = "btn_yedekle";
            this.btn_yedekle.Size = new System.Drawing.Size(337, 25);
            this.btn_yedekle.TabIndex = 7;
            this.btn_yedekle.Text = "YEDEKLE";
            this.btn_yedekle.UseVisualStyleBackColor = true;
            this.btn_yedekle.Click += new System.EventHandler(this.btn_yedekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Veri Tabanlarım :";
            // 
            // cmbDBName
            // 
            this.cmbDBName.FormattingEnabled = true;
            this.cmbDBName.Location = new System.Drawing.Point(155, 79);
            this.cmbDBName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDBName.Name = "cmbDBName";
            this.cmbDBName.Size = new System.Drawing.Size(336, 24);
            this.cmbDBName.TabIndex = 9;
            this.cmbDBName.SelectedIndexChanged += new System.EventHandler(this.comboBox_veritabani_SelectedIndexChanged);
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(156, 39);
            this.cmbServerName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(336, 24);
            this.cmbServerName.TabIndex = 12;
            this.cmbServerName.SelectedIndexChanged += new System.EventHandler(this.cmbServerName_SelectedIndexChanged);
            // 
            // BetechBackup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 411);
            this.Controls.Add(this.cmbServerName);
            this.Controls.Add(this.cmbDBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_yedekle);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.textBox_database);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BetechBackup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetechBackup";
            this.Load += new System.EventHandler(this.BetechBackup_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_database;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.Button btn_yedekle;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDBName;
        private System.Windows.Forms.ComboBox cmbServerName;
    }
}

