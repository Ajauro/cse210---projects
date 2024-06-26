using System;

//class to hold fraction
//should be in its own file
public class Fraction
{   
    //two attributes for the top and bottom numbers
    //the attributes are private
    private int _top;
    private int _bottom;

    //Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    //Constructor that has one parameter for the top and that initializes 
    //the denominator to 1. So that if you pass in the number 5, the fraction 
    //would be initialized to 5/1.
    public Fraction( int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    //Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction( int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    //Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    //Create a method called GetDecimalValue that returns a double that is the result 
    //of dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}