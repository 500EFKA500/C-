using System;
using System.Threading;

class AlarmClock
{
    public event Action? AlarmRang;

    private DateTime alarmTime;

    public void SetAlarm(DateTime time)
    {
        alarmTime = time;
    }

    public void Start()
    {
        while (DateTime.Now < alarmTime)
        {
            Thread.Sleep(1000);
        }

        AlarmRang?.Invoke();
    }
}
