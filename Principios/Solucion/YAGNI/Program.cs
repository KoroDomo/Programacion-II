using Principios.YAGNI;

internal class Program
{
    private static void Main(string[] args)
    {
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
}


