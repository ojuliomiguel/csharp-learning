using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjection.Interfaces
{
    interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}
