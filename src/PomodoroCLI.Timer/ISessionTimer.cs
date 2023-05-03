﻿namespace PomodoroCLI.Timer;
public interface ISessionTimer
{
    public void SetDuration(TimeSpan duration);
    public TimeSpan GetRemainingTime();
    public void SetTrigger(Action trigger);
    public void Start();
    public void Stop();
    public void Reset();
}
