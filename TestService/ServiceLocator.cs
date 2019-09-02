using Service;
using Service.Implementations;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    public class ServiceLocator
    {
        /// <summary>
        ///  This method is responsible of calling generic Register method of DependencyInjector class  to register dependencies
        /// </summary>
        public static void Init()
        {
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
            DependencyInjector.Register<IPersonService, PersonService>();           
        }
    }
}
