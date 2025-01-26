public class DocentePorHora : Empleado
{
    public int HorasTrabajadas { get; set; }
    public double Tarifa { get; set; }

    public DocentePorHora(string nombres, string apellidos, int horasTrabajadas) : base(nombres, apellidos)
    {
        this.HorasTrabajadas = horasTrabajadas;
        this.Tarifa = 800;
        CalcularSueldo();
    }

    public override void CalcularSueldo() // Se sobrescribe el metodo virtual CalcularSueldo para calcular el sueldo de un docente por hora.
    {
        this.Sueldo = HorasTrabajadas * Tarifa;
    }

    public override string ToString()
    {
        return $"Nombres: {Nombres} {Apellidos}\nSueldo: {this.Sueldo}\n";
    }
}