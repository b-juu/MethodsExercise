namespace MethodsExercise
{
    public class Program
    {

        //     Exercise 2
        static int Sum(int num1, int num2)
        { return num1 + num2; }
        static int Multiply(int num1, int num2, int num3) 
        { return num1 * num2 * num3; }
        static int Subtract(int num1, int num2)
        { return num1 - num2; }
        static int Divide(int num1, int num2)
        { return num1 / num2; }

        static void Main(string[] args)
        {
            var totalVisitors = Sum(100, 35);
            var volumeOfDesk = Multiply(22, 18, 18);
            var remainingInventory = Subtract(100, 72);
            var occupancy = Divide(25, 100);
                
                // Exercise1
                
                Console.WriteLine("Whatis your name?"); //output
            string? name = Console.ReadLine(); //input
            Console.WriteLine("What is your favorite color?"); //output
            string? favoriteColor = Console.ReadLine(); //input
            Console.WriteLine("What is your favorite animal?"); //output
            string? favoriteAnimal = Console.ReadLine(); //input
            Console.WriteLine("What is your favorite band?"); //output
            string? favoriteBand = Console.ReadLine(); //input

            Console.WriteLine($"Yesterday, {name} was at a concert and {favoriteBand} was playing. They bought a {favoriteColor} shirt with a {favoriteAnimal} on it.");
        }
    }   
}
