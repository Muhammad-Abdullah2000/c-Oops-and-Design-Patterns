///// Interface Seggregation of Solid Principles

using Interface_Seggretion.src.Solid_Principles.Interface_Seggregation;

var circle = new Circle();
circle.Radius = 10;

System.Console.WriteLine($"Area of Circle: {circle.Area()}");
System.Console.WriteLine($"Volume of Circle: {circle.Volume()}");