namespace Delegates
{
    public class Report
    {
        public void ProcessEmpolyeeWith60000PlusSales(Elmpolyee[] employees)
        {
            Console.WriteLine("Empolyee With $60000 + sSales");
            Console.WriteLine("====================================");

            foreach (var e in employees)
            {
                if (e.TotalSales >= 60000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gander} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n \n");
        }

        public void ProcessEmpolyeeWith30000PlusSales(Elmpolyee[] employees)
        {
            Console.WriteLine("Empolyee With $30000 + sSales");
            Console.WriteLine("====================================");

            foreach (var e in employees)
            {
                if (e.TotalSales < 60000m && e.TotalSales >= 30000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gander} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n \n");
        }

        public void ProcessEmpolyeeWithsaleslesstan30000and59999Sales(Elmpolyee[] employees)
        {
            Console.WriteLine("Empolyee With Less Than 30,000$");
            Console.WriteLine("====================================");

            foreach (var e in employees)
            {
                if (e.TotalSales < 30000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gander} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n \n");
        }



        //ازاي اختصر الكود ده باستخدام الديليجيتس
        public delegate bool IllegibleSales(Elmpolyee e);
        public void ProcessEmpolyee(Elmpolyee[] employees, string title, IllegibleSales isIllegibleSales)
        {

            Console.WriteLine(title);
            Console.WriteLine("====================================");

            foreach (var e in employees)
            {
                if (isIllegibleSales(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gander} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n \n");
        }
    }
}
