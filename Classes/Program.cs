namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fifiCar = new Car();

            fifiCar.Make = "Tesla";
            fifiCar.Model = "Model Y";
            fifiCar.Year = 2023;

            Console.WriteLine($"{fifiCar.Year} {fifiCar.Make} {fifiCar.Model}.");
        }

        

        
        
    }
}
