using ExceptionHandling;
using System;
using System.Threading;

namespace Exceptionh
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();

        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deliver Fails duo to {ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
            finally { }

        }


        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1) { throw new InvalidOperationException("Unable To Process Item"); }
            delivery.DeliveryStatus = DeliveryStatus.PROCESSED;
        }

        private void Ship(Delivery delivery)
        {
            FakeIt("Shiping");
            if (random.Next(1, 5) == 1) { throw new InvalidOperationException("Unable To Shiped Item bec it Damaged"); }
            delivery.DeliveryStatus = DeliveryStatus.SHIPPED;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");
            delivery.DeliveryStatus = DeliveryStatus.DELIVERED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("Transiting");
            delivery.DeliveryStatus = DeliveryStatus.INTRANSIT;
        }

        private void FakeIt(string title)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{title} ");
                Thread.Sleep(300);
                Console.WriteLine("========");
                Thread.Sleep(300);
            }
        }



    }
}
