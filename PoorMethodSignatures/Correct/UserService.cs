using System.Collections.Generic;

namespace PoorMethodSignatures
{
    public class UserService
    {

        public List<User> Users { get; set; } = new List<User>(){
                                                                    new User
                                                                    {
                                                                        Username = "username",
                                                                        Password = "password",
                                                                        LastLogin = DateTime.Now
                                                                    }
                                                                };

        public User Login(string username, string password)
        {
            var user = Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
                user.LastLogin = DateTime.Now;

            return user;
        }

        public User GetUser(string username)
        {
            var user = Users.SingleOrDefault(u => u.Username == username);

            return user;
        }
    }
}