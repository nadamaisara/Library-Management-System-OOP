namespace MyLibrary
{
    partial class SignUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.AuthenticationID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Label();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.staffid = new System.Windows.Forms.TextBox();
            this.isadmin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(507, 468);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clear";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(329, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD USER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneNum
            // 
            this.phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNum.Location = new System.Drawing.Point(51, 172);
            this.phoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(333, 26);
            this.phoneNum.TabIndex = 7;
            this.phoneNum.Text = "Enter your phone number";
            this.phoneNum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.phoneNum_MouseClick);
            this.phoneNum.TextChanged += new System.EventHandler(this.phoneNum_TextChanged);
            this.phoneNum.Leave += new System.EventHandler(this.phoneNum_Leave);
            // 
            // AuthenticationID
            // 
            this.AuthenticationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthenticationID.Location = new System.Drawing.Point(51, 107);
            this.AuthenticationID.Margin = new System.Windows.Forms.Padding(2);
            this.AuthenticationID.Name = "AuthenticationID";
            this.AuthenticationID.Size = new System.Drawing.Size(333, 26);
            this.AuthenticationID.TabIndex = 6;
            this.AuthenticationID.Text = "Enter your Authentication ID";
            this.AuthenticationID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserName_MouseClick);
            this.AuthenticationID.TextChanged += new System.EventHandler(this.AuthenticationID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(319, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "USER SIGN UP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(51, 305);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(333, 26);
            this.password.TabIndex = 10;
            this.password.Text = "Enter your password";
            this.password.UseSystemPasswordChar = true;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_MouseClick);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(51, 239);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(333, 26);
            this.Email.TabIndex = 11;
            this.Email.Text = "Enter your Email address";
            this.Email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Email_MouseClick);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // confirmPass
            // 
            this.confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmPass.Location = new System.Drawing.Point(51, 360);
            this.confirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(333, 26);
            this.confirmPass.TabIndex = 12;
            this.confirmPass.Text = "Confirm your password";
            this.confirmPass.UseSystemPasswordChar = true;
            this.confirmPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.confirmPass_MouseClick);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.Crimson;
            this.backBtn.Location = new System.Drawing.Point(10, 8);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(46, 18);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(329, 336);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(55, 19);
            this.cbPass.TabIndex = 14;
            this.cbPass.Text = "Show";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Location = new System.Drawing.Point(329, 391);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(55, 19);
            this.cbConfirm.TabIndex = 15;
            this.cbConfirm.Text = "Show";
            this.cbConfirm.UseVisualStyleBackColor = true;
            this.cbConfirm.CheckedChanged += new System.EventHandler(this.cbConfirm_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter your Authentication ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enter your phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter your email address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(51, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Enter your password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Confirm your password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(451, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Enter your First Name:";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(451, 103);
            this.firstName.Margin = new System.Windows.Forms.Padding(2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(333, 26);
            this.firstName.TabIndex = 21;
            this.firstName.Text = "Enter your First Name";
            this.firstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstName_MouseClick);
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(451, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Enter your Last Name:";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(451, 172);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(333, 26);
            this.LastName.TabIndex = 23;
            this.LastName.Text = "Enter your Last Name";
            this.LastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LastName_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(451, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Are You An Admin?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(454, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Enter Your Salary:";
            // 
            // salarytxt
            // 
            this.salarytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salarytxt.Location = new System.Drawing.Point(454, 305);
            this.salarytxt.Margin = new System.Windows.Forms.Padding(2);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(333, 26);
            this.salarytxt.TabIndex = 27;
            this.salarytxt.Text = "Enter Your Salary";
            this.salarytxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.salarytxt_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(451, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Enter Your Staff ID:";
            // 
            // staffid
            // 
            this.staffid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staffid.Location = new System.Drawing.Point(451, 373);
            this.staffid.Margin = new System.Windows.Forms.Padding(2);
            this.staffid.Name = "staffid";
            this.staffid.Size = new System.Drawing.Size(333, 26);
            this.staffid.TabIndex = 29;
            this.staffid.Text = "Enter Your Staff ID";
            this.staffid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.staffid_MouseClick);
            // 
            // isadmin
            // 
            this.isadmin.FormattingEnabled = true;
            this.isadmin.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isadmin.Location = new System.Drawing.Point(454, 239);
            this.isadmin.Name = "isadmin";
            this.isadmin.Size = new System.Drawing.Size(330, 23);
            this.isadmin.TabIndex = 31;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 522);
            this.Controls.Add(this.isadmin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.staffid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.salarytxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbConfirm);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.AuthenticationID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SingUp_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SignUp_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.TextBox AuthenticationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label backBtn;
        private System.Windows.Forms.CheckBox cbPass;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox staffid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.ComboBox isadmin;
    }
}