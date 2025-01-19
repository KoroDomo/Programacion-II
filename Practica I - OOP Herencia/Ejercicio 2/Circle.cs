using System.Formats.Asn1;

public class Circle : Shape{
    private double radio;
    public Circle()
    {
        Ancho = 4;
        Alto = 4;
        radio = this.Ancho / 2;
    }

    public override double CalculateSurface()
    {
        return Math.Round(Math.PI * Math.Pow(radio, 2), 2);
    }
}