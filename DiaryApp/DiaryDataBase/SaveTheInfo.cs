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
        // för att jag ska kunna spara kommentaren från användaren så behövde jag göra en query för att jag ska få tillbaka user Idfrån customer
        //alltså jag den metoden ska få en string Namn.
        //metoden ska använda det namnet för att utföra den query i sql där den väljer Id från tabellen customer. 
        // den gemför om det namnet som vi skickar till metoden finns sparade i databasen. finns det då  och det är typ 100% säkert den finns.
        //så sparar jag Id nummret i ett variabel som heter customerId. och sedan så använder jag det värdet för att till dela i till Id kolumn
        //som finns i tabellen Comments där jag hade problemet. 
        // för att jag ska skicka in användare namnet utan att begära av användaren att skriva sitt namn efter att hen har lagat in 
        // då valde jag att skicka in LoadData metoden som finns i from1.cs , eftersom den metoden använder GetUserName() metoden för att retunera 
        // och skriva användarens namn efter att de har loggat in. så ja, på det sättet namnet som skickas in i den metoden är 100% true den finns i
        //databasen. 
        public void SaveTheComment(string title, string commentCurrent, DateTime dateTim, string userName, string connectionString)
        {
            int customerId = 0;
            string _userName = userName;
            string queryuser = "SELECT Id FROM Customers WHERE userName = @userName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryuser, connection))
                {
                    command.Parameters.AddWithValue("@userName", _userName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerId = reader.GetInt32(0);
                        }
                    }
                }
            }

            using (var context = new AppContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var comment = new Comment()
                        {
                            title = title,
                            comment = commentCurrent,
                            CommentDate = DateTime.Now,
                            Id = customerId
                        };

                        context.Comments.Add(comment);
                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }
        //Kollar om användare namnet finns 
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

            return false; // Returnera false om användarnamnet inte hittades i databasen
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
