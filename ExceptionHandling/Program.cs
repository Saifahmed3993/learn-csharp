using Exceptionh;
using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exception
            //try
            //{
            //    //الحاجه اللي ممكن تعمل exception.
            //    var re = BadMethod();
            //    Console.WriteLine(re);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    //handle the exception.
            //    Console.WriteLine("Can not devid by zero");
            //}

            //catch (DivideByZeroException ex) when (ex.Source == "HANDLE...")
            //{
            //    //handle the exception.
            //    Console.WriteLine("Can not devid by zero");
            //}

            //catch (Exception ex)
            //{
            //    //handle the exception.
            //    Console.WriteLine("Can not devid by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("END");
            //}
            #endregion


            var delivery = new Delivery
            {
                Id = 1,
                CustomerName = "Ahmed",
                Adress = "Cairo",
                DeliveryStatus = DeliveryStatus.PROCESSED
            };

            var service = new DeliveryService();
            service.Start(delivery);


            Console.WriteLine(delivery);
        }



        static int BadMethod()
        {
            var x = 2; var y = 0;     //مينفعش اقسم علي صفر اعالج ازاي ب try & catch
            return x / y;
        }
    }

}
