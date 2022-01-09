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

        public User GetUser(string username, string password, bool login)
        {
            if (login)
            {
                var user = Users.SingleOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                    user.LastLogin = DateTime.Now;

                return user;
            }
            else
            {
                var user = Users.SingleOrDefault(u => u.Username == username);

                return user;
            }
        }
    }
}