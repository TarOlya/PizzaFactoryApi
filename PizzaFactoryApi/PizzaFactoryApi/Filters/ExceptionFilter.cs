using System;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PizzaFactoryApi.Filters
{
    public class ExceptionFilter: ExceptionFilterAttribute
    {
        public override async Task OnExceptionAsync(ExceptionContext context)
        {
            if (context.Exception is ValidationException || context.Exception is InvalidOperationException || context.Exception is NotImplementedException)
            {
                context.HttpContext.Response.StatusCode = 400;
                context.Result = new JsonResult(context.Exception.Message);
            }
            else
            {
                context.HttpContext.Response.StatusCode = 500;
                context.Result = new JsonResult(context.Exception.StackTrace);
            }

            await base.OnExceptionAsync(context);
        }
    }
}