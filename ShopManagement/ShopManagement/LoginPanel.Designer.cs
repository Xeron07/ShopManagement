﻿namespace ShopManagement
{
    partial class LoginPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.signUp = new System.Windows.Forms.Button();
            this.logIn = new System.Windows.Forms.Button();
            this.passwordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.signUp);
            this.groupBox1.Controls.Add(this.logIn);
            this.groupBox1.Controls.Add(this.passwordField);
            this.groupBox1.Controls.Add(this.emailValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(379, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(456, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUp.Location = new System.Drawing.Point(64, 310);
            this.signUp.Margin = new System.Windows.Forms.Padding(4);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(345, 37);
            this.signUp.TabIndex = 5;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logIn.Location = new System.Drawing.Point(64, 251);
            this.logIn.Margin = new System.Windows.Forms.Padding(4);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(345, 37);
            this.logIn.TabIndex = 4;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // passwordField
            // 
            this.passwordField.Depth = 0;
            this.passwordField.Hint = "Your Password";
            this.passwordField.Location = new System.Drawing.Point(65, 190);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.MaxLength = 32767;
            this.passwordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.SelectedText = "";
            this.passwordField.SelectionLength = 0;
            this.passwordField.SelectionStart = 0;
            this.passwordField.Size = new System.Drawing.Size(344, 28);
            this.passwordField.TabIndex = 3;
            this.passwordField.TabStop = false;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // emailValue
            // 
            this.emailValue.Depth = 0;
            this.emailValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailValue.Hint = "yourname@domain.com";
            this.emailValue.Location = new System.Drawing.Point(65, 91);
            this.emailValue.Margin = new System.Windows.Forms.Padding(4);
            this.emailValue.MaxLength = 32767;
            this.emailValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailValue.Name = "emailValue";
            this.emailValue.PasswordChar = '\0';
            this.emailValue.SelectedText = "";
            this.emailValue.SelectionLength = 0;
            this.emailValue.SelectionStart = 0;
            this.emailValue.Size = new System.Drawing.Size(344, 28);
            this.emailValue.TabIndex = 2;
            this.emailValue.TabStop = false;
            this.emailValue.UseSystemPasswordChar = false;
            this.emailValue.Click += new System.EventHandler(this.emailValue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email: ";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(1067, 521);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailValue;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Button logIn;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordField;
    }
}
