using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _301215601_GiselleF_Lab_10.Models
{
    public class Customers
    {
        // fields

        private int customerNumber;


        private DateTime dayOfBirth;
        private static List<Orders> orderNumber;


        //Properties
        public string CustomerID { get; private set; }//Unique and not modified from outside /Auto implementd Property              

        public int CustomerNumber //Fully implementd Property
        {

            get
            {
                return this.customerNumber;
            }

            set
            {
                this.customerNumber = ++value;
            }
        }
        public string FirstName { get; set; }//Auto implementd Property
        public string LasttName { get; set; } //Auto implementd Property
        public DateTime DateOfBirth //Fully implementd Property
        {

            get
            {
                return this.dayOfBirth;
            }


            set
            {
                this.dayOfBirth = value;

                try
                {
                    this.dayOfBirth = DateTime.Parse(Console.ReadLine());

                    while (true)
                    {
                        Console.WriteLine("Please enter a valid Date of Birth");
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public int Age //Auto calculated Property
        {
            get
            {
                int age = DateTime.Now.Year - this.DateOfBirth.Year;
                age--;
                return age;
            }
        }

        public Orders OrderNumber { get; }



        //Constructors
        public Customers()
        {
            this.CustomerID = Guid.NewGuid().ToString();

        }

        public Customers(string name, string lastName)
        {
            this.FirstName = name;
            this.LasttName = lastName;

            this.CustomerNumber = int.Parse(Guid.NewGuid().ToString());
        }

        public Customers(string name, string lastName, int customerNumber, DateTime dOb) : this(name, lastName)
        {
            this.CustomerID = " AAA-1987981";
            ++customerNumber;
            this.CustomerNumber = customerNumber;
            this.DateOfBirth = dOb;

        }

        //METHODS

        public static void AddAnOrder(Orders anOrder)
        {
            orderNumber.Add(anOrder);
        }

        public override string ToString()
        {
            return $"Full Name: {this.FirstName}{this.LasttName}\n" +
                $"ID:{this.CustomerID}\n" +
                $"Number:{this.CustomerNumber}\n" +
                $"Age:{this.Age}";

        }

        

    }
}
