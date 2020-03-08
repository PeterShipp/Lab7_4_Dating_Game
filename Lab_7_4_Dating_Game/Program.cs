using System;

namespace Lab_7_4_Dating_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Dating_Profile Donnell = new Dating_Profile("Donnell", "Love", 27, "Male");
            Donnell.WriteBio("Strong outdoors type");

            Dating_Profile Toya = new Dating_Profile("Godfearing", "Toya", 24, "Female");
            Toya.WriteBio("New to this site");

            Donnell.SendMessage("Hello Toya", "Want to get some coffee?", Toya);
            Toya.ReadMessage();
        }
    }
}
