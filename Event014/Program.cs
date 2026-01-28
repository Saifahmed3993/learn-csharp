
namespace Events014
{
    internal class Program   //subscribe to event
    {
        static void Main(string[] args)
        {
            //Event: is enable to notify other class when somthing change

            var Stock = new Stock("Saif");
            Stock.Price = 100;
            Stock.OnPriceChanged += Stock_OnPriceChanged; //subscribe to event  //بربط الحدث بالداله اللي هتتنفذ لما الحدث يحصل
            Console.WriteLine($"Stock Name: {Stock.Name}, Stock Price: {Stock.Price}");
            Console.WriteLine("==============================");


            //Stock.ChangeStockPrice(100.1m);
            //Console.WriteLine($"Stock Name: {Stock.Name}, Stock Price: {Stock.Price}");
            //Console.WriteLine("==============================");

            Stock.ChangeStockPrice(9.9m);
            Console.WriteLine(Stock.Price);
            Console.WriteLine("==============================");


            Stock.ChangeStockPrice(0.9m);
            Console.WriteLine(Stock.Price);
            Console.WriteLine("==============================");

            Stock.OnPriceChanged -= Stock_OnPriceChanged; //unsubscribe from event


            Stock.ChangeStockPrice(9.9m);
            Console.WriteLine(Stock.Price);
            Console.WriteLine("==============================");


            Stock.ChangeStockPrice(0.9m);
            Console.WriteLine(Stock.Price);
            Console.WriteLine("==============================");



        }
        private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            //throw new NotImplementedException();
            //Console.WriteLine($"Stock Price Changed from {oldPrice} to {stock.Price}");

            string result = " ";
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stock.Name}: {stock.Price}");
                result = "UP";
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stock.Name}: {stock.Price}");
                result = "DOWN";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{stock.Name}: {stock.Price}");
                result = "UNCHANGED";

            }

        }

    }

    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);  //جوا الاقواس ببعت الحاجات اللي هتتغير 


    public class Stock      //publisher  //class اللي هيبعت الاشعار
    {
        private string name;
        private decimal price;

        public event StockPriceChangeHandler OnPriceChanged; //يعني لما السعر يتغير هيبعت اشعار  

        public string Name => this.name;
        public decimal Price { get => this.price; set => this.price = value; }

        public Stock(string StrockName)
        {
            this.name = StrockName;
        }
        public void ChangeStockPrice(decimal percent)
        {
            decimal oldPrice = this.Price;
            this.price = Math.Round(this.Price * percent, 2);
            if (OnPriceChanged != null)//make sure there is subscriber
            {
                OnPriceChanged(this, oldPrice); //invoke the event or call the event , وبعتله الحاجات اللي هتتغير

            }
        }


    }
}
