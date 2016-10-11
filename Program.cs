//Chantele Crossman
//Advanced C#
//Module 07
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cCrossman_Mod7_ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
                                    
            myCar.Make = "Chevrolet";
            myCar.Model = "Camaro";
            myCar.Year = 2016;
            myCar.Color = "Yellow";

            Car myOtherCar;
            myOtherCar = new Car();

            Car myThirdCar = new Car("Jeep", "Wrangler", 1984, "white");

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "86";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Car.carMethodExampleStatic();
            Car coo = new Car();
            coo.carMethodExampleNonStatic();
                        

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        //constructor
        public Car()
        {
            Make = "Jeep";
        }
        
        //overloaded constructor       
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public static void carMethodExampleStatic()
        {
            Console.WriteLine("Hello from my static Method.");
        }

        public void carMethodExampleNonStatic()
        {
            Console.WriteLine("Hello from my nonstatic Method.");            
        }

        
    }
    


}
