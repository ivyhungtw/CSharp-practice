using System;
using HelloWorld.Math;  // to use calculator class

namespace HelloWorld
{
    
    

    class Program
    {
        static void Main(string[] args)
        {
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
