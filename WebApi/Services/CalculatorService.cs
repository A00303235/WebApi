using WebApi.Interfaces;

namespace WebApi.Services
{
    public class CalculatorService : ICalculatorService<double>
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => a / b;
    }
}
