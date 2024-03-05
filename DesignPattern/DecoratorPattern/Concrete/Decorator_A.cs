using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    
    public class Decorator_A : IBilesen
    {
        private readonly IBilesen _bilsen;

        public Decorator_A(IBilesen bilsen)
        {
            _bilsen = bilsen;
        }
        public string Operation() => _bilsen.Operation() + "yazılım projeleri geliştiriyorum.";
    }
}
