namespace Principios
{
    public static class RestaurantBill
    {
        public static decimal CalculateTotal(decimal[] prices, decimal? tipPercentage)
        {
            decimal total = prices.Sum(); // Utilizamos el metodo .Sum() para hacer la suma de los valores dentro del Array

            /* El operador ternario evalua si tipPErcentage tiene un valor (no es null). 
             * Si tiene un valor, lo divide entre 100 para calcular el porcentaje y lo agrega al total.
             * De lo contrario, solo le agrega el 10% por Ley */
            total += (tipPercentage.HasValue) ? total * (tipPercentage.Value / 100) : total * 0.10m; 

            return total;
        }
    }
}
