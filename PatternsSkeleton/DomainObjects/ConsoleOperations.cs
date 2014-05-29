using System;

namespace DomainObjects
{
    public class ConsoleOperations : AbsOperationUtils
    {
        internal override void WriteToImp(string message)
        {
             Console.WriteLine(message);
        }

        internal override void ReadToImp(string mgs)
        {
            //FAl qualquer coisa ao codigo....
        }
    }
}
