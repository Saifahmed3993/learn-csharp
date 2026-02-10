
using System;

namespace Interface
{
    class Vehicle
    {
        //Interface
        protected string Brand;
        protected string Model;
        protected string Year;

        public Vehicle(string brand, string model, string year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}";
        }
    }

    public interface IDrivable
    {
        void Move();
        void Stop();

    }

    public interface ILoader
    {
        void Load();
        void Unload();

    }

    class Honda : Vehicle, IDrivable
    {
        public Honda(string brand, string model, string year) : base(brand, model, year) { }

        public void Move()
        {
            Console.WriteLine("Miveing...");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }
    }

    class Caterpillar : Vehicle, ILoader, IDrivable
    {
        public Caterpillar(string brand, string model, string year) : base(brand, model, year) { }

        public void Load()
        {
            Console.WriteLine("Loading...");
        }

        public void Unload()
        {
            Console.WriteLine("UnLoading...");
        }
        public void Move()
        {
            Console.WriteLine("Miveing...");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Honda("BME", "310M", "2020");
            Console.WriteLine(v1);

            ILoader v2 = new Caterpillar("BME", "310M", "2020");
            v2.Load();
            Console.WriteLine(v2);
            Console.WriteLine("------------------------");


            Cashier c = new Cashier(new Cash());
            c.Checkout(999999.99m);

            Console.WriteLine("======================================");
            Console.WriteLine("When use interface");
            Console.WriteLine("======================================");
            Cashier cashier;

            cashier = new Cashier(new Debit1());
            cashier.Checkout(250.75m);

            cashier = new Cashier(new Visa1());
            cashier.Checkout(500.40m);

            cashier = new Cashier(new MasterCard1());
            cashier.Checkout(1000m);

            Console.ReadLine();
        }
    }

    class Cashier
    {
        private IPayment _payment;
        //private Debit _debit;
        public Cashier(IPayment payment)
        {
            //_cash = cash;   
            _payment = payment;
        }
        public void Checkout(decimal amount)
        {
            _payment.Pay(amount);
        }




    }


    //اختصار كل اللي تحت 
    public interface IPayment
    {
        void Pay(decimal amount);
    }

    class Cash : IPayment
    {
        public void Pay(decimal amount) { Console.WriteLine($"Cash payment{Math.Round(amount, 2):NO}"); }

    }

    class Debit
    {
        public void Pay(decimal amount) { Console.WriteLine($"Debit payment{Math.Round(amount, 2):NO}"); }

    }

    class Visa
    {
        public void Pay(decimal amount) { Console.WriteLine($"Cash payment{Math.Round(amount, 2):NO}"); }

    }

    class MasterCard
    {
        public void Pay(decimal amount) { Console.WriteLine($"Debit payment{Math.Round(amount, 2):NO}"); }

    }

    //بعد الاختصار
    class Debit1 : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit payment {Math.Round(amount, 2):N0}");
        }
    }

    class Visa1 : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Visa payment {Math.Round(amount, 2):N0}");
        }
    }

    class MasterCard1 : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"MasterCard payment {Math.Round(amount, 2):N0}");
        }
    }


}
