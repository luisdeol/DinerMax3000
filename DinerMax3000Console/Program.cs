using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon", 50.00);
            summerMenu.AddMenuItem("Leche de Krakaburra", "Delicious", 50.00);
            summerMenu.HospitalDirections = "Right around the corner of 5th street.";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Cuba libre arriba", "La clásica", 10.0);
            outsideDrinks.AddMenuItem("Catuaba con gaseosa", "Muy loco", 15.0);

            Order hungryGuestOrder = new Order();

            for (int a = 0; a < summerMenu.items.Count - 1; a++)
            {
                MenuItem currentItem = summerMenu.items[a];
                hungryGuestOrder.items.Add(currentItem);
            }
            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }

            Console.WriteLine("The Total is: " + hungryGuestOrder.Total.ToString());
            try
            {
                outsideDrinks.AddMenuItem("Cachaca", "It's really bad", 0);
            }
            catch(Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }
        }
    }
}
