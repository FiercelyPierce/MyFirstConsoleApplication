
namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            string myName = "Pierce";
            string myLocation = "Arizona";
            DateTime currentDate = DateTime.Now;

            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"I am from {myLocation}");
            Console.WriteLine($"The current date is {currentDate.ToString("MM/dd/yyyy")}");

            GlazerCalc.calculate();

            Console.ReadKey();
        }
    }
}
