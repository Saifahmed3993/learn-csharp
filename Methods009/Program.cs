namespace Methods009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object from Demo class
            Demo demo = new Demo();

            // Call methods
            demo.DoSomething();

            int result = demo.DoSomething2();
            Console.WriteLine(result);

            int z = 100 + demo.DoSomething2();
            Console.WriteLine(z);

            // Using ref parameter
            int age = 20;
            demo.DoSomething3(ref age);
            Console.WriteLine(age);

            // Using out parameter
            demo.DoSomething4(out int age2);
            Console.WriteLine(age2);


            //reallife example
            var numString = "123456";
            int number;
            if (!int.TryParse(numString, out number))
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                Console.WriteLine($"You Enter A Valid Number: {number}");
            }

            //method signature
            //لازم يكون مختلف بالبراميترز مش بالاسم بس


            //methods Overloading
            demo.promote(100, "London", "Hilton");

            //expression Bodies methods   --- داله قصيرة او بدون جسم
            var re = demo.isEven(5);
            Console.WriteLine(re);

            re = demo.isEven(8);
            Console.WriteLine(re);

            //local Methods
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            demo.PrintEven(numbers);

            //static methods
            Demo.PrintEvens(numbers);

        }
    }

    public class Demo
    {
        /*
         * Method Syntax:
         * <access modifier> <return type> <method name>(<parameter list>)
         * {
         *     statements
         * }
         */

        // Method with no return value
        public void DoSomething()
        {
            Console.WriteLine("Do Something");
        }

        // Method with return value
        public int DoSomething2()
        {
            return 100;
        }

        // Method using ref to modify external variable
        public void DoSomething3(ref int age)
        {
            age += 3;
        }

        // Method using out to modify external variable
        public void DoSomething4(out int age2)
        {
            age2 = 10;
            age2 += 3;
        }

        //method signature (Name + Paramiter type + Paramiter order)
        public void DoSomething4(int x, double y)
        {

        }
        //الفرق بين هادول الاتنين هو ترتيب البراميترز

        public void DoSomething4(double y, int x)
        {

        }

        //methods Overloading  --> A common way of implementing polymorphism 
        public void promoteincrease(double amount)
        {
            Console.WriteLine($"You Got A promotion of {amount}");
        }

        public void promoteincreaseAndTicket(double amount, string trip)
        {
            Console.WriteLine($"You Got A promotion of {amount} and a Trip {trip}");
        }

        public void promoteincreaseAndTicketAndHotel(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You Got A promotion of {amount} and a Trip {trip} with  {hotel}");
        }
        //ال3 كدا مش readable طب الحل ايهههههه
        //Solution: Optional Parameters or Named Arguments
        public void promote(double amount)
        {
            Console.WriteLine($"You Got A promotion of {amount}");
        }

        public void promote(double amount, string trip)
        {
            Console.WriteLine($"You Got A promotion of {amount} and a Trip {trip}");
        }

        public void promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You Got A promotion of {amount} and a Trip {trip} with  {hotel}");
        }

        //expression Bodies methods   --- داله قصيرة او بدون جسم
        public bool isEven(int numberr)
        {
            return numberr % 2 == 0;
        }
        //بدون جسم
        //public bool isOdd(int number) => number % 2 != 0;
        public bool Even(int number) => number % 2 == 0;



        //local Methods
        public void PrintEven(int[] original)
        {
            foreach (var n in original)
            {
                if (IsEven(n))
                {
                    Console.WriteLine(n);
                }
            }
            //local method
            bool IsEven(int number)
            {
                return number % 2 == 0;
            }

            //or     --->>>    bool Even(int number) => number % 2 == 0;

        }

        //احسن من اني اخليها برا
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        //static methods
        public static void PrintEvens(int[] original)
        {
            foreach (var n in original)
            {
                if (IsEven(n))
                {
                    Console.WriteLine(n);
                }
            }
            //local method
            bool IsEven(int number)
            {
                return number % 2 == 0;
            }

            //or     --->>>    bool Even(int number) => number % 2 == 0;

        }

    }
}
