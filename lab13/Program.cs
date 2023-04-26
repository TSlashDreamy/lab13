using lab13;

// Variant #8
QuadCollection collection = new QuadCollection();
try
{
    collection.Add(new Parallelogram(10, 5));
    collection.Add(new Rectangle(6, 8));
    collection.Add(new Square(4));
    collection.Add(new Rhombus(8, 6));
}
catch (Exception exc)
{
    Console.WriteLine($"Wrong object creation: {exc}");
}

Console.WriteLine("Total objects: {0}", collection.Count());
Console.WriteLine("Total area: {0}", collection.TotalArea());
Console.WriteLine("Removing {0}", collection.Remove().GetType().Name);
Console.WriteLine("Total objects: {0}", collection.Count());
Console.WriteLine("Total area: {0}", collection.TotalArea());
