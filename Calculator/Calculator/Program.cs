// See https://aka.ms/new-console-template for more information
// See https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022

int n1 = 0, n2 = 0;

Console.WriteLine("Calculator in C#");
Console.Write("Enter the first number : ");

n1 = Convert.ToInt32(Console.ReadLine());
// Console.Read::java : sc.next(); OR sc.nextLine().charAt(0);
// Console.ReadLine::java : sc.nextLine();

// code::import java.util.Scanner; Scanner sc = new Scanner(System.in); n1 = sc.nextInt();
// Syntaxically is : n1 = Integer.parseInt(sc.nextLine());
// but here, we specify that the int is coded in 32 bits 

Console.WriteLine("Enter the second number : ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose your option :\n\ta- +\n\ts- -\n\tm- x\n\td- :\n\t");
Console.Write("Enter your option : ");
switch (Console.Read())
{
    case "a":
        Console.WriteLine($"Your result is : {n1} + {n2} = " + (n1 + n2));
        // code::PHP : echo("Yout result is : $n1 + $n2 = " + (n1 + n2));
        break;
    case "s":
        Console.WriteLine($"Your result: {n1} - {n2} = " + (n1 - n2));
        break;
    case "m":
        Console.WriteLine($"Your result: {n1} * {n2} = " + (n1 * n2));
        break;
    case "d":
        Console.WriteLine($"Your result: {n1} / {n2} = " + (n1 / n2));
        break;
}
Console.Write("Press any key to close the console app...");
Console.ReadKey(); // code::Python : exitonclick()