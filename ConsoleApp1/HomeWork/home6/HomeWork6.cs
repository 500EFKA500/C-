using System;

static class HomeWork6
{
    public static void Run()
    {
        Console.WriteLine("Таймер запущен на 3 секунды");
        TimerHelper.DoAfter(() => Console.WriteLine("Действие выполнено через 3 секунды"), 3);

        AlarmClock alarmClock = new AlarmClock();
        alarmClock.AlarmRang += () => Console.WriteLine("Будильник сработал");

        DateTime alarmTime = DateTime.Now.AddSeconds(5);
        alarmClock.SetAlarm(alarmTime);

        Console.WriteLine($"Будильник установлен на {alarmTime:HH:mm:ss}");
        alarmClock.Start();
    }
}
