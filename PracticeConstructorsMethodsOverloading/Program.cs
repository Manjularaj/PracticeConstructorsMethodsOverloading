using System.Security.Principal;

namespace PracticeConstructorsMethodsOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating instances of Car using different constructors
            Car car1 = new Car(); // Default constructor
            Car car2 = new Car("Toyota", "Rav4"); // 2 arguments
            Car car3 = new Car("Hyundai", "Sonata", 2010, 100000); // 4 arguments

            
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);


            Bank account = new Bank ("12345", "Will Cram", 20);


            Console.WriteLine(account);
            account.Deposit(500);

            Console.WriteLine(account);
            account.Deposit(-15000);

            Console.WriteLine(account);
            account.Withdraw(300);

            Console.WriteLine(account);
            account.Withdraw(-500);

        }
    }
}