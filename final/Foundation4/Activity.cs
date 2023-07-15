using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime date;
    private int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Length
    {
        get { return length; }
        set { length = value; }
    }
}
