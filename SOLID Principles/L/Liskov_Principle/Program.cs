///// Liskov's Substitution Method/Principle


using Liskov_Principle.src.Solid_Principles.Liskovs_Principle;

// var rect = new Square();
// rect.Height = 10;
// rect.Width = 5;

// System.Console.WriteLine(rect.Area);

Shape rectangle = new Reactangle { Width = 5, Height = 4 };
System.Console.WriteLine($"Area of Rectangle is: {rectangle.Area}");

Shape square = new Square { SideLength = 5 };
System.Console.WriteLine($"Area of Square is: {square.Area}");

