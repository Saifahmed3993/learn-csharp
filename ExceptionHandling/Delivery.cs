namespace ExceptionHandling
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Adress { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }

        public override string ToString()
        {
            //return $"{{\n Id:{Id}, \nCustomer:{CustomerName} , \n Address:{Adress} , \n DeliveryStatus{DeliveryStatus}}}";
            return
            $@"{{
              Id: {Id},
              Customer: {CustomerName},
              Address: {Adress},
              DeliveryStatus: {DeliveryStatus}
            }}";

        }
    }

}
