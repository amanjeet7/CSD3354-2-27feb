using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new orderProcessor();
            var order = new order { DataPlaced = DateTime.Now, Totalprice = 100f };
            orderProcessor.Process(order);
        }
    }
}
