using System;

static class HomeWork8
{
    public static void Run()
    {
        Console.WriteLine("Времена года");
        Season season = SeasonHelper.GetSeason(Month.January);
        Console.WriteLine($"January относится к сезону {season}");
        SeasonHelper.PrintSeasonInfo(Season.Summer);

        Console.WriteLine();
        Console.WriteLine("Права доступа");

        User user = new User(Permissions.Read);
        user.PrintPermissions();

        user.Grant(Permissions.Write);
        user.Grant(Permissions.Delete);
        user.PrintPermissions();

        Console.WriteLine($"Есть право Write: {user.HasPermission(Permissions.Write)}");

        user.Revoke(Permissions.Delete);
        user.PrintPermissions();
    }
}
