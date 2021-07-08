using System;

public class UserService
{
    private UserService()
    {
    }

    public static UserService Instance => new UserService();

    public User GetCurrentUser()
    {
        return new User { Mail = "test@mail.ru", PhoneNumber = "+38066228100" };
    }
}
