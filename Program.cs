namespace TextAdventureGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Welcome to Adventure Game! In this game we will be exploring the world of NAME\n\n");

            Console.WriteLine("You will need a name to go on this adventure. What will it be?\n");
            string CharacterName = Console.ReadLine();
            Console.WriteLine("Great! Your character is now named " + CharacterName);

        }
    }
}
