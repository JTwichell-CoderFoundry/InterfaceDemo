using InterfaceDemo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a variable of type Northern and call its SayHello method
            //var newNorthern = new Northern();
            //newNorthern.SayHello();
            //newNorthern.SayGoodBye();

            //Console.WriteLine();

            //var newSouthern = new Southern();
            //newSouthern.SayHello();
            //newSouthern.SayGoodBye();

            //Console.WriteLine();

            //var newValley = new Valley();
            //newValley.SayHello();
            //newValley.SayGoodBye();

            //var myNorthern = new Northern();
            //var mySouthern = new Southern();

            var myInstructor = new Instructor();
            //myInstructor.SayHello(myNorthern);
            //myInstructor.SayHello(mySouthern);

            //myInstructor.SayGoodBye(myNorthern);
            //myInstructor.SayGoodBye(mySouthern);

            //myInstructor.SayHello(new Northern());
            //myInstructor.SayHello(new Southern());

            //myInstructor.SayGoodBye(new Northern());
            //myInstructor.SayGoodBye(new Southern());

            //This does not work...
            //myInstructor.SayHelloNorthern(new Southern());

            myInstructor.CommunicateTalk(new Northern());
            myInstructor.CommunicateTalk(new Southern());

            //This will not work since the Valley class does not implement the ICommunicate Interface
            //myInstructor.CommunicateTalk(new Valley());

            myInstructor.CommunicateSing(new Northern());
            myInstructor.CommunicateSing(new Southern());

            //This will not work since the Valley class does not implement the ICommunicate Interface
            //myInstructor.CommunicateTalk(new Valley());

            Console.ReadKey();
        }
    }
}
