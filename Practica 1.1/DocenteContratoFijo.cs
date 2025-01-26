public class DocenteContratoFijo : Empleado
{    public DocenteContratoFijo(string nombres, string apellidos, double sueldo, bool cumpleMeta) : base(nombres, apellidos, sueldo, cumpleMeta)
    {
        CalcularBono();
        CalcularSueldo();
    }
}