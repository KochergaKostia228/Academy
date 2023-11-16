using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Академія.Domain.Teacher
{
    public class Teacher
    {
        private string name;
        private string surname;
        private string username;
        private string password;

        public Teacher(string name, string surname, string username, string password)
        {
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
        }

        public string GetName() { return name; }
        public string GetSurname() { return surname; }
        public string GetUsername() { return username; }
        public string GetPassword() { return password; }
    }
}
