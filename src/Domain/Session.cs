using System;

namespace Pomogotchi.Domain
{
    public class Session
    {
        public enum SessionType
        {
            Work,
            Break
        }

        SessionType _type;

        public SessionType Type => _type;

        TimeSpan _duration;

        public TimeSpan Duration => _duration;

        public Session(TimeSpan duration, SessionType type)
        {
            _type = type;
            _duration = duration;
        }
    }
}