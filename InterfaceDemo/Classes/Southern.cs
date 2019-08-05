using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Classes
{
    class Southern : ICommunicate
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from the Southern Class");
        }

        public void SayGoodBye()
        {
            Console.WriteLine("GoodBye from the Southern Class");
        }

        public void Talk()
        {
            Console.WriteLine("The Southern Class is talking");
        }

        public void Sing()
        {
            Console.WriteLine("The Southern Class is singing");
        }


    }
}
