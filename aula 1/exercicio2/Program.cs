internal class Program
{
    private static void Main(string[] args, Console console)
    {
        Console.WriteLine("Quantos graus em °C deseja converter?");
        var celsius = Convert.ToInt32(Console.ReadLine());

        var fahrenheit = celsius * 9 / 5 + 32;
        var kelvin = celsius + 273.15;
        console.WriteLine(celsius + " graus celsius são " + fahrenheit + " °F e " + kelvin + " Kelvin");
    }
}