﻿namespace DesktopApp
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            checkBoxTampilkanPassword = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(55, 163, 165);
            label5.Location = new Point(514, 467);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 23;
            label5.Text = "Keluar";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(164, 165, 169);
            label4.Location = new Point(457, 451);
            label4.Name = "label4";
            label4.Size = new Size(183, 23);
            label4.TabIndex = 22;
            label4.Text = "Administrator Akses Only";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(55, 163, 165);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(390, 375);
            button1.Name = "button1";
            button1.Size = new Size(290, 38);
            button1.TabIndex = 20;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxTampilkanPassword
            // 
            checkBoxTampilkanPassword.Anchor = AnchorStyles.None;
            checkBoxTampilkanPassword.AutoSize = true;
            checkBoxTampilkanPassword.Cursor = Cursors.Hand;
            checkBoxTampilkanPassword.FlatStyle = FlatStyle.Flat;
            checkBoxTampilkanPassword.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxTampilkanPassword.ForeColor = Color.FromArgb(164, 165, 169);
            checkBoxTampilkanPassword.Location = new Point(520, 341);
            checkBoxTampilkanPassword.Name = "checkBoxTampilkanPassword";
            checkBoxTampilkanPassword.Size = new Size(168, 27);
            checkBoxTampilkanPassword.TabIndex = 19;
            checkBoxTampilkanPassword.Text = "Tampilkan Password";
            checkBoxTampilkanPassword.UseVisualStyleBackColor = true;
            checkBoxTampilkanPassword.CheckedChanged += checkBoxTampilkanPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(390, 303);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(290, 35);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(387, 283);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(390, 238);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(290, 35);
            txtUsername.TabIndex = 16;
            txtUsername.TextChanged += textusername_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(164, 165, 169);
            label2.Location = new Point(387, 218);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(164, 165, 169);
            label1.Location = new Point(482, 185);
            label1.Name = "label1";
            label1.Size = new Size(122, 26);
            label1.TabIndex = 12;
            label1.Text = "Silahkan Login";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(495, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(55, 163, 165);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(457, 148);
            label6.Name = "label6";
            label6.Size = new Size(174, 42);
            label6.TabIndex = 26;
            label6.Text = "Admin Panel";
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1080, 600);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBoxTampilkanPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Formlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formlogin";
            WindowState = FormWindowState.Maximized;
            Load += Formlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Button button1;
        private CheckBox checkBoxTampilkanPassword;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
    }
}