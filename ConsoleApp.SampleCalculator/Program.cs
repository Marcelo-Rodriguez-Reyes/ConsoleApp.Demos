// See https://aka.ms/new-console-template for more information 

//Welcome Message
Console.WriteLine("Welcome to the sample calculator!");

//Prompt for user input
Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//Show calculator options
Console.WriteLine("---------- Operations ----------");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Mulitpliacion");
Console.WriteLine("4. Division");
Console.WriteLine("5. Modulus");
Console.WriteLine();
Console.Write("Please choose an operation: ");
int selectedOperation = Convert.ToInt32(Console.ReadLine());

//Decide which operations is needed based on the selected option
int result = 0;

switch (selectedOperation)
{
    case 1: result = num1 + num2; break;
    case 2: result = num1 - num2; break;
    case 3: result = num1 * num2; break;
    case 4: result = num1 / num2; break;
    case 5: result = num1 % num2; break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

//Print output
Console.Write($"Your result is: {result}");
