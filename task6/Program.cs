namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberConversion numberProgram = new NumberConversion();
            numberProgram.Run();

            Console.WriteLine(); // For spacing

            PasswordValidation passwordProgram = new PasswordValidation();
            passwordProgram.Run();

            Console.ReadKey();

        }
    }
}
