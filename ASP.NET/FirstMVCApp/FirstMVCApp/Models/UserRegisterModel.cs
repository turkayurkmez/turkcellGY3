using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class UserRegisterModel
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
