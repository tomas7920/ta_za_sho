using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW82
{
    class Phone
    {
        protected string Device;
        public Phone(string Device)
        {
            this.Device = Device;
        }
        public void GetName()
        {
            Console.WriteLine($"Devices name: {Device}");
        }
    }
}