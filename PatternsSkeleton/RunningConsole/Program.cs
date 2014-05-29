using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObjects;
using StructureMapConfigure;


namespace RunningConsole
{
    /// <summary>
    /// Falta sacar aqui o strucre maps
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.BootstrapStructureMap(); 
            DomainObjects.IOperationUtils util = StructureMap.ObjectFactory.GetInstance<ConsoleOperations>();

            util.Write("Isto é só um teste..");
            
            String tmp = Console.ReadLine();

            util.Read(tmp);
            Console.Read();

        }
    }
}
