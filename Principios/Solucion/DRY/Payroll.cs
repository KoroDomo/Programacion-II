namespace Principios.DRY
{
    public class Payroll
    {
        public decimal salary { get; set; }
        public decimal hourlyRate { get; set; }
        public decimal hoursWorked { get; set; }

        public Payroll(decimal hourlyRate, int hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
            salary = hourlyRate * hoursWorked;
        }
        public Payroll(decimal baseSalary)
        {
            salary = baseSalary;
        }
        public decimal calculateTax()
        {
            return salary * 0.18m;
        }
        public decimal calculateBonus()
        {
            return salary * 0.5m;
        }
        public decimal calculateSalary()
        {
            return salary - calculateTax() + calculateBonus();
        }
    }
}
