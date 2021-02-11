using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjection.Interfaces
{
    public interface IOperation
    {
        public Guid IOperation { get;}
    }

    public interface IOperationTransient: IOperation
    {

    }

    public interface IOperationScoped : IOperation
    {

    }

    public interface IOperationSingleton : IOperation
    {

    }

    public interface IOperationSingletonInstace : IOperation
    {

    }
}
