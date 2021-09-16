using System;
using HelloWorld.Math;  // to use calculator class

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularMail = 1,
        RegisteredMail = 2,
        Express = 3
    }
    
    

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // 3, enum is internally an integer

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // convert integer to enum

            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 4);
            Console.WriteLine(result);



            try
            {
                var a = 1000;
                byte b = Convert.ToByte(a);
                    
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong");

            }

        }
    }
}
