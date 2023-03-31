// andmed failidest
string folderPath = @"D:\+ Liis\TKTK\ProgrammeerimiseAlused\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));



//string[] heroes = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo"};
//string[] villains = { "voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainweapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"today {villain} with {villainweapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomindex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomindex];
    return randomStringFromArray;

}