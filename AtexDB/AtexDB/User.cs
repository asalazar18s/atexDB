using System;
namespace AtexDB
{
    public class User
    {
        private String name;
        private String password;
        private String clearance;

        public User(String cName, String cPassword, String cClearance)
        {
            name = cName;
            password = cPassword;
            clearance = cClearance;
        }
        // get set methods
        public string Name 
        {
            get { return name;}
            set { name = value;}
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Clearence
        {
            get { return clearance; }
            set { clearance = value; }
        }
        // methods


    }
}
