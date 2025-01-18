
public class Estudiante : Persona{
    public int Matricula {get; set;}

    public Estudiante()
    {
        Nombre = "Fulano";
        Matricula = 0;
    }
    public Estudiante(String nombre, int matricula)
    {
        Nombre = nombre;
        Matricula = matricula;        
    }


    public override string ToString()
    {
        return "Nombre: " + Nombre + ", Matricula: " + Matricula;
    }
}