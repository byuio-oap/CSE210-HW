using System;

public class Square : Shape
{
    // Attributes 
    private double _side = 0;
    // Constructors
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }


    // Methods
    public override double GetArea()
    {
        return _side * _side;
    }

}