// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's grade: ");
// Global variable / global scope
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If...Else...Statement - Decide to print pass or fail based on input
Console.WriteLine("********** Simple IF Results **********");
if(grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("please recommned student to student affair's office");
}
Console.WriteLine("********** Simple IF Results End **********");

// Complex If...Else...Statement - Decide to print letter based on grade value
Console.WriteLine("********** Simple IF...ELSE IF Results **********");

/*
 * A: 85 - 100 - else if (grade >= 86 && grade <= 100)
 * B: 75 - 84 - else if (grade >= 75 && grade <= 84)
 * C: 65 - 74 - else if(grade >= 65 && grade <= 74)
 * C-: 50 - 64 X 
 * F: less than 50 X
 */
if(grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if(grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
}
else if(grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job");
}
int gradeAfterBonus = grade >= 0 || grade <= 100 ? grade + 10 : 0;
Console.WriteLine($"Grade after bonus: {gradeAfterBonus}");

Console.WriteLine("********** Simple IF...ELSE IF Results End **********");

// Ternary operator - Used to assign value to a variable based on a condition
Console.WriteLine("********** Ternary Operator Result **********");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Studnet status is: {passStatus}");

Console.WriteLine("********** Ternary Operator Result End **********");

Console.WriteLine("Would you like to enter another grade? (Y/N)");
char affirmation = Convert.ToChar(Console.ReadLine());
Console.Clear();

while (affirmation != 'N')
{
    // Prompt for input
    Console.Write("Please enter student's grade: ");
    // Global variable / global scope
    grade = Convert.ToInt32(Console.ReadLine());

    // Simple If...Else...Statement - Decide to print pass or fail based on input
    Console.WriteLine("********** Simple IF Results **********");
    if (grade > 50)
    {
        Console.WriteLine("Student has passed");
    }
    else
    {
        Console.WriteLine("Student has failed");
        Console.WriteLine("please recommned student to student affair's office");
    }
    Console.WriteLine("********** Simple IF Results End **********");

    // Complex If...Else...Statement - Decide to print letter based on grade value
    Console.WriteLine("********** Simple IF...ELSE IF Results **********");

    /*
     * A: 85 - 100 - else if (grade >= 86 && grade <= 100)
     * B: 75 - 84 - else if (grade >= 75 && grade <= 84)
     * C: 65 - 74 - else if(grade >= 65 && grade <= 74)
     * C-: 50 - 64 X 
     * F: less than 50 X
     */
    if (grade < 0 || grade > 100)
    {
        Console.WriteLine("Invalid value entered");
    }
    else if (grade < 50)
    {
        Console.WriteLine("Student has failed - F");
    }
    else if (grade >= 50 && grade <= 64)
    {
        Console.WriteLine("C-");
    }
    else if (grade >= 65 && grade <= 74)
    {
        Console.WriteLine("C");
    }
    else if (grade >= 75 && grade <= 84)
    {
        Console.WriteLine("B");
    }
    else if (grade >= 85 && grade <= 100)
    {
        Console.WriteLine("A - Good job");
    }
    gradeAfterBonus = grade >= 0 || grade <= 100 ? grade + 10 : 0;
    Console.WriteLine($"Grade after bonus: {gradeAfterBonus}");

    Console.WriteLine("********** Simple IF...ELSE IF Results End **********");

    // Ternary operator - Used to assign value to a variable based on a condition
    Console.WriteLine("********** Ternary Operator Result **********");

    passStatus = grade < 50 ? "Fail" : "Pass";
    Console.WriteLine($"Studnet status is: {passStatus}");

    Console.WriteLine("********** Ternary Operator Result End **********");

    Console.WriteLine("Would you like to enter another grade? (Y/N)");
    affirmation = Convert.ToChar(Console.ReadLine());
}


// Switch statements - used to evaluate a value and take an action
Console.WriteLine("********** Switch Statement Results **********");

Console.Write("Please enter the day of the week: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

switch(dayWeek)
{
    case 1: Console.WriteLine("Today is Sunday");
        break;
    case 2: Console.WriteLine("Today is Monday");
        break;
    case 3: Console.WriteLine("Today is Tuesday");
        break;
    case 4: Console.WriteLine("Today is Wednesday (Hump Day!)");
        break;
    case 5: Console.WriteLine("Today is Thursday");
        break;
    case 6: Console.WriteLine("Today is Friday (TGIF!!!)");
        break;
    case 7: Console.WriteLine("Today is Saturday (Beach Day!!!)");
        break;
    default: Console.WriteLine("Invalid day number entered!!");
        break;
}

Console.WriteLine("********** Switch Statement Results End **********");

// The rest of the application
Console.WriteLine("Thank you for using this program");