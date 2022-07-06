
string reset;
do
{
    Console.WriteLine("Enter a number: ");
    //int i = int.Parse(Console.ReadLine());
    //for (int addedNumbers = i; addedNumbers > 0; addedNumbers++)
    //{
    //    Console.WriteLine(addedNumbers);
    //}

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





//int i = int.Parse(Console.ReadLine());
//for (int j = i; j >= 0; j--)
//{
//    Console.WriteLine(j);
//    if (j == 0)
//    {
//        break;
//    }
//}
//for (int x = 0; x <= i; x++)
//{
//    Console.WriteLine(x);
//    if (i == x)
//    {
//        break;
//    }
//}