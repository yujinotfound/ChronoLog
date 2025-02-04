﻿using System.Drawing;
using System.Windows.Forms;

namespace ChronoLog {
    partial class LogInGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInGUI));
            this.userIDInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.chronologLogo = new System.Windows.Forms.PictureBox();
            this.logoName = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chronologLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDInput
            // 
            this.userIDInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userIDInput.Location = new System.Drawing.Point(75, 224);
            this.userIDInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userIDInput.Name = "userIDInput";
            this.userIDInput.Size = new System.Drawing.Size(184, 31);
            this.userIDInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordInput.Location = new System.Drawing.Point(75, 283);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(184, 31);
            this.passwordInput.TabIndex = 1;
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentIDLabel.Location = new System.Drawing.Point(75, 205);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(54, 25);
            this.studentIDLabel.TabIndex = 2;
            this.studentIDLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordLabel.Location = new System.Drawing.Point(75, 263);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // chronologLogo
            // 
            this.chronologLogo.BackColor = System.Drawing.Color.Transparent;
            this.chronologLogo.Image = ((System.Drawing.Image)(resources.GetObject("chronologLogo.Image")));
            this.chronologLogo.Location = new System.Drawing.Point(24, -1);
            this.chronologLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chronologLogo.Name = "chronologLogo";
            this.chronologLogo.Size = new System.Drawing.Size(287, 195);
            this.chronologLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chronologLogo.TabIndex = 4;
            this.chronologLogo.TabStop = false;
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoName.Location = new System.Drawing.Point(110, 156);
            this.logoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(168, 33);
            this.logoName.TabIndex = 5;
            this.logoName.Text = "ChronoLog";
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(62, 338);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(94, 35);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogInGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(335, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.logoName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userIDInput);
            this.Controls.Add(this.chronologLogo);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LogInGUI";
            this.Text = "ChronoLog";
            ((System.ComponentModel.ISupportInitialize)(this.chronologLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userIDInput;
        private TextBox passwordInput;
        private Label studentIDLabel;
        private Label passwordLabel;
        private PictureBox chronologLogo;
        private Label logoName;
        private Button logInButton;
        private Button button1;
    }
}


