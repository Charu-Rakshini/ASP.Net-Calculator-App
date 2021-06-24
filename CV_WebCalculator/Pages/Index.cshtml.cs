using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Calculator;

namespace CV_WebCalculator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //Calculator.CalculatorClass calc = new CalculatorClass();


        public double Result
        {
            get; set;
        }

        public bool ResultSet
        {
            get; protected set;
        } = false;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost(double leftNumber, double rightNumber, string operation)
        {

            switch (operation)
            {
                case "add":
                    Result = CalculatorClass.add(leftNumber, rightNumber);
                    ResultSet = true;
                    break;
                case "sub":
                    //Result = leftNumber - rightNumber;
                    Result = CalculatorClass.subtract(leftNumber, rightNumber);
                    ResultSet = true;
                    break;
                case "mul":
                    //Result = leftNumber * rightNumber;
                    Result = CalculatorClass.multiply(leftNumber, rightNumber);
                    ResultSet = true;
                    break;
                case "div":
                    //Result = leftNumber / rightNumber;
                    Result = CalculatorClass.divide(leftNumber, rightNumber);
                    ResultSet = true;
                    break;
                default:
                    break;
            }
        }
    }
}
