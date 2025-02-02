namespace Principios.YAGNI
{
    internal class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto {name} agregado con exito.");
        }

        public void DeleteProduct(string name)
        {
            Console.WriteLine($"Producto {name} ha sido eliminado.");
        }

    }
}
