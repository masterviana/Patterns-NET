using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObjects;
using DomainObjects.Validate;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace StructureMapConfigure
{
    public class Bootstrap
        {
            public static void BootstrapStructureMap()
            {
                // Initialize the static ObjectFactory container
                ObjectFactory.Initialize(x =>
                {
                    x.ForRequestedType(typeof (IFactory<>)).TheDefaultIsConcreteType(typeof (OperationFactory));
                    x.ForRequestedType<DomainObjects.Validate.IValidate>().TheDefaultIsConcreteType<CustomerStringValidate>(); 
                    
                });
            }
        }
    
}
