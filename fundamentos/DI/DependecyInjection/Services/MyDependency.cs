using DependecyInjection.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjection.Services
{
    public class MyDependency : IMyDependency
    {
        private readonly ILogger<MyDependency> _logger;

        public MyDependency(ILogger<MyDependency> logger)
        {
            _logger = logger;
        }
        public Task WriteMessage(string message)
        {
            _logger.LogInformation(
               "MyDependency.WriteMessage called. Message: {Message}",
               message
                );
            return Task.FromResult(0);
        }
    }
}
