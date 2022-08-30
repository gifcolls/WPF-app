using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _301215601_GiselleF_Lab_10.Models
{
    public class Orders

    {

        private List<Customers> customerNumber;
        private static List<Items> items;
        private List<Items> itemId;
        private static string filename;




        //Auto calculated property
        public DateTime ShipDate
        {
            get
            {

                DateTime shipDate = DateTime.Now.AddDays(3);
                return shipDate;
            }

            set
            {
                this.ShipDate = value;
            }


        }

        //Fully implemented property
        public int OrderNumber
        {
            get
            {
                return this.OrderNumber;
            }

            set
            {
                this.OrderNumber = ++value;
            }
        }

        public Customers CustomerNumber { get;}

        public Customers Items { get; }

        public Customers ItemId { get; }

        public double ShipCost { get; set; }

        //Constrctors

        public Orders()
        {
            this.OrderNumber = int.Parse(Guid.NewGuid().ToString());

        }
        public Orders(int orderNumber)
        {
            this.OrderNumber = orderNumber;
        }



        public Orders(int orderNumber, DateTime shipDate) : this(orderNumber)
        {
            this.ShipDate = shipDate;
        }



        //METHODS
        public static void Create(Items itemId)
        {
            Console.WriteLine($"Item {itemId} inserted successfully");
        }

        public static Items Get(Items itemId)
        {
            return itemId;
        }

        public static void Update(Items updateItems)
        {
            Console.WriteLine($"Items updated {updateItems}");
        }

        public static void Delete(Items itemId)
        {
            Console.WriteLine($"Item successfully deleted {itemId}");
        }



        public void AddItem(Items anItem)
        {
            items.Add(anItem);
        }


        public override string ToString()
        {

            return $"{this.OrderNumber}" +
                 $"{this.CustomerNumber}" +
                 $"{this.ShipDate}";

        }

      

            }
        }



    

