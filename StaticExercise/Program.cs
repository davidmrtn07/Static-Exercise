namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"{celsius} degrees Celsius");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit");
        }

    }
}
