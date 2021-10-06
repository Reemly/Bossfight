using System;


//string[] names = {"Joachim", "Mermelaine"};

//int[] arrayHp = new int[2];



Random generator = new Random();

int damage = generator.Next(10, 30);
int health = 100;
int fighter1 = health;
int fighter2 = health;

while (health != 0)
{
System.Console.WriteLine(health);
health -= damage;
Console.ReadLine();

if (health < 1)
{
System.Console.WriteLine("fight one wins");
Console.ReadLine();


}

}



Console.ReadLine();






































//for (int health = 100; health > 0; health -= damage)
//{
//    damage = generator.Next(10, 30);
//   System.Console.WriteLine(health);
//}


//using System.IO;

//string art = File.ReadAllText("artwork.txt");

//System.Console.WriteLine(art);

//Console.ReadLine();

