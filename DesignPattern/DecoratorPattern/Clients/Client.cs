using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DecoratorPattern.Clients
{
    public class Client
    {
        public static void Display(string message, IBilesen bilesen) => Console.WriteLine(message + bilesen.Operation()); 
    }
}
