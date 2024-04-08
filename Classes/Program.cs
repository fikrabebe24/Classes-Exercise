namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fifiCar = new Car();
            fifiCar.Make = "Tesla";
            fifiCar.Model = "ModelY";
            fifiCar.Year = 2023;

            Console.WriteLine($"My car is a {fifiCar.Year} {fifiCar.Make} {fifiCar.Model}.");
        }

        

        
        
    }
}
