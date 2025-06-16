using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibraryApp.Models;

namespace LibraryApp.DAL
{
    public class BookDAL : DbHelper
    {
        public bool AddBook(Book book)
        {
            string query = "INSERT INTO Books (Title, AuthorID, PublicationYear) VALUES (@Title, @AuthorID, @PublicationYear)";
            using (SqlCommand cmd = new SqlCommand(query, base.connection))
            {
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@AuthorID", book.AuthorID);
                cmd.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);

                try
                {
                    OpenConnection();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("خطأ في إضافة الكتاب: " + ex.Message, "خطأ",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    CloseConnection();
                }
            }
        }
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            string query = @"SELECT b.BookID, b.Title, b.AuthorID, b.PublicationYear,
                            a.FirstName AS AuthorFirstName, a.LastName AS AuthorLastName, a.Age AS AuthorAge
                     FROM Books b
                     INNER JOIN Authors a ON b.AuthorID = a.AuthorID";

            using (SqlCommand cmd = new SqlCommand(query, base.connection))
            {
                try
                {
                    OpenConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book
                            {
                                BookID = Convert.ToInt32(reader["BookID"]),
                                Title = reader["Title"].ToString(),
                                AuthorID = Convert.ToInt32(reader["AuthorID"]),
                                PublicationYear = Convert.ToInt32(reader["PublicationYear"]),
                                Author = new Author
                                {
                                    AuthorID = Convert.ToInt32(reader["AuthorID"]),
                                    FirstName = reader["AuthorFirstName"].ToString(),
                                    LastName = reader["AuthorLastName"].ToString(),
                                    Age = Convert.ToInt32(reader["AuthorAge"])
                                }
                            };
                            books.Add(book);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("حدث خطأ عند جلب الكتب: " + ex.Message, "خطأ",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }
            }
            return books;
        }
    }
}