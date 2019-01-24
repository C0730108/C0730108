using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730108
{
    public class Customer
    {
        public int ID { get; set; }
        public String name { get; set; }
        public void Promote() {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promote to Level 1");
            }
            else { Console.WriteLine("Promote to Level 2"); }
        }
            public int CalculateReating()
        {
            return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var Customer = new Customer();
            customer.
        }
        
            //var dog_and_cat = new Car();
            // var bowling = new Car();
            // Console.WriteLine("how many cars: {0} ",Vehicle.HowManyCars );
            //Book myBook = new Book();
            //myBook.SetTitle("A Separete Peace");
            //Console.WriteLine("my color is" + Color);
        }
    }
    //class Vehicle
    //     class Car : Vehicle
        class BookCollection
    {
             private String Title;
             public void SetTitle(String aTitle) { this.Title = aTitle; }
            public String GetTitle() { return this.Title; }
        //public static int HowManyCars =0;
        //public String Color = "Blue";
    }
    //class Car: Vehicle
    
        //public String Color = "Red";
        //public Car()
        
            //Vehicle.HowManyCars++;
            //Console.WriteLine("my color is " + Color);
        
    
        






  

    

