namespace Exoression006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primary expression
            var amount = Math.Cos(30);   //return type is double
            Console.WriteLine(amount);

            Console.WriteLine("Saif");   //return type is void

            //binary expression
            var x = 2;
            var y = 5;
            Console.WriteLine($"x + y = {x + y}");

            Console.WriteLine($"x - y = {x - y}");

            Console.WriteLine($"x * y = {x * y}");

            Console.WriteLine($"x / y = {x / y}");

            Console.WriteLine($"x % y = {x % y}");
            //=======================================================================================

            string s1 = null;
            string s2 = "Saif";

            s1 = s1 ?? "Default Value"; //if s1 is null assign "Default Value" to s1   
                                        //?? is called null-coalescing operator
            Console.WriteLine(s1);

            //Value Storage and Reference Storage


            string v1;   //stodes value @ stack
            string v2 = "Saif"; //stodes reference @ heap

            Console.WriteLine(v2.ToUpper());   //creates new string object in heap + all uppercase letters
            Console.WriteLine(v2.ToLower());   //creates new string object in heap + all lowercase letters
            //=======================================================================================

            //Statement blocks
            {
                int a = 10;
                int b = 20;
                Console.WriteLine($"a = {a}, b = {b}");
            } //end of statement block
            //=======================================================================================

            //Declaration Statement
            int x1;
            x1 = 2;

            //=======================================================================================
            //Expression Statement
            var name = "Saif";
            name = name + "Aldin"; //1-Change state 
            Console.WriteLine(name);

            //call something 2 change state
            name.ToUpper(); //this does not change state of name variable
            Console.WriteLine(name);

            //Assignment Statement
            name = name + "Aldin"; //1-Change state 

            //increment Statement & Decrement Statement
            var totalfrind = 150;
            totalfrind++; //increment by 1
            Console.WriteLine(totalfrind);

            totalfrind--; //decrement by 1
            Console.WriteLine(totalfrind);

            //object initializer Statement
            object o = new Object();
            //=======================================================================================

            //select statement
            //if statement
            int mark = 85;
            //explain: if mark >=90 print Excellent else print Good Job
            Console.WriteLine(mark >= 90 ? "Excellent" : "Good Job");

            //=======================================================================================

            var amountEGP = 1000;
            var currency = Console.ReadLine();
            var output = 0.0;

            var egpToUsd = 30.9;
            var egpToEur = 32.5;
            var egpToSar = 8.2;

            switch (currency)
            {
                case "usd":
                    output = amountEGP / egpToUsd;
                    break;

                case "eur":
                    output = amountEGP / egpToEur;
                    break;

                case "sar":
                    output = amountEGP / egpToSar;
                    break;

                default:
                    Console.WriteLine("Unknown currency");
                    return; // يوقف البرنامج هنا
            }

            // الطباعة بعد الـ switch
            Console.WriteLine($"{amountEGP} EGP = {output:F5} {currency.ToUpper()}");

            //=======================================================================================

            //while statement
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;

            }
            while (counter < 10);



            //fibonacci series
            //0 1 1 2 3 5 8 13 21 34....   : 0+1=1  1+1=2  1+2=3  2+3=5  3+5=8 ....
            for (int counter1 = 0, prev = 0, current = 1; counter1 < 10; ++counter1)
            {
                Console.WriteLine(prev);
                var next = prev + current;
                prev = current;
                current = next;
                Console.WriteLine(next);
            }

            var arr = new int[] { 1, 2, 3, 4, 5 };
            foreach (var n in arr)
            {
                Console.WriteLine(n + " ");
            }





        }

    }

}

