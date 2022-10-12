
namespace MyLibrary
{
    partial class BorrowBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBooksForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BRFName = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Borro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BKName = new System.Windows.Forms.ComboBox();
            this.BID = new System.Windows.Forms.DataGridView();
            this.Bissued = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BRLname = new System.Windows.Forms.RichTextBox();
            this.borrowFrom = new System.Windows.Forms.RichTextBox();
            this.borrowTo = new System.Windows.Forms.RichTextBox();
            this.actual = new System.Windows.Forms.RichTextBox();
            this.borrowerID = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.BEmail = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 128);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(8, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 66);
            this.button5.TabIndex = 83;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1268, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(569, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Borrow Books Info";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Library Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 680);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 40);
            this.panel2.TabIndex = 40;
            // 
            // BRFName
            // 
            this.BRFName.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BRFName.Location = new System.Drawing.Point(265, 169);
            this.BRFName.Name = "BRFName";
            this.BRFName.Size = new System.Drawing.Size(204, 32);
            this.BRFName.TabIndex = 50;
            this.BRFName.Text = "";
            this.BRFName.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Book Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Borro
            // 
            this.Borro.AutoSize = true;
            this.Borro.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Borro.Location = new System.Drawing.Point(7, 141);
            this.Borro.Name = "Borro";
            this.Borro.Size = new System.Drawing.Size(144, 25);
            this.Borro.TabIndex = 46;
            this.Borro.Text = "Borrower ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Borrow From Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "Borrower First Name:";
            // 
            // BKName
            // 
            this.BKName.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BKName.FormattingEnabled = true;
            this.BKName.Location = new System.Drawing.Point(266, 290);
            this.BKName.Name = "BKName";
            this.BKName.Size = new System.Drawing.Size(203, 25);
            this.BKName.TabIndex = 65;
            this.BKName.SelectedIndexChanged += new System.EventHandler(this.BKName_SelectedIndexChanged);
            // 
            // BID
            // 
            this.BID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BID.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BID.DefaultCellStyle = dataGridViewCellStyle2;
            this.BID.EnableHeadersVisualStyles = false;
            this.BID.GridColor = System.Drawing.Color.DarkOrchid;
            this.BID.Location = new System.Drawing.Point(667, 141);
            this.BID.Name = "BID";
            this.BID.RowHeadersWidth = 51;
            this.BID.RowTemplate.Height = 25;
            this.BID.Size = new System.Drawing.Size(680, 533);
            this.BID.TabIndex = 66;
            this.BID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorrowDGV_CellContentClick);
            // 
            // Bissued
            // 
            this.Bissued.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bissued.Location = new System.Drawing.Point(265, 454);
            this.Bissued.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bissued.Name = "Bissued";
            this.Bissued.Size = new System.Drawing.Size(204, 34);
            this.Bissued.TabIndex = 71;
            this.Bissued.Text = "";
            this.Bissued.TextChanged += new System.EventHandler(this.Bissued_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "Issued By :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Actual Return Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Borrow To Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Borrower Last Name:";
            // 
            // BRLname
            // 
            this.BRLname.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BRLname.Location = new System.Drawing.Point(265, 211);
            this.BRLname.Name = "BRLname";
            this.BRLname.Size = new System.Drawing.Size(204, 32);
            this.BRLname.TabIndex = 76;
            this.BRLname.Text = "";
            // 
            // borrowFrom
            // 
            this.borrowFrom.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowFrom.Location = new System.Drawing.Point(265, 326);
            this.borrowFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowFrom.Name = "borrowFrom";
            this.borrowFrom.Size = new System.Drawing.Size(204, 35);
            this.borrowFrom.TabIndex = 78;
            this.borrowFrom.Text = "";
            this.borrowFrom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.borrowFrom_MouseClick);
            this.borrowFrom.MouseHover += new System.EventHandler(this.borrowFrom_MouseHover);
            // 
            // borrowTo
            // 
            this.borrowTo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowTo.Location = new System.Drawing.Point(265, 371);
            this.borrowTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowTo.Name = "borrowTo";
            this.borrowTo.Size = new System.Drawing.Size(204, 39);
            this.borrowTo.TabIndex = 79;
            this.borrowTo.Text = "";
            this.borrowTo.MouseHover += new System.EventHandler(this.borrowTo_MouseHover);
            // 
            // actual
            // 
            this.actual.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actual.Location = new System.Drawing.Point(265, 416);
            this.actual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actual.Name = "actual";
            this.actual.Size = new System.Drawing.Size(204, 34);
            this.actual.TabIndex = 80;
            this.actual.Text = "";
            this.actual.MouseHover += new System.EventHandler(this.actual_MouseHover);
            // 
            // borrowerID
            // 
            this.borrowerID.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowerID.Location = new System.Drawing.Point(265, 134);
            this.borrowerID.Name = "borrowerID";
            this.borrowerID.Size = new System.Drawing.Size(204, 25);
            this.borrowerID.TabIndex = 81;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SaddleBrown;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.Location = new System.Drawing.Point(443, 626);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(218, 46);
            this.button8.TabIndex = 85;
            this.button8.Text = "Delete Borrower";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SaddleBrown;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Gainsboro;
            this.button7.Location = new System.Drawing.Point(214, 626);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 46);
            this.button7.TabIndex = 84;
            this.button7.Text = "Update Borrower";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SaddleBrown;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Gainsboro;
            this.button9.Location = new System.Drawing.Point(12, 626);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(193, 46);
            this.button9.TabIndex = 83;
            this.button9.Text = "Add Borrower";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(225, 503);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 50);
            this.button6.TabIndex = 86;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(454, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 89;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Maroon;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.Gainsboro;
            this.button10.Location = new System.Drawing.Point(265, 570);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 50);
            this.button10.TabIndex = 88;
            this.button10.Text = "Edit";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Maroon;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.Gainsboro;
            this.button11.Location = new System.Drawing.Point(37, 570);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 50);
            this.button11.TabIndex = 87;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // BEmail
            // 
            this.BEmail.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BEmail.Location = new System.Drawing.Point(265, 248);
            this.BEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEmail.Name = "BEmail";
            this.BEmail.Size = new System.Drawing.Size(204, 34);
            this.BEmail.TabIndex = 91;
            this.BEmail.Text = "";
            this.BEmail.Leave += new System.EventHandler(this.BEmail_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 90;
            this.label10.Text = "Borrower Email:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Format: YYYY-MM-DD";
            // 
            // BorrowBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.BEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.borrowerID);
            this.Controls.Add(this.actual);
            this.Controls.Add(this.borrowTo);
            this.Controls.Add(this.borrowFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BRLname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Bissued);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.Borro);
            this.Controls.Add(this.BKName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BRFName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBooksForm";
            this.Load += new System.EventHandler(this.BorrowBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox BRFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Borro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BKName;
        private System.Windows.Forms.DataGridView BID;
        private System.Windows.Forms.RichTextBox Bissued;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox BRLname;
        private System.Windows.Forms.RichTextBox borrowFrom;
        private System.Windows.Forms.RichTextBox borrowTo;
        private System.Windows.Forms.RichTextBox actual;
        private System.Windows.Forms.TextBox borrowerID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.RichTextBox BEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}