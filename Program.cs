using System.Text;
using System.Timers;
using PinBreaker;

int seconds = 0;
System.Timers.Timer ti = new System.Timers.Timer(1000);
ti.Elapsed += Ti_Elapsed;
void Ti_Elapsed(object? sender, ElapsedEventArgs e)
{
    seconds++;
}
TemporaryBrutForce temporaryBrut = new TemporaryBrutForce();
while (true)
{
    Console.Clear();
    Console.WriteLine("What do you want to do?\n" +
    "1. Break PIN code\n" +
    "2. Break password (With special characters, numbers, small and big letters)\n" +
    "3. Break password (Small letters)\n" +
    "4. Break password (Small & big letters)\n" +
    "5. Break password (Small, big letters & numbers)\n" +
    "Q. Quit");
    string choice = Console.ReadLine();
    switch (choice.ToLower())
    {
        case "1":            
            Console.WriteLine("Enter your pin");
            string pin = Console.ReadLine();
            ti.Start();
            temporaryBrut.pinbreaker(pin);
            ti.Stop();
            Console.WriteLine($"I break this in {seconds} seconds");
            Console.WriteLine("Tap any key to continue");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            ti.Start();
            temporaryBrut.bruteforcewithspecialcharacters(password);
            ti.Stop();
            temporaryBrut.timeconverter(seconds);
            Console.WriteLine("Tap any key to continue");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            ti.Start();
            temporaryBrut.bruteforceeasy(password);
            ti.Stop();
            temporaryBrut.timeconverter(seconds);
            Console.WriteLine("Tap any key to continue");
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            ti.Start();
            temporaryBrut.bruteforcesmallandlarge(password);
            ti.Stop();
            temporaryBrut.timeconverter(seconds);
            Console.WriteLine("Tap any key to continue");
            Console.ReadKey();
            break;
        case "5":
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            ti.Start();
            temporaryBrut.bruteforcesmalllargeandnumbers(password);
            ti.Stop();
            temporaryBrut.timeconverter(seconds);
            Console.WriteLine("Tap any key to continue");
            Console.ReadKey();
            break;
        case "q":
            return;
        default:
            Console.WriteLine("No option like that");
            Console.WriteLine("Tap any key to continue");
            Console.ReadKey();
            break;
    }
}