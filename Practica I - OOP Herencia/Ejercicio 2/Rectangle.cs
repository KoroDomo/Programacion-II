public class Rectangle : Shape
{

    public Rectangle()
    {
        Ancho = 10;
        Alto = 5;
    }
    public override double CalculateSurface()
    {
        return Ancho * Alto;
    }
}