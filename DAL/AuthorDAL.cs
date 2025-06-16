using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryApp.DAL
{
    public class AuthorDAL : DbHelper 
    {

        public bool AddAuthor(Author author)
        {
            string query = "INSERT INTO Authors (FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)";
            using (SqlCommand cmd = new SqlCommand(query, base.connection))
            {
                cmd.Parameters.AddWithValue("@FirstName", author.FirstName);
                cmd.Parameters.AddWithValue("@LastName", author.LastName);
                cmd.Parameters.AddWithValue("@Age", author.Age);

                try
                {
                    OpenConnection();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("خطأ في إضافة المؤلف: " + ex.Message, "خطأ",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public List<Author> GetAll()
        {
            var list = new List<Author>();
            try
            {
                OpenConnection();
             

                string sql = "SELECT * FROM Authors";
                using var cmd = new SqlCommand(sql, connection);
                using var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    list.Add(new Author
                    {
                        AuthorID = rdr.GetInt32(0),
                        FirstName = rdr.GetString(1),
                        LastName = rdr.GetString(2),
                        Age = rdr.GetInt32(3)
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ DB error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return list;
        }



    }
}