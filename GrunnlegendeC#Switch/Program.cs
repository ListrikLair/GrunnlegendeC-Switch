// See https://aka.ms/new-console-template for more information
Run();
static void Run()
{
    Random rand = new Random();
    int dayIndex = rand.Next(1,8);
    switch (dayIndex)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Run();
            break;
    }

    Console.WriteLine("Input number between 1-7 and get the day of the week");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Monday");
            break;
        case "2":
            Console.WriteLine("Tuesday");
            break;
        case "3":
            Console.WriteLine("Wednesday");
            break;
        case "4":
            Console.WriteLine("Thursday");
            break;
        case "5":
            Console.WriteLine("Friday");
            break;
        case "6":
            Console.WriteLine("Saturday");
            break;
        case "7":
            Console.WriteLine("Sunday");
            break;
        default:
            Run();
            break;
    }
}
