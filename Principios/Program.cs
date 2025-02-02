using Principios;

internal class Program
{
    private static void Main(string[] args)
    {

        //KISS
        /*
        Console.Write("Ingrese los precios de los platos (separados por comas): ");
        decimal[] prices = Console.ReadLine().Split(',').Select(decimal.Parse).ToArray();

        Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
        string response = Console.ReadLine().Trim().ToLower();

        decimal? tipPercentage = null;
        if (response == "s")
        {
            Console.Write("Ingrese el porcentaje de propina: ");
            tipPercentage = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine($"\nTotal a pagar: {RestaurantBill.CalculateTotal(prices, tipPercentage)}");
        */

        //DRY
        /*
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
        */

        //YAGNI
        /*
        Console.WriteLine("Seleccione una opcion: ");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Eliminar producto");
        string option = Console.ReadLine();
        ProductService ps = new ProductService();
        string nombre;
        decimal precio;
        string id;
        switch (option)
        {

            case "1":
                Console.WriteLine("Ingrese el nombre del producto: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto: ");
                precio = decimal.Parse(Console.ReadLine());
                ps.AddProduct(nombre, precio);
                break;
            case "2":
                Console.WriteLine("Ingrese el ID del producto: ");
                id = Console.ReadLine();
                ps.DeleteProduct(id);
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
            }
        }
        */

        //SOLID
        /*
        NotificationService notificationService = new NotificationService();
        notificationService.SendEmail("20240076@itla.edu.do", "Hola, este es un mensaje de prueba");
        notificationService.SendSMS("829-660-4658", "Hola, este es OTRO mensaje de prueba");
        */
    }
}
