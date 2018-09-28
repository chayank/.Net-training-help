using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class FoodItem
    {
        public string itemName { get; set; }
        public int calories { get; set; }
        public int price { get; set; }
        public List<FoodItem> items;
        public FoodItem()
        { }
        public void setItems()
        {
            items = new List<FoodItem>
            {
                new FoodItem{ itemName = "dosa", calories = 100, price =20},
                new FoodItem{ itemName = "idli", calories = 200, price =30},
                new FoodItem{ itemName = "samosa", calories = 300, price =40}
            };
        }

        public FoodItem(string itemName)
        {
            setItems();
            this.itemName = itemName;
        }

        public List<FoodItem> getItems()
        {
            return items;
        }
    }

    class Order : FoodItem
    {
        public int qty { get; set; }
        public int amount { get; set; }
        public FoodItem item { get; set; }
        public Order(string itemName, int qty) : base(itemName)
        {
            this.qty = qty;
            this.item = this.items.SingleOrDefault(x => x.itemName == itemName);
            this.amount = this.qty * this.item.price;
        }

        public void getBill()
        {
            Console.WriteLine("{0} {1}", this.item.itemName, this.item.price);
            Console.WriteLine("{0} {1}", this.qty, this.amount);
        }
    }

    class Program
    {
        public static void Main()
        {
            Order o1 = new Order("dosa", 5);
            o1.getBill();
            Console.ReadKey();
        }
    }
}
