//2
Console.WriteLine("iveskite skaiciu: ");
int userInput = Convert.ToInt32(Console.ReadLine());
int sum = userInput;

int i = userInput;

while (i > 1)
{
    i--;
    sum = sum * i;
    Console.WriteLine("i = " + i);
    Console.WriteLine("sum = " + sum);
}
Console.WriteLine("Rezultatas: " + sum);





//2.1

string userInput = Console.ReadLine();
int i = 0;

while (i < userInput.Length)
{
    Console.WriteLine(userInput[i]);
    i++;
}




////2.2

Console.WriteLine("Iveskite skaiciu: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int currentLine = 1;

while(currentLine <= userNumber)
{

    WriteStars(currentLine);
    currentLine++;
}
void WriteStars(int numberOfstars)
{
    int i = 0;
    while (i < numberOfstars)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("*");
        i++;
    }
    Console.WriteLine("");
}




