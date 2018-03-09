using System;
using System.Collections.Generic;
namespace AtexDB

{
    public class UserController
    {
        private List<User> Users;
        public UserController(List<User> users)
        {
            Users = users;
        }

        public List<User> users{
            get{ return Users; }
            set { Users = value; }
        }

        public int GetUser(String userName)
        {
            int index;
            index = 404;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Name == userName)
                {
                    index = i;
                }
     
            }
            return index;

        }

        public int CheckClearance(User checker)
        {
            String userClearance;
            userClearance = checker.Clearence;
            if (userClearance == "admin")
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
