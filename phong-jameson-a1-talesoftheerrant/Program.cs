// See https://aka.ms/new-console-template for more information

// Introduction to Tales Of The Errant
using System.Runtime.InteropServices;

Console.WriteLine("[Tales Of The Errant]");
Console.WriteLine("Greetings Lost Soul of the Void.");
Console.WriteLine("I am Arla, Goddess of Rebirth");
Console.WriteLine("I have chosen you to embark on a perilous journey.");
Console.WriteLine("The land of Lodenhal Reach is being invaded by Demons of the Blood-Rift.");
Console.WriteLine("I sense greatness in you, Lost Soul of the Void.");
Console.WriteLine("You are the Beacon of Light the people of Lodenhal Reach have been praying for.");
Console.WriteLine("Unfortunately, your mortal body has long been forgotten to the sands of time.");
Console.WriteLine("But that is why I have... Borrowed the All-Seeing Hourglass from Kronos... Don't tell him.");
Console.WriteLine("With this artifact, you can peer back into time.");
Console.WriteLine("Although fragmented, the memories of your past life will eventually return.");

// Seperator Space
Console.WriteLine("");

// Choosing your Race
Console.WriteLine("Now then Lost Soul of the Void. What Race do you hail from?");
Console.WriteLine("[HUMAN] [ELF] [BEASTFOLK]");

string raceChoice = Console.ReadLine();
if (raceChoice.ToUpper() == "HUMAN")
{
    Console.WriteLine("Ah, a Human. A versatile and resilient race.");
}
else if (raceChoice.ToUpper() == "ELF")
{
    Console.WriteLine("Ah, an Elf. A wise and agile race.");
}
else if (raceChoice.ToUpper() == "BEASTFOLK")
{
    Console.WriteLine("Ah, a Beastfolk. A strong and fierce race.");
}
else
{
    Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
    raceChoice = Console.ReadLine();
}

// Seperator Space
Console.WriteLine("");

// Choosing your Class
Console.WriteLine("And what of your Class?");
Console.WriteLine("[COMBAT] [MAGIC] [STEALTH]");

string classChoice = Console.ReadLine();
if (classChoice.ToUpper() == "COMBAT")
{
    Console.WriteLine("A Combatant! A master of physical prowess and weaponry.");
}
else if (classChoice.ToUpper() == "MAGIC")
{
    Console.WriteLine("A Mage! A wielder of arcane powers and mystical arts.");
}
else if (classChoice.ToUpper() == "STEALTH")
{
    Console.WriteLine("A Rogue! A shadowy figure skilled in subterfuge and agility.");
}
else
{
    Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
    classChoice = Console.ReadLine();
}