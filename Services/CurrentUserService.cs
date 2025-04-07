using EventEaseApp.Data.Models;

namespace EventEaseApp.Services;

public interface ICurrentUserService
{
    void SetCurrentUser(RegisteredUser registeredUser);
    RegisteredUser? GetCurrentUser();
}

public class CurrentUserService : ICurrentUserService
{
    private RegisteredUser? CurrentUser { get; set; } = null;

    private readonly IUserService _userService;

    public CurrentUserService(IUserService userService)
    {
        _userService = userService;
    }

    public void SetCurrentUser(RegisteredUser registeredUser)
    {
        CurrentUser = registeredUser;
        _userService.AddUser(registeredUser);
    }

    public RegisteredUser? GetCurrentUser()
    {
        return CurrentUser;
    }
}