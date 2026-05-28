using System;
using System.Threading;

static class TimerHelper
{
    public static void DoAfter(Action action, int seconds)
    {
        Thread.Sleep(seconds * 1000);
        action();
    }
}
