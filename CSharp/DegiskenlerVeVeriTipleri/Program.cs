using System;

namespace DegiskenlerVeVeriTipleri
{
    class Program
    {
        public static double solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double toplam=0;
        double tip=0;
        double tax=0;
        tip=(tip_percent*(meal_cost/100));
        Console.WriteLine(tip);
        tax=(tip_percent*(tax_percent/100));
        Console.WriteLine(tax);
        return meal_cost+tip+tax;
    }
        public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine(solve(meal_cost, tip_percent, tax_percent));

        
    }


    }
}
