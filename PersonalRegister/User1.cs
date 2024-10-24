using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class User1
    {
        string username = "admin";
        string password = "password";

        public Boolean checkLogin(string uName, string pw)
        {
            if (uName == username && pw == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
