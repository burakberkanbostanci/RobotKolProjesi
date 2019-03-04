namespace RobotKol_V1._0
{
    partial class Form1
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
            this.btnBaglan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOmuz = new System.Windows.Forms.Label();
            this.trackBarOmuz = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDirsek = new System.Windows.Forms.Label();
            this.trackBarDirsek = new System.Windows.Forms.TrackBar();
            this.Port = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaglanti = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDonme = new System.Windows.Forms.Label();
            this.trackBarDonme = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTUTKAC = new System.Windows.Forms.Label();
            this.trackBarTutkac = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblBilek = new System.Windows.Forms.Label();
            this.trackBarBilek = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOmuz)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirsek)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDonme)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTutkac)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBilek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(56, 51);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(145, 28);
            this.btnBaglan.TabIndex = 13;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(56, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "COM3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOmuz);
            this.groupBox1.Controls.Add(this.trackBarOmuz);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 155);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVO Omuz";
            // 
            // lblOmuz
            // 
            this.lblOmuz.AutoSize = true;
            this.lblOmuz.Location = new System.Drawing.Point(326, 101);
            this.lblOmuz.Name = "lblOmuz";
            this.lblOmuz.Size = new System.Drawing.Size(24, 17);
            this.lblOmuz.TabIndex = 17;
            this.lblOmuz.Text = "90";
            // 
            // trackBarOmuz
            // 
            this.trackBarOmuz.Enabled = false;
            this.trackBarOmuz.Location = new System.Drawing.Point(37, 62);
            this.trackBarOmuz.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarOmuz.Maximum = 150;
            this.trackBarOmuz.Minimum = 60;
            this.trackBarOmuz.Name = "trackBarOmuz";
            this.trackBarOmuz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarOmuz.Size = new System.Drawing.Size(621, 56);
            this.trackBarOmuz.TabIndex = 15;
            this.trackBarOmuz.Value = 90;
            this.trackBarOmuz.Scroll += new System.EventHandler(this.trackBarOmuz_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDirsek);
            this.groupBox2.Controls.Add(this.trackBarDirsek);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 155);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVO Dirsek";
            // 
            // lblDirsek
            // 
            this.lblDirsek.AutoSize = true;
            this.lblDirsek.Location = new System.Drawing.Point(326, 113);
            this.lblDirsek.Name = "lblDirsek";
            this.lblDirsek.Size = new System.Drawing.Size(24, 17);
            this.lblDirsek.TabIndex = 16;
            this.lblDirsek.Text = "90";
            // 
            // trackBarDirsek
            // 
            this.trackBarDirsek.Enabled = false;
            this.trackBarDirsek.Location = new System.Drawing.Point(37, 62);
            this.trackBarDirsek.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarDirsek.Maximum = 180;
            this.trackBarDirsek.Name = "trackBarDirsek";
            this.trackBarDirsek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarDirsek.Size = new System.Drawing.Size(621, 56);
            this.trackBarDirsek.TabIndex = 15;
            this.trackBarDirsek.Value = 90;
            this.trackBarDirsek.Scroll += new System.EventHandler(this.trackBarDirsek_Scroll);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(15, 21);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(34, 17);
            this.Port.TabIndex = 22;
            this.Port.Text = "Port";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBaglanti);
            this.panel1.Controls.Add(this.btnBaglan);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Port);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 95);
            this.panel1.TabIndex = 23;
            // 
            // lblBaglanti
            // 
            this.lblBaglanti.AutoSize = true;
            this.lblBaglanti.Location = new System.Drawing.Point(117, 21);
            this.lblBaglanti.Name = "lblBaglanti";
            this.lblBaglanti.Size = new System.Drawing.Size(88, 17);
            this.lblBaglanti.TabIndex = 24;
            this.lblBaglanti.Text = "Baglanilmadi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDonme);
            this.groupBox3.Controls.Add(this.trackBarDonme);
            this.groupBox3.Location = new System.Drawing.Point(12, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 155);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SERVO Donme";
            // 
            // lblDonme
            // 
            this.lblDonme.AutoSize = true;
            this.lblDonme.Location = new System.Drawing.Point(326, 101);
            this.lblDonme.Name = "lblDonme";
            this.lblDonme.Size = new System.Drawing.Size(24, 17);
            this.lblDonme.TabIndex = 18;
            this.lblDonme.Text = "90";
            // 
            // trackBarDonme
            // 
            this.trackBarDonme.Enabled = false;
            this.trackBarDonme.Location = new System.Drawing.Point(37, 62);
            this.trackBarDonme.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarDonme.Maximum = 180;
            this.trackBarDonme.Name = "trackBarDonme";
            this.trackBarDonme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarDonme.Size = new System.Drawing.Size(621, 56);
            this.trackBarDonme.TabIndex = 15;
            this.trackBarDonme.Value = 90;
            this.trackBarDonme.Scroll += new System.EventHandler(this.trackBarDonme_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTUTKAC);
            this.groupBox4.Controls.Add(this.trackBarTutkac);
            this.groupBox4.Location = new System.Drawing.Point(12, 760);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(688, 155);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SERVO Tutkac";
            // 
            // lblTUTKAC
            // 
            this.lblTUTKAC.AutoSize = true;
            this.lblTUTKAC.Location = new System.Drawing.Point(326, 101);
            this.lblTUTKAC.Name = "lblTUTKAC";
            this.lblTUTKAC.Size = new System.Drawing.Size(24, 17);
            this.lblTUTKAC.TabIndex = 18;
            this.lblTUTKAC.Text = "90";
            // 
            // trackBarTutkac
            // 
            this.trackBarTutkac.Location = new System.Drawing.Point(37, 62);
            this.trackBarTutkac.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarTutkac.Maximum = 180;
            this.trackBarTutkac.Name = "trackBarTutkac";
            this.trackBarTutkac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarTutkac.Size = new System.Drawing.Size(621, 56);
            this.trackBarTutkac.TabIndex = 15;
            this.trackBarTutkac.Value = 90;
            this.trackBarTutkac.Scroll += new System.EventHandler(this.trackBarTutkac_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblBilek);
            this.groupBox5.Controls.Add(this.trackBarBilek);
            this.groupBox5.Location = new System.Drawing.Point(12, 599);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(688, 155);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SERVO Bilek";
            // 
            // lblBilek
            // 
            this.lblBilek.AutoSize = true;
            this.lblBilek.Location = new System.Drawing.Point(326, 101);
            this.lblBilek.Name = "lblBilek";
            this.lblBilek.Size = new System.Drawing.Size(24, 17);
            this.lblBilek.TabIndex = 18;
            this.lblBilek.Text = "90";
            // 
            // trackBarBilek
            // 
            this.trackBarBilek.Location = new System.Drawing.Point(37, 62);
            this.trackBarBilek.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarBilek.Maximum = 180;
            this.trackBarBilek.Name = "trackBarBilek";
            this.trackBarBilek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarBilek.Size = new System.Drawing.Size(621, 56);
            this.trackBarBilek.TabIndex = 15;
            this.trackBarBilek.Value = 90;
            this.trackBarBilek.Scroll += new System.EventHandler(this.trackBarBilek_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 927);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Robot Kol Kontrol Yazılımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOmuz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirsek)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDonme)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTutkac)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBilek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarOmuz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarDirsek;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaglanti;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBarDonme;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblDirsek;
        private System.Windows.Forms.Label lblOmuz;
        private System.Windows.Forms.Label lblDonme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTUTKAC;
        private System.Windows.Forms.TrackBar trackBarTutkac;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblBilek;
        private System.Windows.Forms.TrackBar trackBarBilek;
    }
}

