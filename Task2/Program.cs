using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { };
            string name, model;
            Console.WriteLine("Enter driver's name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter bike's model :");
            model = Console.ReadLine();
            Moto mt = new Moto(name,model) ;
            mt.turnOn();
            mt.formateSpeedReport(out arr);
            Console.WriteLine("Speed report : ");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }

    }
    public partial class Moto
    {
        private static bool breakDown;
        private static bool turnOnEngine;
        private int speed;
        private static int acceleration;
        private string name;
        private string model;
        private int choose;
        private List<int> speedList = new List<int>();
        public Moto()
        {
            this.name = "NoName";
            this.model = "garageEdition";
        }
        public Moto(string name)
        {
            this.name = name;
            this.model = "garageEdition";
        }
        public Moto(string name, string model)
        {
            this.name = name;
            this.model = model;
        }
        static Moto()
        {
            breakDown = false;
            turnOnEngine = false;
            acceleration = 0;
        }
        public void turnOn()
        {
            Console.WriteLine("You've turned on the engine");
            turnOnEngine = true;
            speedUp();
            while (!breakDown)
            {
                Console.WriteLine("Dr dr dr dr dr dr dr dr");
                printState();
                speed += acceleration;
                System.Threading.Thread.Sleep(1000);
                speedList.Add(speed);
                if (speed == 180)
                {
                   
                    Console.WriteLine("You driving to fast!!! Slow down, now!");
                    Console.WriteLine("If you want to down your speed press \"1\"");
                    try
                    {
                        choose = int.Parse(Console.ReadLine());
                        
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (choose == 1) speedDown();
                        else speedUp();
                    }
                }
                if (speed > 200)
                {
                    Console.WriteLine("You have crashed!");
                    breakDown = true;
                }
                else if(speed == 0)
                {
                    turnOnEngine = false;
                    Console.WriteLine("You have cut the engine");
                    break;
                }
               
            }
            
        }
       
        public void speedUp()
        {
            accelerate();
        }
        public void speedDown()
        {
            toBrake();
        }
        static void accelerate()
        {
            acceleration = 10;
        }
        static void toBrake()
        {
            acceleration = -10;
        }
        public void formateSpeedReport(out int [] a)
        {
                a = new int[0];
                Array.Resize(ref a, speedList.Count);
                speedList.CopyTo(a);
        }




    }
    public partial class Moto
    {
        private void printState()
        {
            Console.WriteLine("Your name : " + name);
            Console.WriteLine("Bike model : " + model);
            Console.WriteLine("Is engine turn on : " + turnOnEngine);
            Console.WriteLine("Your speed : " + speed);
        }
    }
}
