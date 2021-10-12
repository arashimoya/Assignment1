using Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        User ValidateUser(string Username, string Password);
    }
}