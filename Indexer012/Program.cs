namespace Indexer012
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Indexer
            ////   what is indexer: An indexer is a special type of property that allows you to access elements in a class or struct using array-like syntax. Indexers are defined using the 'this' keyword and can take one or more parameters to specify the index or key for accessing the elements.
            //// Example of an indexer in a class

            //int[] arr = { 1, 2, 3, 4, 5 };
            //arr[0] = 10; // 1--->10


            //string str = "Hello";
            //var c = str[0];// H

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(c);
            #endregion

            //var ip = new IP(192, 168, 1, 1);
            var ip = new IP(255, 255, 255, 0);
            Console.WriteLine(ip.Adress);


            var firstSegmant = ip[0];
            Console.WriteLine($"ip Adress{ip.Adress}");
            Console.WriteLine($"1st segmants is: {firstSegmant}");

            var ip2 = new IP("123.456.789,147");
            Console.WriteLine($"ip2 Adress{ip2.Adress}");
        }

    }

    public class IP
    {
        private int[] segmants = new int[4];
        public int this[int index]
        {
            get { return segmants[index]; }
            set { segmants[index] = value; }

        }
        //segmant 1-255
        public IP(string ipAddress)
        {
            var seg = ipAddress.Split(".");
            for (int i = 0; i < seg.Length; i++)
            {
                segmants[i] = int.Parse(seg[i]);
            }
        }
        public IP(int segmant1, int segmant2, int segmant3, int segmant4)
        {
            segmants[0] = segmant1;
            segmants[1] = segmant2;
            segmants[2] = segmant3;
            segmants[3] = segmant4;
        }
        public string Adress => string.Join(".", segmants);
    }
}
