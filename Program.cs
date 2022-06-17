using  System.Collections.Generic;
using RestricaoGenerics.Services;
using RestricaoGenerics.Entities;
using System.Globalization;
namespace RestricaoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();
            Console.WriteLine("Enter with the Products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter with Name and Price (Phone,1000.00): ");
            for (int i = 0; i < n; i++)
            {
              string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Products(name, price));
            }
            CalculatorService calculatorService = new CalculatorService();

            Products max = calculatorService.Max(list);
            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}