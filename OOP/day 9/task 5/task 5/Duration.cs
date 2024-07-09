namespace task_5;

class Duration
{
    public int Hours { get; set; }

    public int Minutes { get; set; }
    public int Seconds { get; set; }

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
}
