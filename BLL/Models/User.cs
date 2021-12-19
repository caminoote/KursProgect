using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserModel
    {
        public int IdUser { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Role { get; set; }

        public UserModel() { }
        public UserModel(User p)
        {
            IdUser = p.IdUser;
            Login = p.Login;
            Password = p.Password;
            FirstName = p.FirstName;
            SecondName = p.SecondName;
            Role = p.Role;
        }

    }
}
