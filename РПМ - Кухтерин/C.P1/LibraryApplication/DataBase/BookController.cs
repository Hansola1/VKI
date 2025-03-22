using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using LibraryApplication.Model;

namespace LibraryApplication.DataBase
{
    public class BookController : DBController
    {
        public List<Books> GetBook()
        {
            Connection();
            List<Books> ListBooks = new List<Books>();
            string query = "SELECT article_number, title, genre, description, issue_date, return_date, status, reader_id FROM Books";

            using (SqlCommand command = new(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListBooks.Add(new Books
                        {
                            ArticleNumber = reader["article_number"].ToString(),
                            Title = reader["title"].ToString(),
                            Genre = reader["genre"].ToString(),
                            Description = reader["description"].ToString(),
                            IssueDate = reader["issue_date"].ToString(),
                            ReturnDate = reader["return_date"].ToString(),
                            Status = reader["status"].ToString(),
                            ReaderName = reader["reader_id"].ToString(),
                        });
                    }
                }
            }
            return ListBooks;
        }

        public int? GetReaderNameById(string name)
        {
            Connection();

            string query = "SELECT reader_id FROM Readers WHERE reader_name = @reader_name";
            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@reader_name", name);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string readerID = $"{reader["reader_id"]}";
                        return Convert.ToInt32(readerID);
                    }
                }
            }
            return null; 
        }

        public void AddBook(string articleNumber, string title, string genre, string description, string issueDate, string returnDate, string status, int? reader_id)
        {
            Connection();
            string query = "INSERT INTO Books (article_number, title, genre, description, issue_date, return_date, status, reader_id) VALUES (@article_number, @title, @genre, @description, @issue_date, @return_date, @status, @reader_id)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@article_number", articleNumber);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@issue_date", issueDate);
                    command.Parameters.AddWithValue("@return_date", returnDate);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@reader_id", reader_id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Книга не добавлена: {ex.Message}");
            }
        }

        public int? GetBookArticleById(string articleNumber)
        {
            Connection();

            string query = "SELECT id FROM Books WHERE article_number = @article_number";
            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@article_number", articleNumber);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string idBook = $"{reader["id"]}";
                        return Convert.ToInt32(idBook);
                    }
                }
            }
            return null;
        }

        public void EditBook(string articleNumber, string title, string genre, string description, string issueDate, string returnDate, string status, int? reader_id)
        {
            Connection();
            int? IDBook = GetBookArticleById(articleNumber);
            string query = "UPDATE Books SET article_number = @article_number, title = @title, genre = @genre, description = @description, issue_date = @issue_date, return_date = @return_date, status = @status, reader_id = @reader_id WHERE id = @IDBook";


            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@article_number", articleNumber);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@genre", genre);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@issue_date", issueDate);
                command.Parameters.AddWithValue("@return_date", returnDate);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@reader_id", reader_id);
                command.Parameters.AddWithValue("@IDBook", IDBook.Value);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteBook(string articleNumber)
        {
            Connection();

            if (articleNumber != null)
            {
                string query = "DELETE FROM Books WHERE \"article_number\" = @article_number";

                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@article_number", articleNumber);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
