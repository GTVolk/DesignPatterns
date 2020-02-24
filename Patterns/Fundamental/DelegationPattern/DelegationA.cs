using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPatterns.Patterns.Fundamental.DelegationPattern
{
    class DelegationA: IDelegation
    {
        public void OperationA()
        {
            System.Console.WriteLine("DelegationA: вызываем метод OperationA()");
        }

        public void OperationB()
        {
            System.Console.WriteLine("DelegationB: вызываем метод OperationB()");
        }
    }
}
