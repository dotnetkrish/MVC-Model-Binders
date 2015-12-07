using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindings.Models
{
    public class CustomHome : IModelBinder
    {

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase httpRequest = controllerContext.HttpContext.Request;
            string firstName = httpRequest.Form.Get("firstname");
            string lastName = httpRequest.Form.Get("lastname");
            string age = httpRequest.Form.Get("Age");
            return new Employee { Name = firstName + lastName,Age=age };
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}