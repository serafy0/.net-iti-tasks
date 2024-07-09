namespace task_5;

class Duration
{
    public int Hours { get; set; }

    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Duration()
    {
        Hours = 0;
        Minutes = 0;
        Seconds = 0;
    }

    public Duration(int _hours, int _minutes, int _seconds)
    {
        while (_seconds >= 60)
        {
            _seconds = _seconds - 60;
            _minutes++;
        }
        while (_minutes >= 60)
        {
            _minutes = _minutes - 60;
            _hours++;
        }
        Hours = _hours;
        Minutes = _minutes;
        Seconds = _seconds;
    }

    public Duration(int _seconds)
    {
        int _hours = 0;
        int _minutes = 0;
        while (_seconds >= 60)
        {
            _seconds = _seconds - 60;
            _minutes++;
        }
        while (_minutes >= 60)
        {
            _minutes = _minutes - 60;
            _hours++;
        }
        Hours = _hours;
        Minutes = _minutes;
        Seconds = _seconds;
    }

    public override bool Equals(object? obj)
    {
        var right = obj as Duration;

        if (right is null)
            return false;

        if (object.ReferenceEquals(right, this))
            return true;

        if (right.GetType() != this.GetType())
        {
            return false;
        }

        return this.Hours == right.Hours
            && this.Minutes == right.Minutes
            && this.Seconds == right.Seconds;
    }

    public override string ToString()
    {
        return $"Hours:{Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
    }

    public static Duration operator +(Duration right, Duration left)
    {
        return new Duration(
            right.Hours + left.Hours,
            right.Minutes + left.Minutes,
            right.Seconds + left.Seconds
        );
    }

    public static Duration operator +(int right, Duration left)
    {
        return new Duration(left.Hours, left.Minutes, right + left.Seconds);
    }

    public static Duration operator +(Duration right, int left)
    {
        return new Duration(right.Hours, right.Minutes, right.Seconds + left);
    }

    public static Duration operator ++(Duration _duration)
    {
        return new Duration(_duration.Hours, _duration.Minutes + 1, _duration.Seconds);
    }

    public static Duration operator --(Duration _duration)
    {
        return new Duration(_duration.Hours, _duration.Minutes - 1, _duration.Seconds);
    }

    public static bool operator >(Duration right, Duration left)
    {
        return right.getSeconds() > left.getSeconds();
    }

    public static bool operator <(Duration right, Duration left)
    {
        return right.getSeconds() < left.getSeconds();
    }

    public static bool operator >=(Duration right, Duration left)
    {
        return right.getSeconds() >= left.getSeconds();
    }

    public static bool operator <=(Duration right, Duration left)
    {
        return right.getSeconds() <= left.getSeconds();
    }

    public static Duration operator -(Duration right, Duration left)
    {
        return new Duration(
            right.Hours - left.Hours,
            right.Minutes - left.Minutes,
            right.Seconds - left.Seconds
        );
    }

    public static Duration operator *(Duration right, Duration left)
    {
        return new Duration(
            right.Hours * left.Hours,
            right.Minutes * left.Minutes,
            right.Seconds * left.Seconds
        );
    }

    public static Duration operator /(Duration right, Duration left)
    {
        return new Duration(
            right.Hours / left.Hours,
            right.Minutes / left.Minutes,
            right.Seconds / left.Seconds
        );
    }

    public static explicit operator DateTime(Duration _duration)
    {
        DateTime _dataTime = new();

        return _dataTime.AddSeconds(_duration.getSeconds());
        ;
    }

    private int getSeconds()
    {
        int newMinutes = Minutes + (Hours * 60);
        int newSeconds = Seconds + (newMinutes * 60);

        return newSeconds;
    }
}
