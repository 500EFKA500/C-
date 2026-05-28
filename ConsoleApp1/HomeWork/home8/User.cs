using System;

class User
{
    public Permissions Role;

    public User(Permissions role)
    {
        Role = role;
    }

    public bool HasPermission(Permissions permission)
    {
        return Role.HasFlag(permission);
    }

    public void Grant(Permissions permission)
    {
        Role |= permission;
    }

    public void Revoke(Permissions permission)
    {
        Role &= ~permission;
    }

    public void PrintPermissions()
    {
        Console.WriteLine($"Права пользователя: {Role}");
    }
}
