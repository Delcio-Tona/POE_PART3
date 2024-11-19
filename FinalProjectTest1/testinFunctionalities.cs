using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProjectTest1
{
    internal class testinFunctionalities
    {
        public bool Login(string username, string password)
        {
            string getuser = "Admin", getpassword = "admin";
            return (0 == String.Compare(username, getuser) && 0 == String.Compare(password, getpassword));
        }

        public bool Approval(string Decision) 
        {

            return (Decision == "Approved" || Decision == "Rejected");
        }

        public bool Claim(string claim)
        {
            string details = "Delcio";
            return (details==claim);
        }
    }
}