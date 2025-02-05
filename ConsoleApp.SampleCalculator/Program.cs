// See https://aka.ms/new-console-template for more information 

//Variable Declarations
int choice = 0;
int num1,num2 = 0;

//Show calculator options / Show menu
while (choice != 6)
{
    try
    {
        //Welcome Message
        PrintMenu();
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 6)
        {
            break;
        }
        
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        //Decide which operations is needed based on the selected option
        int result = 0;

        switch (choice)
        {
            case 1: 
                result = AddNumbers(num1,num2); 
                break;
            case 2: 
                result = SubtractNumbers(num1,num2); 
                break;
            case 3: 
                result = Product(num1,num2); 
                break;
            case 4: 
                result = Quotient(num1,num2); 
                break;
            case 5:
                result = Fibonnaci(num1,num2);
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }

        //Print output
        Console.WriteLine($"Your result is: {result}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Canot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }
}

Console.WriteLine("********** - Thank you for using the sample calculator! - **********");


// Method Definitions
int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int Product(int num1, int num2)
{
    return num1 * num2;
}

int Quotient(int num1, int num2)
{
    return num1 / num2;
}

int Fibonnaci(int num1, int num2)
{
    var result = 0;
    for (int i = num1; i <= num2; i++)
    {
        result += i;
    }
    return result;
}

void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("Welcome to the sample calculator!");
    Console.WriteLine("---------- Operations ----------");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Mulitpliacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
    Console.WriteLine("6. Exit program");
    Console.Write("Please choose an operation: ");
}
