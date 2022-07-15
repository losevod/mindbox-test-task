// See https://aka.ms/new-console-template for more information
using ShapesLibrary;

var circle = new Circle(20);
var triangle = new Triangle(3, 4, 5);

Console.WriteLine($"Area of the triangle = {triangle.CalculateArea()}");

if(triangle.IsRightTriangle())
{
    Console.WriteLine("This triangle is rectangular");
};

Console.WriteLine($"Area of the circle = {circle.CalculateArea()}");


