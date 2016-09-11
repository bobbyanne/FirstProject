using System;

namespace First_GeneralCompetence
{
    class Program
    {
        static void Main(string[] args)
        {
            //int coins = 0;
            Start();
            Console.Clear();
            Console.ReadLine();
            MainMenu();
            Console.ReadLine();

        }
        static void Start() // Gives player an initial monster
        {
            Monster firstMonster = new Monster();
            Console.Write("This monster is a gift, please name it: ");
            firstMonster.mName = Console.ReadLine();
            Console.Write("Your monsters name is: {0}", firstMonster.mName);
            Console.ReadLine();
            Console.WriteLine("Do you like your name {0}?", firstMonster.mName);
            Console.Write("{0} says: ", firstMonster.mName);
            firstMonster.Mspeak();
            Console.WriteLine("");
            Console.ReadLine();
        }
        static void MainMenu()
        {
            Console.WriteLine("1) Battle other monsters.");
            Console.WriteLine("2) Purchase new monster.");
            Console.WriteLine("3) Play the slot machine.");
            Console.WriteLine("4) View inventory.");
            Console.WriteLine("5) Enter monster menu.");
        }

    }
    class Monster
    {
        public string mName;

        public void Mspeak()
        {
            Console.Write("\"");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Growl");
            Console.ResetColor();
            //WriteFullLine("");
            Console.Write("\"");
        }

        public void SetName(string newName)
        {
            mName = newName;
        }
    }
}
