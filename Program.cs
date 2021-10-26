using Async;
using System;

namespace Sample
{
   class Program
   {
        static void Main()
        {
            //var s1 = new IfSapmle();
            //s1.Run();

            //var s2 = new StringSample();
            //s2.Run();
            //
            //var s3 = new ForSapmle();
            //s3.Run();
            
            //var s4 = new CollectionsSample();
            //s4.Run();
            
            //var s5 = new AttrSample();
            //s4.Run();
            
            //var s6 = new ExceptionSample();
            //s6.Run();
            
            AsyncSample.Run();

            Console.ReadKey();
        }
    }
}
