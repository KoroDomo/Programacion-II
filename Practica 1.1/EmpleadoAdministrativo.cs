public class EmpleadoAdministrativo : Empleado
{    public EmpleadoAdministrativo(string nombres, string apellidos, double sueldo, bool cumpleMeta) : base(nombres, apellidos, sueldo, cumpleMeta)
    {
        CalcularBono();
        CalcularSueldo();
    }   
}