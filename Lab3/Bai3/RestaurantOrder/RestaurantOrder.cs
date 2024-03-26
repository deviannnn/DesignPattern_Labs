using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder
{
    public abstract class DishesOrder
    {
        public void PlaceOrder()
        {
            ChooseDish();

            SpecifyCustomizations();

            NoteOrder();

            if (ConfirmOrder())
            {
                Console.WriteLine("5. Sent order to Chef");

                Console.WriteLine("5.1. Chef starts preparing the dish.");

                CookDish();
            }
            else
            {
                Console.WriteLine("~ This dish's order canceled.");
            }
        }

        protected abstract void ChooseDish();
        protected abstract void SpecifyCustomizations();
        protected abstract void CookDish();

        protected virtual void NoteOrder()
        {
            Console.Write("3. Note for your order: ");

            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine($"3.1. Your note: {userInput}.\n");
            }
            else
            {
                Console.WriteLine("3.1. There are no notes for this order.\n");
            }
        }

        protected virtual bool ConfirmOrder()
        {
            Console.Write("4. Order confirmed (y/n):");

            string userInput = Console.ReadLine();
            return userInput.ToLower() == "y";
        }
    }

    public class PastaOrder : DishesOrder
    {
        private string? pastaOption;

        protected override void ChooseDish()
        {
            Console.WriteLine("1. Customer chooses Pasta dish.");
        }

        protected override void SpecifyCustomizations()
        {
            Console.WriteLine("2. Choose Pasta options: ");
            Console.WriteLine("    a. Penne");
            Console.WriteLine("    b. Fettuccine");
            Console.WriteLine("    _. Spaghetti (default)");

            Console.Write("Enter your choice (a, b): ");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "a":
                    pastaOption = "Penne";
                    break;
                case "b":
                    pastaOption = "Fettuccine";
                    break;
                default:
                    pastaOption = "Spaghetti";
                    break;
            }

            if (pastaOption != "Spaghetti")
            {
                Console.WriteLine($"2.1 Customer requests specific sauce and toppings for {pastaOption}.\n");
            }
            else
            {
                Console.WriteLine("2.1 No requests specific for Pasta.\n");
            }
        }

        protected override void CookDish()
        {
            Console.WriteLine($"6. Chef is cooking the {pastaOption} Pasta.");
        }
    }

    public class SteakOrder : DishesOrder
    {
        private string? steakOption;
        protected override void ChooseDish()
        {
            Console.WriteLine("1. Customer chooses Steak dish.");
        }

        protected override void SpecifyCustomizations()
        {
            Console.WriteLine("2. Choose Steak options: ");
            Console.WriteLine("    a. Rare");
            Console.WriteLine("    b. Medium Rare");
            Console.WriteLine("    c. Medium");
            Console.WriteLine("    d. Well Done");

            Console.Write("Enter your choice (a, b, c, d): ");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "a":
                    steakOption = "Rare";
                    break;
                case "b":
                    steakOption = "Medium Rare";
                    break;
                case "c":
                    steakOption = "Medium";
                    break;
                case "d":
                    steakOption = "Well Done";
                    break;
                default:
                    steakOption = "Unknown Option";
                    break;
            }

            if (steakOption != "Unknown Option")
            {
                Console.WriteLine($"2.1 Customer requests specific cooking level and side dishes for {steakOption} Steak.\n");
            }
            else
            {
                Console.WriteLine("2.1 No requests specific for Steak.\n");
            }
        }

        protected override void CookDish()
        {
            Console.WriteLine($"6. Chef is grilling the {steakOption} Steak.");
        }
    }

    public enum DishesOrderType
    {
        Pasta, Steak
    }

    public class SimpleRestaurantFactory
    {
        public DishesOrder CreateDishesOrder(DishesOrderType type)
        {
            return type switch
            {
                DishesOrderType.Pasta => new PastaOrder(),
                DishesOrderType.Steak => new SteakOrder(),
                _ => throw new ArgumentException("Invalid Dish Order type"),
            };
        }
    }
    
    public class Restaurant
    {
        public SimpleRestaurantFactory factory { get; set; }
        public Restaurant(SimpleRestaurantFactory factory)
        {
            this.factory = factory;
        }

        public void OrderSomeDishes(DishesOrderType type)
        {
            DishesOrder dishesOrder;
            dishesOrder = factory.CreateDishesOrder(type);
            dishesOrder.PlaceOrder();
        }
    }
}
