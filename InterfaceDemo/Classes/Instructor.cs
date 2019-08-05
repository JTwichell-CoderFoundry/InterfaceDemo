using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Classes
{
    class Instructor
    {
        public void SayHello(Northern northern)
        {
            northern.SayHello();
        }

        public void SayHello(Southern southern)
        {
            southern.SayHello();
        }

        public void SayHelloNorthern(Northern northern)
        {
            northern.SayHello();
        }

        public void SayGoodBye(Northern northern)
        {
            northern.SayGoodBye();
        }

        public void SayGoodBye(Southern southern)
        {
            southern.SayGoodBye();
        }

        public void CommunicateTalk(ICommunicate region)
        {
            region.Talk();
        }

        public void CommunicateSing(ICommunicate region)
        {
            region.Sing();
        }

    }
}
