// Introduction to Tales Of The Errant
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
Console.WriteLine("");

// Choosing your Race
Console.WriteLine("Now then Lost Soul of the Void. What Race do you hail from?");
Console.WriteLine("[HUMAN] [ELF] [BEASTFOLK]");

string raceChoice = Console.ReadLine();
bool validRace = raceChoice.ToUpper() == "HUMAN" || raceChoice.ToUpper() == "ELF" || raceChoice.ToUpper() == "BEASTFOLK";
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
    Console.WriteLine("");
}

// Checking for valid Race input
if (validRace == true)
{
    // Get Player Height
    Console.WriteLine("");
    Console.WriteLine("By the way, I am quite curious. How tall are you? (Metres)");
    float playerHeight = float.Parse(Console.ReadLine());

    if (playerHeight >= 1.83)
    {
        Console.WriteLine($"Ah, {playerHeight} metres eh? You are quite tall!");
    }
    else if (playerHeight <= 1.52)
    {
        Console.WriteLine($"Ah, {playerHeight} metres eh? No shame in being short, I hear they live longer you know.");
    }
    else
    {
        Console.WriteLine($"Ah, {playerHeight} metres eh? Quite an average height for a {raceChoice}.");
    }
    // Choosing your Class
    Console.WriteLine("");
    Console.WriteLine("Back to it! What is your Class?");
    Console.WriteLine("[COMBAT] [MAGIC] [STEALTH]");

    string classChoice = Console.ReadLine();
    if (classChoice.ToUpper() == "COMBAT")
    {
        Console.WriteLine("A Combatant! A master of physical prowess and weaponry.");
        Console.WriteLine("");

        // Choosing your Combat Sub-Class
        Console.WriteLine("What type of Combatant are you?");
        Console.WriteLine("[KNIGHT] [BARBARIAN]");

        string subClassChoice = Console.ReadLine();
        if (subClassChoice.ToUpper() == "KNIGHT")
        {
            Console.WriteLine("A Knight! A noble warrior bound by honor and chivalry.");
            Console.WriteLine("");

            // Choosing your Knight Class' Weapon
            Console.WriteLine("What weapon do you wield?");
            Console.WriteLine("[LONGSWORD] [MACE]");

            string weaponChoice = Console.ReadLine();
            if (weaponChoice.ToUpper() == "LONGSWORD")
            {
                Console.WriteLine("A Longsword! A balanced weapon for both offense and defense.");
            }
            else if (weaponChoice.ToUpper() == "MACE")
            {
                Console.WriteLine("A Mace! A blunt weapon designed to crush armor and bones.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Choosing your Knight Class' Off-Hand Item
            Console.WriteLine("");
            Console.WriteLine("What off-hand item do you carry?");
            Console.WriteLine("[SHIELD] [SHORTSWORD]");

            string offHandChoice = Console.ReadLine();
            if (offHandChoice.ToUpper() == "SHIELD")
            {
                Console.WriteLine("A Shield! A sturdy barrier for blocking attacks.");
            }
            else if (offHandChoice.ToUpper() == "SHORTSWORD")
            {
                Console.WriteLine("A Shortsword! A quick and agile weapon for close combat.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Final Confirmation of Choices + Naming yourself
            Console.WriteLine("");
            Console.WriteLine($"So, Lost Soul of the Void, you are a {raceChoice} {subClassChoice}, wielding a {weaponChoice} and {offHandChoice}.");
            Console.WriteLine("Very well then.");
            Console.WriteLine("Now that you returning to the mortal plane, we can not call you Lost Soul of the Void anymore, can we?");
            Console.WriteLine("What name do you go by?");

            string nameChoice = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"A strong name for a strong {subClassChoice}, Sir {nameChoice}.");
            Console.WriteLine("Now go forth and protect the people of Lodenhal Reach from the Demons of Blood-Rift!");
        }
        else if (subClassChoice.ToUpper() == "BARBARIAN")
        {
            Console.WriteLine("A Barbarian! A fierce fighter fueled by rage and primal strength.");
            Console.WriteLine("");

            // Choosing your Barbarian Class' Weapon
            Console.WriteLine("What weapon do you wield?");
            Console.WriteLine("[GREATSWORD] [WARHAMMER]");

            string weaponChoice = Console.ReadLine();
            if (weaponChoice.ToUpper() == "GREATSWORD")
            {
                Console.WriteLine("A Greatsword! A massive blade that deals devastating damage.");
            }
            else if (weaponChoice.ToUpper() == "WARHAMMER")
            {
                Console.WriteLine("A Warhammer! A heavy weapon that can shatter shields and bones.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Choosing your Barbarian Class' Off-Hand Item
            Console.WriteLine("");
            Console.WriteLine("What off-hand item do you carry?");
            Console.WriteLine("[TOMAHAWK] [FIREBOMB]");

            string offHandChoice = Console.ReadLine();
            if (offHandChoice.ToUpper() == "TOMAHAWK")
            {
                Console.WriteLine("A Tomahawk! A versatile axe for both throwing and melee combat.");
            }
            else if (offHandChoice.ToUpper() == "FIREBOMB")
            {
                Console.WriteLine("A Firebomb! An explosive device that engulfs enemies in flames.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Final Confirmation of Choices + Naming yourself
            Console.WriteLine("");
            Console.WriteLine($"So, Lost Soul of the Void, you are a {raceChoice} {subClassChoice}, wielding a {weaponChoice} and {offHandChoice}.");
            Console.WriteLine("Very well then.");
            Console.WriteLine("Now that you returning to the mortal plane, we can not call you Lost Soul of the Void anymore, can we?");
            Console.WriteLine("What name do you go by?");

            string nameChoice = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"A strong name for a strong {subClassChoice}, Sir {nameChoice}.");
            Console.WriteLine("Now go forth and protect the people of Lodenhal Reach from the Demons of Blood-Rift!");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
            Console.WriteLine("[GAME OVER]");
        }
    }
    else if (classChoice.ToUpper() == "MAGIC")
    {
        Console.WriteLine("A Mage! A wielder of arcane powers and mystical arts.");
        Console.WriteLine("");

        // Choosing your Magic Sub-Class
        Console.WriteLine("What type of Mage are you?");
        Console.WriteLine("[SUMMONER] [BISHOP]");

        string subClassChoice = Console.ReadLine();
        if (subClassChoice.ToUpper() == "SUMMONER")
        {
            Console.WriteLine("A Summoner! A conjurer of otherworldly beings to aid in battle.");
            Console.WriteLine("");

            // Choosing your Summoner Class' Familiar
            Console.WriteLine("What familiar do you summon?");
            Console.WriteLine("[FIRE IMP] [WATER SPRITE]");

            string weaponChoice = Console.ReadLine();
            if (weaponChoice.ToUpper() == "FIRE IMP")
            {
                Console.WriteLine("A Fire Imp! A mischievous creature that wields flames.");
            }
            else if (weaponChoice.ToUpper() == "WATER SPRITE")
            {
                Console.WriteLine("A Water Sprite! A graceful entity that commands water.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Choosing your Summoner Class' Familiar Booster
            Console.WriteLine("");
            Console.WriteLine("What Familiar Booster do you use?");
            Console.WriteLine("[ORB] [TALISMAN]");

            string offHandChoice = Console.ReadLine();
            if (offHandChoice.ToUpper() == "ORB")
            {
                Console.WriteLine("An Orb! A spherical object that enhances summoning abilities.");
            }
            else if (offHandChoice.ToUpper() == "TALISMAN")
            {
                Console.WriteLine("A Talisman! A charm that strengthens the bond with your familiar.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Final Confirmation of Choices + Naming yourself
            Console.WriteLine("");
            Console.WriteLine($"So, Lost Soul of the Void, you are a {raceChoice} {subClassChoice}, wielding a {weaponChoice} and {offHandChoice}.");
            Console.WriteLine("Very well then.");
            Console.WriteLine("Now that you returning to the mortal plane, we can not call you Lost Soul of the Void anymore, can we?");
            Console.WriteLine("What name do you go by?");

            string nameChoice = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"A wise name for a wise {subClassChoice}, Master {nameChoice}.");
            Console.WriteLine("Now go forth and protect the people of Lodenhal Reach from the Demons of Blood-Rift!");
        }
        else if (subClassChoice.ToUpper() == "BISHOP")
        {
            Console.WriteLine("A Bishop! A healer and protector, channeling divine energy.");
            Console.WriteLine("");

            // Choosing your Bishop Class' Magical Enhancer
            Console.WriteLine("What Magical Enhancer do you use?");
            Console.WriteLine("[STAFF] [WAND]");

            string weaponChoice = Console.ReadLine();
            if (weaponChoice.ToUpper() == "STAFF")
            {
                Console.WriteLine("A Staff! A long implement that amplifies magical power.");
            }
            else if (weaponChoice.ToUpper() == "WAND")
            {
                Console.WriteLine("A Wand! A slender tool for precise spellcasting.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Choosing your Bishop Class' Holy Artifact
            Console.WriteLine("");
            Console.WriteLine("What Holy Artifact do you carry?");
            Console.WriteLine("[AMULET] [BOOK]");

            string offHandChoice = Console.ReadLine();
            if (offHandChoice.ToUpper() == "AMULET")
            {
                Console.WriteLine("An Amulet! A pendant that offers protection and boosts healing.");
            }
            else if (offHandChoice.ToUpper() == "BOOK")
            {
                Console.WriteLine("A Book! A tome filled with sacred texts and powerful prayers.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Final Confirmation of Choices + Naming yourself
            Console.WriteLine("");
            Console.WriteLine($"So, Lost Soul of the Void, you are a {raceChoice} {subClassChoice}, wielding a {weaponChoice} and {offHandChoice}.");
            Console.WriteLine("Very well then.");
            Console.WriteLine("Now that you returning to the mortal plane, we can not call you Lost Soul of the Void anymore, can we?");
            Console.WriteLine("What name do you go by?");

            string nameChoice = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"A wise name for a wise {subClassChoice}, Master {nameChoice}.");
            Console.WriteLine("Now go forth and protect the people of Lodenhal Reach from the Demons of Blood-Rift!");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
            Console.WriteLine("[GAME OVER]");
        }
    }
    else if (classChoice.ToUpper() == "STEALTH")
    {
        Console.WriteLine("A Rogue! A shadowy figure skilled in subterfuge and agility.");
        Console.WriteLine("");

        // Choosing your Stealth Sub-Class
        Console.WriteLine("What type of Rogue are you?");
        Console.WriteLine("[THIEF] [ASSASSIN]");

        string subClassChoice = Console.ReadLine();
        if (subClassChoice.ToUpper() == "THIEF")
        {
            Console.WriteLine("A Thief! A cunning individual adept at stealth and lockpicking.");
            Console.WriteLine("");

            // Choosing your Thief Class' Weapon
            Console.WriteLine("What weapon do you wield?");
            Console.WriteLine("[DAGGER] [CLAW]");

            string weaponChoice = Console.ReadLine();
            if (weaponChoice.ToUpper() == "DAGGER")
            {
                Console.WriteLine("A Dagger! A small blade perfect for quick, silent strikes.");
            }
            else if (weaponChoice.ToUpper() == "CLAW")
            {
                Console.WriteLine("A Claw! A sharp, curved weapon ideal for slashing attacks.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Choosing your Thief Class' Tool
            Console.WriteLine("");
            Console.WriteLine("What tool do you carry?");
            Console.WriteLine("[SMOKEBOMB] [GRAPPLEHOOK]");

            string offHandChoice = Console.ReadLine();
            if (offHandChoice.ToUpper() == "SMOKEBOMB")
            {
                Console.WriteLine("A Smoke Bomb! A device that creates a cloud of smoke for quick escapes.");
            }
            else if (offHandChoice.ToUpper() == "GRAPPLEHOOK")
            {
                Console.WriteLine("A Grapple Hook! A tool for scaling walls and binding enemies.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Final Confirmation of Choices + Naming yourself
            Console.WriteLine("");
            Console.WriteLine($"So, Lost Soul of the Void, you are a {raceChoice} {subClassChoice}, wielding a {weaponChoice} and {offHandChoice}.");
            Console.WriteLine("Very well then.");
            Console.WriteLine("Now that you returning to the mortal plane, we can not call you Lost Soul of the Void anymore, can we?");
            Console.WriteLine("What name do you go by?");

            string nameChoice = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"A clever name for a clever {subClassChoice}, Rogue {nameChoice}.");
            Console.WriteLine("Now go forth and protect the people of Lodenhal Reach from the Demons of Blood-Rift!");
        }
        else if (subClassChoice.ToUpper() == "ASSASSIN")
        {
            Console.WriteLine("An Assassin! A deadly operative skilled in silent takedowns.");
            Console.WriteLine("");

            // Choosing your Assassin Class' Weapon
            Console.WriteLine("What weapon do you wield?");
            Console.WriteLine("[BOW] [SHURIKEN]");

            string weaponChoice = Console.ReadLine();
            if (weaponChoice.ToUpper() == "BOW")
            {
                Console.WriteLine("A Bow! A ranged weapon for striking from the shadows.");
            }
            else if (weaponChoice.ToUpper() == "SHURIKEN")
            {
                Console.WriteLine("A Shuriken! A throwing star for silent, precise attacks.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Choosing your Assassin Class' Tool
            Console.WriteLine("");
            Console.WriteLine("What tool do you carry?");
            Console.WriteLine("[POISON] [CALTROPS]");

            string offHandChoice = Console.ReadLine();
            if (offHandChoice.ToUpper() == "POISON")
            {
                Console.WriteLine("Poison! A deadly substance for coating your weapons.");
            }
            else if (offHandChoice.ToUpper() == "CALTROPS")
            {
                Console.WriteLine("Caltrops! Spiked devices for hindering enemy movement.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
                Console.WriteLine("[GAME OVER]");
            }
            // Final Confirmation of Choices + Naming yourself
            Console.WriteLine("");
            Console.WriteLine($"So, Lost Soul of the Void, you are a {raceChoice} {subClassChoice}, wielding a {weaponChoice} and {offHandChoice}.");
            Console.WriteLine("Very well then.");
            Console.WriteLine("Now that you returning to the mortal plane, we can not call you Lost Soul of the Void anymore, can we?");
            Console.WriteLine("What name do you go by?");

            string nameChoice = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"A clever name for a clever {subClassChoice}, Rogue {nameChoice}.");
            Console.WriteLine("Now go forth and protect the people of Lodenhal Reach from the Demons of Blood-Rift!");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
            Console.WriteLine("[GAME OVER]");
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
        Console.WriteLine("[GAME OVER]");
    }
}
else
{
    Console.WriteLine("Hm, still can't remember? Give it a bit more time to come back to you.");
    Console.WriteLine("[GAME OVER]");
}