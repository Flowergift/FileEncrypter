namespace FileEncrypter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.decrypt_button);
            this.panel1.Controls.Add(this.Encrypt_button);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 539);
            this.panel1.TabIndex = 1;
            // 
            // decrypt_button
            // 
            this.decrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.decrypt_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decrypt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt_button.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decrypt_button.ForeColor = System.Drawing.Color.Green;
            this.decrypt_button.Location = new System.Drawing.Point(463, 182);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(170, 52);
            this.decrypt_button.TabIndex = 3;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = false;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(58)))), ((int)(((byte)(57)))));
            this.Encrypt_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Encrypt_button.ForeColor = System.Drawing.Color.Red;
            this.Encrypt_button.Location = new System.Drawing.Point(106, 182);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(170, 52);
            this.Encrypt_button.TabIndex = 1;
            this.Encrypt_button.Text = "Encrypt";
            this.Encrypt_button.UseVisualStyleBackColor = false;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(262, 73);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(203, 28);
            this.label.TabIndex = 0;
            this.label.Text = "Face Based File Encrypter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 539);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button decrypt_button;
        private Button Encrypt_button;
        private Label label;
    }
}