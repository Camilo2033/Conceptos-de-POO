using System.Net.Http.Headers;

namespace ConceptosPOO.Core;

public class Date
{
    private int _day;
    private int _month;
    private int _year;

    public Date()
    {
        Year = 2024;
        Month = 1;
        Day = 1;
    }

    public Date(int day, int month, int year)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public int Day
    {
        get
        {
            return _day;
        }
        set
        {
            _day = ValidateDay(value);
        }
    }
    public int Month
    {
        get
        {
            return _month;
        }
        set
        {
            _month = ValidateMonth(value);
        }
    }

    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            _year = ValideteYear(value);
        }
    }

    override public string ToString()
    {
        return $"{Day:00}/{Month:00}/{Year:0000}";
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    private int ValideteYear(int year)
    {
        if (year < 0)
        {
            throw new Exception("El año no puede ser negativo.");
        }
        return year;
    }

    public int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new Exception($"El mes: {month} no es valido, el mes debe estar entre 1 y 12.");
        }
        return month;
    }

    public int ValidateDay(int day)
    {
        // Only validate the day value. Month/Year validation is handled elsewhere (ValidateMonth/ValideteYear).
        int daysInMonth = DateTime.DaysInMonth(Year, Month); // assumes Month and Year are already valid

        if (day < 1 || day > daysInMonth)
        {
            throw new Exception($"El día: {day} no es valido para el mes: {Month} y el año: {Year}.");
        }

        return day;
    }
}



