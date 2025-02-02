using Principios.KISS;

internal class Program
{
    private static void Main(string[] args)
    {
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
    }
}
