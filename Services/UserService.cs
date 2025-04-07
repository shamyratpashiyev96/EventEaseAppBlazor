using EventEaseApp.Data.Models;

namespace EventEaseApp.Services;

public interface IUserService
{
    void AddUser(RegisteredUser newUser);
    List<RegisteredUser> GetUserList();
};

public class UserService : IUserService
{
    private List<RegisteredUser> RegisteredUsersList = new();

    public void AddUser(RegisteredUser newUser)
    {
        RegisteredUsersList.Add(newUser);
    }

    public List<RegisteredUser> GetUserList()
    {
        return RegisteredUsersList;
    }
}