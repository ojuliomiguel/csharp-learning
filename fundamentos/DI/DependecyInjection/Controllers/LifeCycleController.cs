using DependecyInjection.Models;
using DependecyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjection.Controllers
{
    public class LifeCycleController : Controller
    {
        public OperationService OperationService { get; }
        public OperationService OperationService2 { get; }

        public LifeCycleController(OperationService op1, OperationService op2)
        {
            OperationService = op1;
            OperationService2 = op2;
        }
        public string Index()
        {
            return "Primeira instância: " + Environment.NewLine + 
                OperationService.TransientOperation.OperationId + Environment.NewLine +
                OperationService.ScopedOperation.OperationId + Environment.NewLine +
                OperationService.SingletonOperation.OperationId + Environment.NewLine +
                OperationService.SingletonInstanceOperation.OperationId + Environment.NewLine +

                 Environment.NewLine +
                 Environment.NewLine +

                "Segunda instância: " + Environment.NewLine +
                OperationService2.TransientOperation.OperationId + Environment.NewLine +
                OperationService2.ScopedOperation.OperationId + Environment.NewLine +
                OperationService2.SingletonOperation.OperationId + Environment.NewLine +
                OperationService2.SingletonInstanceOperation.OperationId + Environment.NewLine
                ;
        }
    }
}
