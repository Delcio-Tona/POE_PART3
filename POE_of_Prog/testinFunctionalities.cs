using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_of_Prog
{
    internal class testinFunctionalities
    {
        public bool Login (string username, string password)
        {
            string getuser = "Admin", getpassword = "admin";
            return (0 == String.Compare(username, getuser) && 0 == String.Compare(password, getpassword));
        }
    }
}
