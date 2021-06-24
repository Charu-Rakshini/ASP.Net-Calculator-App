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
        //For adding two numbers
        public double Add(double left, double right) {
            return CalculatorClass.add(left, right);
        }

        [HttpGet]
        //For subtracting right number from left number
        public double Subtract(double left, double right)
        {
            return CalculatorClass.subtract(left, right);
        }

        [HttpGet]
        //For multiplying two numbers
        public double Multiply(double left, double right)
        {
            return CalculatorClass.multiply(left, right);
        }

        [HttpGet]
        //For dividing left number by right number
        public double Divide(double left, double right)
        {
            //if right number is not zero, proceed with division
            if (right != 0) {
                return CalculatorClass.divide(left, right);
            }
            //else return an error with 400 status code
            Response.StatusCode = 400;
            return 0;
            
        }
    }
}
