using Personality_Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personality_Quiz
{
    public class Personality
    {
        private int gandalf;
        private int gimli;
        private int gollum;
        private int treebeard;
        public int Gandalf { get; set; }
        public int Gimli { get; set; }
        public int Gollum { get; set; }
        public int Treebeard { get; set; }

        public Personality(int gandalf, int gimli, int gollum, int treebeard)
        {
            Gandalf = gandalf;
            Gimli = gimli;
            Gollum = gollum;
            Treebeard = treebeard;
        }
        public void GandalfScore()
        { 
            Gandalf = Gandalf+1;
        }
        public void GimliScore()
        {
            Gimli = Gimli+1;
        }
        public void GollumScore()
        {
            Gollum = Gollum+1;
        }
        public void TreebeardScore()
        {
            Treebeard = Treebeard+1;
        }
        public void UserPersonality()
        {
            if (Gandalf > Gimli && Gandalf > Gollum && Gandalf > Treebeard)
            {
                Console.WriteLine("You must be a wise wizard like Gandalf!");
            }
            else if (Gimli > Gandalf && Gimli > Gollum && Gimli > Treebeard)
            {
                Console.WriteLine("You must be short and grumpy like Gimli");
            }
            else if (Gollum > Gandalf && Gollum > Gimli && Gollum > Treebeard)
            {
                Console.WriteLine("You must be aloof and creepy like Gollum");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("You must be old and stronglike Treebeard\n");
                Console.WriteLine("Your scores:\n");
                Console.WriteLine("Gandalf =" + Gandalf);
                Console.WriteLine("Gimli =" + Gimli);
                Console.WriteLine("Gollum =" + Gollum);
                Console.WriteLine("Treebeard =" + Treebeard);
            }
        }
        public void Question()
        {

                string userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "1":
                        GandalfScore();
                        break;
                    case "2":
                        GimliScore();
                        break;
                    case "3":
                        GollumScore();
                        break;
                    case "4":
                        TreebeardScore();
                        break;
                    default:
                        break;
                }
        }

    }
}