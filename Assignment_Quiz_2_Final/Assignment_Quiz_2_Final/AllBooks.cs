using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Quiz_2_Final
{
    public partial class AllBooks : Form
    {
        static Database db = new Database();
        public AllBooks()
        {
            InitializeComponent();

            var books = db.Books.GetAllBooks();
            dataGridView1.DataSource = books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            var book = db.Books.GetBook(name);
            if (book.Equals(null))
            {
                MessageBox.Show("No Book found");

            }
            else
            {
                
                dataGridView1.DataSource = book;
            }
        }
    }
}
