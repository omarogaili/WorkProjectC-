using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryDataBase
{
    public class SaveTheInfo
    {

        // metod för att skapa ett konto
        public void SignUp(string username, string password)
        {
            Customer customer = new Customer();
            Password password1 = new Password();
            Comment coment = new Comment();
            //om username är rätt som jag vill ha så gå vidare och spara i databasen
            using (var _context = new AppContext())
            {
                var user = new Customer();
                //först spara user och till dela den ett PK
                user.userName = username;
                _context.Customers.Add(user);
                _context.SaveChanges();


                //om password är rätt som jag vill så spara den i database
                //sedan spara password

                var pass = new Password();
                pass.password = password;
                _context.Passwords.Add(pass);
                pass.Id = user.Id;
                _context.SaveChanges();

            }

        }
        public void SaveTheComment(string title,  string commentCurrent, DateTime dateTim, int customerId)
        {
            Comment coment= new Comment();
            using (var  context = new AppContext())
            {
                var existingCustomer = context.Customers.Find(customerId);
                var comment = new Comment()
                {
                    title = title,
                    comment = commentCurrent,
                    CommentDate = DateTime.Now,
                    Id = customerId
                };
                
                context.Comments.Add(comment);
                context.SaveChanges();
            }

        }
        public bool CheckingUserName(string username, string connectionString)
        {
            string _username = username;
            string queryuser = "SELECT username FROM Customers WHERE userName = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryuser, connection))
                {
                    command.Parameters.AddWithValue("@username", _username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }
            }

            return false; // Returnera null om användarnamnet inte hittades i databasen
        }
        //för infromation om användaren.  
        public string GetUserName(string username, string connectionString)
        {
            string _username = username;
            string queryuser = "SELECT username FROM Customers WHERE userName = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryuser, connection))
                {
                    command.Parameters.AddWithValue("@username", _username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(reader.GetOrdinal("username"));
                        }
                    }
                }
            }

            return null; // Returnera null om användarnamnet inte hittades i databasen
        }
        // Loga in i appen 
        public bool Login(string Username, string Password, string connectionString)
        {
            string _username = Username;
            string _password = Password;

            string query = "SELECT c.* FROM Customers c JOIN Passwords p ON c.Id = p.Id WHERE c.Username = @username AND p.Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", _username);
                    command.Parameters.AddWithValue("@password", _password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true; // Om match hittades  
                        }
                    }
                }
            }

            return false; // Om ingen match hittades  
        }

    }
}
