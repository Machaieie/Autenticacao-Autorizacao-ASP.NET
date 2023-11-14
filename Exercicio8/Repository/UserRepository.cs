using Exercicio8.Models;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio8.Repository
{
    public class UserRepository
    {
        public static Usuario Get(string username, string password)
        {
            var users = new List<Usuario>();
            users.Add(new Usuario { Id = 1, Username = "Edipson", Password = "Manguito", Role = "Employee" });
            users.Add(new Usuario { Id = 2, Username = "Leopoldo", Password = "banana", Role = "Employee" });
            users.Add(new Usuario { Id = 3, Username = "Radek", Password = "rdk", Role = "Manager" });
            users.Add(new Usuario { Id = 4, Username = "Edwin", Password = "edwin", Role = "Manager" });

            return users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower());
        }
    }
}
