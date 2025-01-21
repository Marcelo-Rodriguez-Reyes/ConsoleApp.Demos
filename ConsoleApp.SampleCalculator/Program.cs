// See https://aka.ms/new-console-template for more information 

//Welcome Message
Console.WriteLine("Welcome to the sample calculator!");
//Show calculator options
Console.WriteLine("---------- Operations ----------");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Mulitpliacion");
Console.WriteLine("4. Division");
Console.WriteLine("5. Fibonacci sequence");
Console.WriteLine("6. Exit program");
Console.WriteLine();
Console.Write("Please choose an operation: ");
int selectedOperation = Convert.ToInt32(Console.ReadLine());

while (selectedOperation != 6)
{
    //Prompt for user input
    Console.Write("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    //Decide which operations is needed based on the selected option
    int result = 0;

    switch (selectedOperation)
    {
        case 1: result = num1 + num2; break;
        case 2: result = num1 - num2; break;
        case 3: result = num1 * num2; break;
        case 4: result = num1 / num2; break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                result += i;
            }
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    //Print output
    Console.WriteLine($"Your result is: {result}");
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("---------- Operations ----------");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Mulitpliacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
    Console.WriteLine("6. Exit program");
    Console.WriteLine();
    Console.Write("Please choose an operation: ");
    selectedOperation = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("********** - Thank you for using the sample calculator! - **********");


