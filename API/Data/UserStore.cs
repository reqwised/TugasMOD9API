using WebApplication1.Models.Dto;

namespace WebApplication1.Data
{
    public static class UserStore
    {
        public static List<UserDTO> userList = new List<UserDTO>
        {
             new UserDTO{Id=1, Username="Afrizal", Password="321"},
             new UserDTO{Id=2, Username="Eka", Password="123"},
             new UserDTO{Id=3, Username="Purnama", Password="111"}
        };

    }
}
