using System;

static class SeasonHelper
{
    public static Season GetSeason(Month month)
    {
        return month switch
        {
            Month.December or Month.January or Month.February => Season.Winter,
            Month.March or Month.April or Month.May => Season.Spring,
            Month.June or Month.July or Month.August => Season.Summer,
            _ => Season.Autumn
        };
    }

    public static Month[] GetMonths(Season season)
    {
        return season switch
        {
            Season.Winter => new[] { Month.December, Month.January, Month.February },
            Season.Spring => new[] { Month.March, Month.April, Month.May },
            Season.Summer => new[] { Month.June, Month.July, Month.August },
            Season.Autumn => new[] { Month.September, Month.October, Month.November },
            _ => Array.Empty<Month>()
        };
    }

    public static void PrintSeasonInfo(Season season)
    {
        Console.WriteLine($"Season: {season}");
        Console.WriteLine($"Months: {string.Join(", ", GetMonths(season))}");
    }
}
