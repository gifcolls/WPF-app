using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301215601_GiselleF_Lab_10.Models
{
    public class Items
    {

        private List<Orders> orderNumber;

        private int quantity;
        private double totalPaid;
        private double price;


        public string ItemId { get; private set; }
        public string NameOfItem { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price
        {

            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Please enter a valid value");
                }

                else
                {
                    this.price = value;
                }


            }
        }
        public double TotalPaid

        {
            get
            {
                double total = Quantity * this.price;
                return total;
            }

            set
            {
                totalPaid = value;


            }
        }

        //Constructors
        public Items()
        {
            this.ItemId = Guid.NewGuid().ToString();

        }

        public Items(string nameOfItem, string description)

        {
            this.ItemId = "ABC-000";
            this.NameOfItem = nameOfItem;
            this.Description = description;
        }

        public Items(string itemId, string nameOfItem, string description, string brand, int quantity) : this(nameOfItem, description)
        {
            this.Brand = brand;
            ++quantity;
            this.Quantity = quantity;
        }

        //Methods

        public double TotalPrice(double price, int quantity)
        {
            double total = price * quantity;
            return total;
        }

        public override string ToString()
        {

            return $"Order: {this.orderNumber}\n" +
                $"Item ID: {this.ItemId}\n" +
                $"Item Name: {this.NameOfItem}" +
                $"Brand: {this.Brand}" +
                $"{this.Quantity}" +
                $"{this.Price}" +
                $"{this.TotalPaid}";

        }

       
    }
}
