
Console.WriteLine("Enter the operation (+/-):");
char userOperator = char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int SecondNum = Int32.Parse(Console.ReadLine()); 

switch (userOperator)
{
    case '+':
        Addiotion(firstNum, SecondNum);
        break;
    case '-':
        Subtraction(firstNum, SecondNum);
        break;
        default:
        Console.WriteLine("invalid operator");
        break;
}



static void Addiotion(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}