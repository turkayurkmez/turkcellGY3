namespace Events
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }

    public class UserCreatedEventArgs : EventArgs
    {
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UserService
    {

        private List<User> _users = new List<User>();
        //public delegate void UserCreatedEventHandler(object sender, UserCreatedEventArgs e);
        public event EventHandler<UserCreatedEventArgs> UserCreated;
        //Yeni kullanıcı oluşturulduğunda event fırlatmaya karar verdiniz!
        public void CreateUser(User user)
        {
            // TODO 01: Kullanıcı oluşturuldu event'i burada fırlayacak!
            if (UserCreated != null)
            {
                UserCreatedEventArgs arg = new UserCreatedEventArgs
                {
                    User = user,
                    CreatedDate = DateTime.Now
                };
                UserCreated(this, arg);
            }
        }


        public void AddUser(User user) => _users.Add(user);

        public bool IsEmpty() => _users.Count == 0;

        public void Clear() => _users.Clear();






    }
}
