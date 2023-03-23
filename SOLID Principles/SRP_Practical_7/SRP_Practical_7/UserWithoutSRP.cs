using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SRP_Practical_7
{
    internal class UserWithoutSRP
    {
        private int Id { get; set; }
        private string? Name { get; set; }
        private string? Username { get; set; }
        private string? Password { get; set; }

        internal bool Login(string username, string password)
        {
            // fetched from database
            string fetchedUsername = "karan";
            string fetchedPasswoed = "karan@123";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                LogError("Empty username or password");
                return false;
            }
            if (username.Equals(fetchedUsername) && password.Equals(fetchedPasswoed))
            {
                LogSuccess("Login success");
                return true;
            }
            else
            {
                LogError("Invalid username or password");
                return false;
            }
        }

        internal bool Register(string username, string password, string name)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                LogError("Empty username, password or name");
                return false;
            }

            // save data to database
            LogSuccess("Registration success");
            SendEmail($"Hey, {username} Thank you for joining with us");
            return true;
        }

        private void LogError(string error)
        {
            Console.WriteLine($"Error: {error}");
        }
        private void LogSuccess(string message)
        {
            Console.WriteLine($"Success: {message}");
        }
        private bool SendEmail(string emailContent)
        {
            // send an email
            Console.WriteLine($"Email: {emailContent} has been sent");
            return true;
        }
    }
}
