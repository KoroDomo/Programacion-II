public class Triangle : Shape{

    public Triangle()
    {
        Ancho = 7;
        Alto = 5;
    }
    public override double CalculateSurface()
    {
        return Ancho * Alto / 2;
    }
}