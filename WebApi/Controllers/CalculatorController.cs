using WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<double> _calculatorService;

        public CalculatorController(ICalculatorService<double> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public IActionResult Add(double a, double b)
        {
            return Ok(_calculatorService.Add(a, b));
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b)
        {
            return Ok(_calculatorService.Subtract(a, b));
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            return Ok(_calculatorService.Multiply(a, b));
        }

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            return Ok(_calculatorService.Divide(a, b));
        }
    }
}
