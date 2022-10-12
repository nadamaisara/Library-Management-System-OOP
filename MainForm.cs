using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReaderInfo reader = new ReaderInfo();
            reader.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibrariansForm librarians = new LibrariansForm();
            librarians.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorrowBooksForm borrow = new BorrowBooksForm();
            borrow.Show();
            this.Hide();
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            Reports Rep = new Reports();
            Rep.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StoredProcedures Rep = new StoredProcedures();
            Rep.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PublisherDGV reader = new PublisherDGV();
            reader.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FirstForm first = new FirstForm();
            first.Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard board = new Dashboard();
            board.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TipsForm tips = new TipsForm();
            tips.Show();
            this.Hide();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ReaderInfo readers = new ReaderInfo();
            readers.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PublisherDGV publisherDGV = new PublisherDGV();
            publisherDGV.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LibrariansForm librarians = new LibrariansForm();
            librarians.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BorrowBooksForm borrow = new BorrowBooksForm();
            borrow.Show();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            StoredProcedures sp = new StoredProcedures();
            sp.Show();
            this.Hide();
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
