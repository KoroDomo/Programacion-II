using Principios.DRY;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
        string employeeType = Console.ReadLine();

        Payroll payroll;

        if (employeeType == "1")
        {
            Console.Write("Ingrese el salario base: ");
            decimal baseSalary = decimal.Parse(Console.ReadLine());
            payroll = new Payroll(baseSalary);
        }
        else if (employeeType == "2")
        {
            Console.Write("Ingrese el sueldo por hora: ");
            decimal hourlyRate = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese las horas trabajadas: ");
            int hoursWorked = int.Parse(Console.ReadLine());

            payroll = new Payroll(hourlyRate, hoursWorked);
        }
        else
        {
            Console.WriteLine("Opcion invalida");
            return;
        }

        decimal salary = payroll.calculateSalary();
        Console.WriteLine($"\nSalario neto despues de impuestos y bono: {salary}");  
    }
}
