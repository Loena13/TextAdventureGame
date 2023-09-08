using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame.Model
{
    internal class Game
    {
        static string CharacterName;

        public static void StartGame()
        {
            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Welcome to Adventure Game! In this game we will be exploring the world of NAME\n\n");
            NameCharacter();
        }

        static void NameCharacter()
        {
            Console.WriteLine("You will need a name to go on this adventure. What will it be?\n");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Great! Your character is now named " + CharacterName);
            Console.Clear();
            GameProgress();

        }

        public static void GameProgress()
        {
            Console.WriteLine("You wake up on the floor slowly opening your eyes as you see a stranger hovering above you\n");
            Dialog("Hey there are you okay?");
            Console.WriteLine("How do you answer? 1) Im okay, 2) No, 3) Where am I?, 4) Who are you?");
        }

        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();
        }


    }
}
