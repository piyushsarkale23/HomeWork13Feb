using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13Feb
{

    //1.create a class student accept the 3 subj marks & calculate total & percentage
    public class Student
    {
        int eng;
        int math;
        int sci;
        int total;
        double percentage;

        public Student(int eng, int math, int sci)
        {
            this.eng = eng;
            this.math = math;
            this.sci = sci;
        }

        public void Cal()
        {
            total = eng + math + sci;
            percentage = total/3 ;
        }
        public string Display()
        {
            return $" Total :- {total} and percentage is {percentage}";
        }


    }
   // WAP to accept the product details like id, name, price using property & display in main method
   public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public string DisplayPro()
        {
            return $"id :-{id} name :-{name} price :- {price}";
        }
    }


    //3. WAP to accept a food name, price & quantity& give 5 % off then display the food name & its price(using constructor)
    public class Food
    {
        private string Name;
        private int Price;
        private int Quantity;
        int discountedprice;
        public Food(string name, int price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void Discount()
        {
            int num1 = (Price * 5 / 100) * Quantity;
            discountedprice = Price - num1;
        }
        public string Display()
        {
            return $"Food Name :{Name} Quantity :{Quantity} Price : {Price} Price After 5% Discount :{discountedprice}";
        }

    }


    public class Program
    {
      
        static void Main(string[] args)
        {
            Student s = new Student(90, 87, 90);
            s.Cal();
            Console.WriteLine(s.Display());

            Product p = new Product();
            p.id = 1;
            p.name = "Laptop";
            p.price = 50000;
            Console.WriteLine(p.DisplayPro());

            Food f1 = new Food("Pizza", 200, 2);
            f1.Discount();
            Console.WriteLine(f1.Display());

        }
    }
}
