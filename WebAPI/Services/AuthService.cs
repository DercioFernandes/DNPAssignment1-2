using System.Collections;
using Application.LogicInterfaces;
using Domain.Models;

namespace WebAPI.Services;

public class AuthService : IAuthService
{
    private readonly IUserLogic userLogic;
    
    
    
    public async Task<User> GetUser(string username, string password)
    {
        IEnumerable<User> users = await userLogic.GetAsync(null);
        User? existingUser = users.FirstOrDefault(u => 
            u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));
        
        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        if (!existingUser.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return existingUser;
    }

}