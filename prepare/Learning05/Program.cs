using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Yellow", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 10, 7);
        shapes.Add(s2);

        Circle s3 = new Circle("Purple", 8);
        shapes.Add(s3);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();

            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}