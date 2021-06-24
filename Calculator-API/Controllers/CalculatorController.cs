using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public double Add(double left, double right) {
            return CalculatorClass.add(left, right);
        }

        [HttpGet]
        public double Subtract(double left, double right)
        {
            return CalculatorClass.subtract(left, right);
        }

        [HttpGet]
        public double Multiply(double left, double right)
        {
            return CalculatorClass.multiply(left, right);
        }

        [HttpGet]
        public double Divide(double left, double right)
        {
            if (right != 0) {
                return CalculatorClass.divide(left, right);
            }
            Response.StatusCode = 400;
            return 0;
            
        }
    }
}
