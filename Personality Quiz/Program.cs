// See https://aka.ms/new-console-template for more information
using Personality_Quiz;
using System;
using System.Xml.Linq;

Console.WriteLine("MIDDLE EARTH PERSONALITY QUIZ\n");

Console.WriteLine("Answer following questions to see which Lord of the Rings character you are most alike.\n");

Personality quizScore = new Personality(0,0,0,0);

Console.WriteLine("Question 1:   If you had to wage war against orcs what would be your weapon of choice?.\n");
Console.WriteLine("1. Powerful magic staff");
Console.WriteLine("2. Battle Axe");
Console.WriteLine("3. Random rock");
Console.WriteLine("4. Brute Strength");
quizScore.Question();

Console.WriteLine("Question 2:   If you lived in Middle Earth where would you live?.\n");
Console.WriteLine("1. In a tall tower");
Console.WriteLine("2. No place in particular. You prefer to be a travelr and see the world");
Console.WriteLine("3. In a cave under a mountain");
Console.WriteLine("4. In a beautiful and magical forest");
quizScore.Question();

Console.WriteLine("Question 3:   Which of the following would you do in yur downtime?.\n");
Console.WriteLine("1. Smoke a pipe");
Console.WriteLine("2. Fishing for some fishes");
Console.WriteLine("3. Drinking Beer");
Console.WriteLine("4. Go for a walk");
quizScore.Question();

Console.WriteLine("Question 4:   What grinds your gears?\n");
Console.WriteLine("1. When someone is being a fool");
Console.WriteLine("2. When someone steals from you");
Console.WriteLine("3. When someone is taller then you");
Console.WriteLine("4. When someone chops down pretty trees");
quizScore.Question();

Console.WriteLine("Question 5:   What woud you buy if you had all the gold in the world?\n");
Console.WriteLine("1. A beautiful hourse or maybe two horses. Like lots of horses.");
Console.WriteLine("2. You woulnt spend it but hide it somewhere safe.");
Console.WriteLine("3. A ring!! One pretty ring!");
Console.WriteLine("4. Plant trees and grow a huge forest!");
quizScore.Question();

quizScore.UserPersonality();


