using System;
using StructureMap.Pipeline;

namespace MysteryWithDynamic
{
    class Program
    {
        private class A { }

        private static LambdaInstance<object> Method(A obj)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            var instance = (dynamic)new A();
            Method(instance); //(*)hangs forever on this line                    
        }
    }
}
