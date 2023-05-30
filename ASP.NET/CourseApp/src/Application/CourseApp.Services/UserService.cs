using CourseApp.Entities;

namespace CourseApp.Services
{
    public class UserService : IUserService
    {
        private List<User> users;

        public UserService()
        {
            users = new List<User>()
            {
                new(){ Id=1, Name="Türkay", Password="123", Email="abc@xyz.com", Role="Admin", UserName="turko"},
                new(){ Id=1, Name="Abdurrahman", Password="123", Email="abc@xyz.com", Role="Editor", UserName="avarol"},
                new(){ Id=1, Name="Alperen", Password="123", Email="abc@xyz.com", Role="Client", UserName="alp"},


            };
        }
        public User? ValidateUser(string username, string password)
        {
            return users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
