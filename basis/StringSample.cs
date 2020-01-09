using System;

namespace Bais 
{
   class StringSample 
   {
        public void Run()
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("The current time is " + DateTime.Now);

            string firstFriend = "   aaa    ";
            string secFriend = "bbb";

            string trimStartStr = firstFriend.TrimEnd();
            string trimEndStr = firstFriend.TrimStart();
            string replaceStr = firstFriend.ToUpper();
            Console.WriteLine($"My Friend ard [{trimStartStr}], replace string friend [{replaceStr}]");
        }
    }
}
