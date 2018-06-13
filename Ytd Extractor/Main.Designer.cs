﻿namespace Ytd_Extractor
{
    partial class Main
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
            this.btndownload = new System.Windows.Forms.Button();
            this.pbdown = new System.Windows.Forms.ProgressBar();
            this.rtlog = new System.Windows.Forms.RichTextBox();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPause = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblaudio = new System.Windows.Forms.Label();
            this.lblformat = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblquality = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlink = new TextBoxWatermark.ExTextBox();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(407, 33);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(79, 20);
            this.btndownload.TabIndex = 0;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // pbdown
            // 
            this.pbdown.Location = new System.Drawing.Point(12, 38);
            this.pbdown.Name = "pbdown";
            this.pbdown.Size = new System.Drawing.Size(391, 10);
            this.pbdown.TabIndex = 2;
            // 
            // rtlog
            // 
            this.rtlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtlog.Location = new System.Drawing.Point(12, 205);
            this.rtlog.Name = "rtlog";
            this.rtlog.ReadOnly = true;
            this.rtlog.Size = new System.Drawing.Size(476, 122);
            this.rtlog.TabIndex = 3;
            this.rtlog.Text = "";
            // 
            // cmbQuality
            // 
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Items.AddRange(new object[] {
            "1080p: 1920x1080 (no audio)",
            "720p: 1280x720",
            "480p: 854x480",
            "360p: 640x360",
            "240p: 426x240"});
            this.cmbQuality.Location = new System.Drawing.Point(93, 74);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(223, 21);
            this.cmbQuality.TabIndex = 4;
            this.cmbQuality.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(407, 54);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(81, 21);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Cancel";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 20);
            this.button4.TabIndex = 8;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Save Path     :";
            // 
            // lblpath
            // 
            this.lblpath.AutoEllipsis = true;
            this.lblpath.Location = new System.Drawing.Point(90, 58);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(226, 13);
            this.lblpath.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Video Quality :";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Mp4 Video files (*.Mp4)|*.mp4";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "Check..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblaudio);
            this.grpInfo.Controls.Add(this.lblformat);
            this.grpInfo.Controls.Add(this.lblsize);
            this.grpInfo.Controls.Add(this.lblquality);
            this.grpInfo.Controls.Add(this.lbltitle);
            this.grpInfo.Controls.Add(this.label12);
            this.grpInfo.Controls.Add(this.label11);
            this.grpInfo.Controls.Add(this.label10);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Location = new System.Drawing.Point(15, 101);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(471, 100);
            this.grpInfo.TabIndex = 14;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Video info";
            this.grpInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblaudio
            // 
            this.lblaudio.AutoEllipsis = true;
            this.lblaudio.AutoSize = true;
            this.lblaudio.Location = new System.Drawing.Point(293, 78);
            this.lblaudio.Name = "lblaudio";
            this.lblaudio.Size = new System.Drawing.Size(0, 13);
            this.lblaudio.TabIndex = 19;
            // 
            // lblformat
            // 
            this.lblformat.AutoEllipsis = true;
            this.lblformat.AutoSize = true;
            this.lblformat.Location = new System.Drawing.Point(103, 78);
            this.lblformat.Name = "lblformat";
            this.lblformat.Size = new System.Drawing.Size(0, 13);
            this.lblformat.TabIndex = 18;
            // 
            // lblsize
            // 
            this.lblsize.AutoEllipsis = true;
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(103, 56);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(0, 13);
            this.lblsize.TabIndex = 17;
            // 
            // lblquality
            // 
            this.lblquality.AutoEllipsis = true;
            this.lblquality.AutoSize = true;
            this.lblquality.Location = new System.Drawing.Point(103, 34);
            this.lblquality.Name = "lblquality";
            this.lblquality.Size = new System.Drawing.Size(0, 13);
            this.lblquality.TabIndex = 16;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoEllipsis = true;
            this.lbltitle.Location = new System.Drawing.Point(101, 16);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(364, 13);
            this.lbltitle.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Audio format";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Video format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // txtlink
            // 
            this.txtlink.Hint = "Past Youtube Video address";
            this.txtlink.Location = new System.Drawing.Point(12, 13);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(389, 20);
            this.txtlink.TabIndex = 15;
            this.txtlink.TextChanged += new System.EventHandler(this.txtlink_TextChanged_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 339);
            this.Controls.Add(this.txtlink);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.cmbQuality);
            this.Controls.Add(this.rtlog);
            this.Controls.Add(this.pbdown);
            this.Controls.Add(this.btndownload);
            this.Name = "Main";
            this.Text = "TubeDl";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.ProgressBar pbdown;
        private System.Windows.Forms.RichTextBox rtlog;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblaudio;
        private System.Windows.Forms.Label lblformat;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblquality;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private TextBoxWatermark.ExTextBox txtlink;
    }
}

