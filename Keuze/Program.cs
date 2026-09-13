Console.Write("Hoe oud ben je: ");
int leeftijd = Convert.ToInt32(Console.ReadLine());


if(leeftijd >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Je bent toegelaten.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Helaas je bent te jong!");

}
Console.ResetColor();


if (