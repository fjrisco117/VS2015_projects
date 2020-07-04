using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Animal
    {

        // public : Access is not limited
        // protected : Access is limited to the class methods and subclasses
        // private : Access is limited to only this classes methods
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        // We can either have C# create the getters and setters or create them ourselves to verify data
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Every object has a default constructor that receives no attributes
        // The constructor initializes every object created
        // this is used to refer to this objects specific fields since we don't know the objects given name

        // The default constructor isn't created if you create any other constructor
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";

            numOfAnimals++;
        }

        // You can create custom constructors as well
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;

            numOfAnimals++;
        }

        // A static fields value is shared by every object of the Animal class
        // We declare thinsg static when it doesn't make sense for our object to either have the property or
        // the capability to do something (Animals can't count)
        static int numOfAnimals = 0;

        // A static method cannot access non-static class members
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        // Declare a method
        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }


        static void Main(string[] args)
        {
            // Create an Animal object and call the constructor
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            // Get object values with the dot operator
            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            // Calling a static method
            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());

            // Calling an object method
            Console.WriteLine(spot.toString());

            Console.WriteLine("Press Any Key To End");
            Console.ReadKey();
        }
    }
}
