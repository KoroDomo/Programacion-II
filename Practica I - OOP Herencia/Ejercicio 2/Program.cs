internal class Program
{
    private static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Rectangle();
        shapes[1] = new Triangle();
        shapes[2] = new Circle();

        double[] areas = new double[3];
        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
        }

        foreach (var area in areas)
        {
            Console.WriteLine(area);
        }
    }
}