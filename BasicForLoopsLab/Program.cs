
string reset;
do
{
    Console.WriteLine("Enter a number: ");
    int sum = 0;
    int input = int.Parse(Console.ReadLine());
    for (int x = input; x > 0; x--)
    {
        sum += x;
    }
    Console.WriteLine("Sum is {0}", sum);
    Console.WriteLine("Would you like to restart? y/n");
    reset = Console.ReadLine().ToLower();
} while (reset.Equals("y"));
Console.WriteLine("Goodbye!");