public class Empleado
{
    protected string Nombres { get; set; }
    public string Apellidos { get; set; }
    public double Sueldo { get; set; }
    public int Id { get; set; }

    public bool cumpleMeta { get; set; }

    public double Bono { get; set; }

    public Empleado(string nombres, string apellidos)
    {
        Nombres = nombres;
        Apellidos = apellidos;
    }

    public Empleado(string nombres, string apellidos, double sueldo, bool cumpleMeta)
    {
        Nombres = nombres;
        Apellidos = apellidos;
        Sueldo = sueldo;
        this.cumpleMeta = cumpleMeta;       
    }

    public virtual void CalcularSueldo()
    {
        Sueldo += Bono;
    }
    public void CalcularBono()
    {
        /* Se calcula el bono dependiendo si cumple la meta o no. Si cumple la meta (true), el sueldo se duplica 
        (se paga el bono extra con valor a un sueldo), de lo contrario (false), se paga la mitad del bono.*/
        Bono = (cumpleMeta) ? Sueldo : Sueldo * 0.5;
    }

    public override string ToString()
    {
        return $"Nombres: {Nombres} {Apellidos}\nSueldo: {Sueldo}\nCumple Meta: {cumpleMeta}\nBono: {Bono}\n";
    }
}