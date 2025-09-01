using Microsoft.AspNetCore.Mvc;
using CalculatorApi.Controllers; // <- changed from Services

namespace CalculatorApi.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double a, double b, string operation)
        {
            double? result = null;
            string error = null;

            try
            {
                result = operation switch
                {
                    "Add" => _calculator.Add(a, b),
                    "Subtract" => _calculator.Subtract(a, b),
                    "Multiply" => _calculator.Multiply(a, b),
                    "Divide" => _calculator.Divide(a, b),
                    _ => 0
                };
            }
            catch (DivideByZeroException)
            {
                error = "Division by zero!";
            }

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Operation = operation;
            ViewBag.Result = result;
            ViewBag.Error = error;

            return View();
        }
    }
}
