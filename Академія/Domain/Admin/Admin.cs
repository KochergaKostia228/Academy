using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Академія.Domain.Admin
{
    public class Admin
    {
        private string username = "admin";
        private string password = "admin";

        public string GetUsername() { return username; }
        public string GetPassword() { return password; }
    }
}
