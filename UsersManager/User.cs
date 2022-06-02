using System;

namespace UsersManager
{
    class User
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime registered { get; set; }

        public User(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.registered = DateTime.Now;
        }

        public string vars()
        {
            return $"username : { this.username } \nemail : { this.email } \npassword :  { this.password } \nregistered : { this.registered }";
        }
    }
}
