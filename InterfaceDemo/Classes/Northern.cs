using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Classes
{
    class Northern : ICommunicate
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from the Northern Class");
        }

        public void SayGoodBye()
        {
            Console.WriteLine("GoodBye from the Northern Class");
        }

        public void Talk()
        {
            Console.WriteLine("The Northern Class is talking");
        }

        public void Sing()
        {
            Console.WriteLine("The Northern Class is singing");
        }
    }
}
