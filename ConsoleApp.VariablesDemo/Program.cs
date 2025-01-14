// See https://aka.ms/new-console-template for more information

//Different datatypes
/*
    text - string
    integers - int
    decimal - double, float, decimal
    logical - bool
 */

string name = "Marcelo Rodriguez";

Console.WriteLine(name);
Console.WriteLine("I am " + name); //String concatenation
Console.WriteLine($"They call me {name}"); //String interpolation
Console.WriteLine("I was given the name {0}", name); //Formatted string

int age = 21;
int retirementYearsLeft = 44;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = true;
Console.WriteLine("Am I retired? " + isRetired);
