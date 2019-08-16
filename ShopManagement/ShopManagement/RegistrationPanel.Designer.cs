namespace ShopManagement
{
    partial class RegistrationPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gender = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Submit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(370, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.userAddress);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(91, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender :";
            // 
            // userName
            // 
            this.userName.Depth = 0;
            this.userName.Hint = "Enter Your Full Name";
            this.userName.Location = new System.Drawing.Point(135, 26);
            this.userName.MaxLength = 32767;
            this.userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.Size = new System.Drawing.Size(292, 23);
            this.userName.TabIndex = 3;
            this.userName.TabStop = false;
            this.userName.UseSystemPasswordChar = false;
            // 
            // userAddress
            // 
            this.userAddress.Depth = 0;
            this.userAddress.Hint = "Enter Your Address";
            this.userAddress.Location = new System.Drawing.Point(135, 65);
            this.userAddress.MaxLength = 32767;
            this.userAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.userAddress.Name = "userAddress";
            this.userAddress.PasswordChar = '\0';
            this.userAddress.SelectedText = "";
            this.userAddress.SelectionLength = 0;
            this.userAddress.SelectionStart = 0;
            this.userAddress.Size = new System.Drawing.Size(523, 23);
            this.userAddress.TabIndex = 4;
            this.userAddress.TabStop = false;
            this.userAddress.UseSystemPasswordChar = false;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(523, 30);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 24);
            this.gender.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cPassword);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.status);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(91, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email-Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Confirm-Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Account-Type :";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.status.Location = new System.Drawing.Point(551, 85);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 24);
            this.status.TabIndex = 6;
            // 
            // email
            // 
            this.email.Depth = 0;
            this.email.Hint = "name@domain.com";
            this.email.Location = new System.Drawing.Point(191, 21);
            this.email.MaxLength = 32767;
            this.email.MouseState = MaterialSkin.MouseState.HOVER;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.Size = new System.Drawing.Size(292, 23);
            this.email.TabIndex = 6;
            this.email.TabStop = false;
            this.email.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "Enter Your Password";
            this.password.Location = new System.Drawing.Point(191, 64);
            this.password.MaxLength = 32767;
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(292, 23);
            this.password.TabIndex = 7;
            this.password.TabStop = false;
            this.password.UseSystemPasswordChar = true;
            // 
            // cPassword
            // 
            this.cPassword.Depth = 0;
            this.cPassword.Hint = "Re-type the same password";
            this.cPassword.Location = new System.Drawing.Point(191, 111);
            this.cPassword.MaxLength = 32767;
            this.cPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.cPassword.Name = "cPassword";
            this.cPassword.PasswordChar = '\0';
            this.cPassword.SelectedText = "";
            this.cPassword.SelectionLength = 0;
            this.cPassword.SelectionStart = 0;
            this.cPassword.Size = new System.Drawing.Size(292, 23);
            this.cPassword.TabIndex = 8;
            this.cPassword.TabStop = false;
            this.cPassword.UseSystemPasswordChar = true;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.Submit.Location = new System.Drawing.Point(614, 451);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(215, 32);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(611, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Already have an account? ";
            // 
            // logInButton
            // 
            this.logInButton.AutoSize = true;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.logInButton.Location = new System.Drawing.Point(783, 513);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(44, 16);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Log In";
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // RegistrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationPanel";
            this.Size = new System.Drawing.Size(900, 573);
            this.Load += new System.EventHandler(this.RegistrationPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox gender;
        private MaterialSkin.Controls.MaterialSingleLineTextField userAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField cPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialSingleLineTextField email;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label logInButton;
    }
}
