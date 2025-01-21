using System;
public class Fraction
{
    private int topNumber;
    private int bottomNumber;


    public Fraction()
    {
        topNumber=1;
        bottomNumber=1;
    }

    public Fraction(int top)
    {
        topNumber= top;
        bottomNumber=1;
    }

    public Fraction(int top, int bottom)
    {
        topNumber= top;
        bottomNumber= bottom;
    }

    /*public int GetTop()
    {
        return topNumber;
    }

    public void SetTop(int top)
    {
        topNumber = top;
    }

    public int GetBottom()
    {
        return bottomNumber;
    }

    public void SetBottom(int bottom)
    {
        bottomNumber = bottom;
    }*/

    public string GetFractionString()
    {
        string text = $"{topNumber}/{bottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)topNumber / (double)bottomNumber;
    }




}