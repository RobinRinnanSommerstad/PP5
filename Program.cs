using PP5;

Run();
void Run()
{
    var shapesList = new List<Shape>()
    {
        new Square(10, "Kvadrat"),
        new Circle(8, "Sirkel"),
        new Triangle(7.5, 4, 9, 4, "Trekant"),
        new Rectangle(10, 5, "Rektangle"),
    };


    while (true)
    {
        Console.Clear();
        foreach (var shape in shapesList)
        {
            Console.WriteLine($@"
Navn: {shape.Name}
Bredde: {(shape.Width)}
Areal: {shape.getArea()}
Omkrets: {shape.getCircumference()}
");
        }

        Console.WriteLine
            (@"
1. Triangle
2. Rectangle
3. Square
4. Circle");
        var input = Console.ReadLine();

        Console.Clear();
        if (input == "1") shapesList.Add(new MakeShape().makeTriangle());
        else if (input == "2") shapesList.Add(new MakeShape().makeRectangle());
        else if (input == "3") shapesList.Add(new MakeShape().makeSquare());
        else if (input == "4") shapesList.Add(new MakeShape().makeCircle());
        else continue;
    }


}
