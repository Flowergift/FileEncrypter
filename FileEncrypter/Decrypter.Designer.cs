﻿namespace FileEncrypter
{
    partial class Decrypter
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Decrypt_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.capture_imageBox = new Emgu.CV.UI.ImageBox();
            this.open_folder_button = new System.Windows.Forms.Button();
            this.Target_Folder_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.get_img_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.check_img_bgw = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capture_imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.panel2.Controls.Add(this.Decrypt_button);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.open_folder_button);
            this.panel2.Controls.Add(this.Target_Folder_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 693);
            this.panel2.TabIndex = 2;
            // 
            // Decrypt_button
            // 
            this.Decrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.Decrypt_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt_button.Enabled = false;
            this.Decrypt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decrypt_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(133)))), ((int)(((byte)(1)))));
            this.Decrypt_button.Location = new System.Drawing.Point(521, 617);
            this.Decrypt_button.Name = "Decrypt_button";
            this.Decrypt_button.Size = new System.Drawing.Size(170, 52);
            this.Decrypt_button.TabIndex = 10;
            this.Decrypt_button.Text = "Decrypt";
            this.Decrypt_button.UseVisualStyleBackColor = false;
            this.Decrypt_button.Click += new System.EventHandler(this.Decrypt_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.button1.Location = new System.Drawing.Point(512, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(133)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(300, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Look at The Center";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.capture_imageBox);
            this.panel3.Location = new System.Drawing.Point(97, 117);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(649, 386);
            this.panel3.TabIndex = 7;
            // 
            // capture_imageBox
            // 
            this.capture_imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capture_imageBox.Location = new System.Drawing.Point(2, 2);
            this.capture_imageBox.Name = "capture_imageBox";
            this.capture_imageBox.Size = new System.Drawing.Size(645, 382);
            this.capture_imageBox.TabIndex = 2;
            this.capture_imageBox.TabStop = false;
            // 
            // open_folder_button
            // 
            this.open_folder_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.open_folder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_folder_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(133)))), ((int)(((byte)(1)))));
            this.open_folder_button.Location = new System.Drawing.Point(642, 38);
            this.open_folder_button.Name = "open_folder_button";
            this.open_folder_button.Size = new System.Drawing.Size(27, 42);
            this.open_folder_button.TabIndex = 2;
            this.open_folder_button.Text = "...";
            this.open_folder_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open_folder_button.UseVisualStyleBackColor = false;
            this.open_folder_button.Click += new System.EventHandler(this.open_folder_button_Click);
            // 
            // Target_Folder_button
            // 
            this.Target_Folder_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.Target_Folder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Target_Folder_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(133)))), ((int)(((byte)(1)))));
            this.Target_Folder_button.Location = new System.Drawing.Point(193, 39);
            this.Target_Folder_button.Name = "Target_Folder_button";
            this.Target_Folder_button.Size = new System.Drawing.Size(443, 42);
            this.Target_Folder_button.TabIndex = 1;
            this.Target_Folder_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Target_Folder_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(133)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Folder :";
            // 
            // get_img_backgroundWorker
            // 
            this.get_img_backgroundWorker.WorkerReportsProgress = true;
            this.get_img_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.get_img_backgroundWorker_DoWork);
            this.get_img_backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.get_img_backgroundWorker_RunWorkerCompleted);
            // 
            // check_img_bgw
            // 
            this.check_img_bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.check_img_bgw_DoWork);
            // 
            // Decrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 693);
            this.Controls.Add(this.panel2);
            this.Name = "Decrypter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileDecrypter";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.capture_imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button Decrypt_button;
        private Button button1;
        private Label label4;
        private Panel panel3;
        private Emgu.CV.UI.ImageBox capture_imageBox;
        private Button open_folder_button;
        private Button Target_Folder_button;
        private Label label1;
        private System.ComponentModel.BackgroundWorker get_img_backgroundWorker;
        private System.ComponentModel.BackgroundWorker check_img_bgw;
    }
}