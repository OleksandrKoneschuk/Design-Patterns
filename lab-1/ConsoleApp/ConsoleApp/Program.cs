using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Money
    {
        public int WholePart { get; set; }
        public int Cents { get; set; }

        public Money(int wholePart, int cents)
        {
            WholePart = wholePart;
            Cents = cents;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Сума: {WholePart}грн. {Cents:D2}к.");
        }

        public void SetWholePart(int wholePart)
        {
            WholePart = wholePart;
        }

        public void SetCents(int cents)
        {
            Cents = cents;
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void DecreasePrice(double discount)
        {
            Price -= discount;
        }
    }

    class Warehouse
    {
        public string Name { get; set; }
        public string UnitOfMeasure { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime LastRestockDate { get; set; }

        public void DisplayInventory()
        {
            Console.WriteLine($"\nСклад: {Quantity} {UnitOfMeasure} доступно");
        }
    }

    class Reporting
    {
        private List<Warehouse> inventory;

        public Reporting(List<Warehouse> inventory)
        {
            this.inventory = inventory;
        }

        public void RecordIncomingGoods(Warehouse item)
        {
            inventory.Add(item);
            Console.WriteLine($"\nЗаписано завоз товару: {item.Name}");
        }

        public void ShipGoods(Warehouse item)
        {
            inventory.Remove(item);
            Console.WriteLine($"\nТовар відправлено: {item.Name}");
        }

        public void InventoryReport()
        {
            Console.WriteLine("\nЗвіт про інвентаризацію:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Name}: {item.Quantity} {item.UnitOfMeasure}");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

                Money amount = new Money(10, 50);
                amount.DisplayAmount();

                amount.SetWholePart(GetIntegerInput("Введіть нову цілу частину грошей: "));
                amount.SetCents(GetIntegerInput("Введіть нові копійки: "));
                amount.DisplayAmount();

                Product laptop = new Product
                {
                    Name = "Ноутбук",
                    Price = 1200.0
                };

                Console.WriteLine($"\nЦіна на {laptop.Name}: {laptop.Price}");

                Warehouse laptopStock = new Warehouse
                {
                    Name = "Ноутбук",
                    UnitOfMeasure = "шт.",
                    UnitPrice = 1200.0,
                    Quantity = 10,
                    LastRestockDate = DateTime.Now
                };

                laptopStock.DisplayInventory();

                List<Warehouse> inventoryList = new List<Warehouse> { laptopStock };
                Reporting reporting = new Reporting(inventoryList);

                reporting.RecordIncomingGoods(new Warehouse
                {
                    Name = "Мишка",
                    UnitOfMeasure = "шт.",
                    UnitPrice = 20.0,
                    Quantity = 50,
                    LastRestockDate = DateTime.Now
                });

                reporting.InventoryReport();

                reporting.ShipGoods(laptopStock);
                reporting.InventoryReport();

                Console.ReadLine();
            }

            static int GetIntegerInput(string message = "\nВведіть ціле число: ", int defaultValue = 0)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                return string.IsNullOrEmpty(input) ? defaultValue : int.Parse(input);
            }
        }
    }
}