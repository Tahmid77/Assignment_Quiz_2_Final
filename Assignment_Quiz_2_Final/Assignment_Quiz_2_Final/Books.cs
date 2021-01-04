using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Quiz_2_Final
{
    public class Books
    {
        SqlConnection conn;
        public Books()
        {
        }
        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }
        public ArrayList GetAllBooks()
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));

                books.Add(book);
            }
            conn.Close();
            return books;
        }
        public ArrayList GetBook(string name)
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = String.Format("SELECT * FROM Books WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;
            while (reader.Read())
            {
                book = new Book();
                book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(book);
            }
            conn.Close();
            return books;
        }
    }
}
