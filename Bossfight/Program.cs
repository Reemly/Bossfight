using System;
using System.IO;




Random generator = new Random();

int health = 100;
int fighter1Health = health;
int fighter2Health = health;
string art = File.ReadAllText("artwork.txt");
string art1 = File.ReadAllText("artworklose.txt");
string art2 = File.ReadAllText("artworkwin.txt");

while (fighter1Health > 0 && fighter2Health > 0)
{
    


System.Console.WriteLine(art);

Console.ReadLine();

int damage = generator.Next(1, 35);
System.Console.WriteLine($"Fighter 1 health {fighter1Health}");
fighter1Health -= damage;

damage = generator.Next(1, 20);
fighter2Health -= damage;
System.Console.WriteLine($"Fighter 2 health {fighter2Health}");
Console.ReadLine();

if (fighter1Health < 0)
{
System.Console.WriteLine("Fighter 2 wins");
Console.ReadLine();
System.Console.WriteLine(art1);

Console.ReadLine();



}


else if (fighter2Health < 0)
{
System.Console.WriteLine("fighter 1 wins");
Console.ReadLine();
System.Console.WriteLine(art2);

Console.ReadLine();

}

}


































//string[] names = {"Joachim", "Mermelaine"};

//int[] arrayHp = new int[2];



//for (int health = 100; health > 0; health -= damage)
//{
//    damage = generator.Next(10, 30);
//   System.Console.WriteLine(health);
//}


//using System.IO;

//string art = File.ReadAllText("artwork.txt");

//System.Console.WriteLine(art);

//Console.ReadLine();

