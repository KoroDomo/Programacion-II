internal class Program
{
    private static void Main(string[] args)
    {
        DocentePorHora docente = new DocentePorHora("Juan", "Perez", 176);
        DocenteContratoFijo docente2 = new DocenteContratoFijo("Maria", "Gomez", 160000, false);
        EmpleadoAdministrativo empleado = new EmpleadoAdministrativo("Pedro", "Gonzalez", 200000, true);

        Console.WriteLine(docente.ToString());
        Console.WriteLine(docente2.ToString());
        Console.WriteLine(empleado.ToString());
    }
}