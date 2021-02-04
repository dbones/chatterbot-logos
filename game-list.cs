public Games()
{
    // A
    AddGame(new Game
    {
        Name = "Among-Us",
        Aliases = new HashSet<string>(new[] { "au" }),
        Logo = "amoung-us.png",
        MaxDefault = 10,
        ModesAndMax = new Dictionary<string, int>()
        {
            {"imposter", 10},
            {"hide-and-seek", 10}
        }
    });

    // B
    AddGame(new Game
    {
        Name = "battlefield-v",
        Aliases = new HashSet<string>(new[] { "battlefield" }),
        Logo = "battlefield-v.png",
        MaxDefault = 4
    });

    AddGame(new Game
    {
        Name = "brawl-stars",
        Logo = "brawl-stars.jpg",
        MaxDefault = 3
    });


    // C
    AddGame(new Game
    {
        Name = "Counter-Strike",
        Aliases = new HashSet<string>(new[] { "cs", "cs-go" }),
        Logo = "cs-go.png",
        MaxDefault = 5
    });

    AddGame(new Game
    {
        Name = "cod",
        Aliases = new HashSet<string>(new[] { "call-of-duty" }),
        Logo = "cod.png",
        MaxDefault = 5
    });

    AddGame(new Game
    {
        Name = "cod-cold-war",
        Aliases = new HashSet<string>(new[] { "call-of-duty-cold-war" }),
        Logo = "cod-cold-war.png",
        MaxDefault = 5
    });

    AddGame(new Game
    {
        Name = "cod-mobile",
        Aliases = new HashSet<string>(new[] { "call-of-duty-mobile" }),
        Logo = "cod-mobile.png",
        MaxDefault = 4
    });

    // D
    AddGame(new Game
    {
        Name = "DOTA-2",
        Aliases = new HashSet<string>(new[] { "dota" }),
        Logo = "dota-2.png",
        MaxDefault = 5
    });

    AddGame(new Game
    {
        Name = "doom-eternal",
        Aliases = new HashSet<string>(new[] { "doom" }),
        Logo = "doom.png",
        MaxDefault = 4
    });

    // E

    // F
    AddGame(new Game
    {
        Name = "Fortnite",
        Aliases = new HashSet<string>(new[] { "fnite" }),
        Logo = "fortnite-br.png",
        MaxDefault = 4,
        ModesAndMax = new Dictionary<string, int>()
        {
            {"duos", 2},
            {"trios", 3},
            {"quads", 4}
        }
    });

    AddGame(new Game
    {
        Name = "Fifa-20",
        Aliases = new HashSet<string>(new[] { "fifa" }),
        Logo = "fifa.png",
        MaxDefault = 2
    });

    // G
    AddGame(new Game
    {
        Name = "Gears-of-War",
        Aliases = new HashSet<string>(new[] { "gears" }),
        Logo = "gears.png",
        MaxDefault = 5
    });

    AddGame(new Game
    {
        Name = "Grand-theft-auto",
        Aliases = new HashSet<string>(new[] { "gta" }),
        Logo = "gta.png",
        MaxDefault = 5
    });

    AddGame(new Game
    {
        Name = "Genshin-Impact",
        Logo = "genshin-impact.png",
        MaxDefault = 3
    });


    // H

    // I

    // J
    AddGame(new Game
    {
        Name = "Jackbox",
        Logo = "jackbox.png",
        MaxDefault = 8
    });

    // K

    // L
    AddGame(new Game
    {
        Name = "League-of-Legends",
        Aliases = new HashSet<string>(new[] { "league", "lol" }),
        Logo = "league-of-legends.jpeg",
        MaxDefault = 5
    });

    // M
    AddGame(new Game
    {
        Name = "Minecraft",
        Logo = "minecraft.jpg",
        MaxDefault = 8
    });

    AddGame(new Game
    {
        Name = "Monster-Hunter",
        Aliases = new HashSet<string>(new[] { "monster-hunter-world" }),
        Logo = "monster-hunter.png",
        MaxDefault = 4
    });

    // N

    AddGame(new Game
    {
        Name = "nba-2k",
        Aliases = new HashSet<string>(new[] { "nba-2k20", "nba-2k19" }),
        Logo = "nba-2k.png",
        MaxDefault = 2
    });

    // O

    // P

    // Q

    // R

    AddGame(new Game
    {
        Name = "raft",
        Logo = "raft.jpg",
        MaxDefault = 8
    });


    AddGame(new Game
    {
        Name = "red-dead-redemption-2",
        Aliases = new HashSet<string>(new[] { "rdr2"}),
        Logo = "red-dead-redemption-2.png",
        MaxDefault = 7
    });


    AddGame(new Game
    {
        Name = "Roblox",
        Logo = "roblox.jpg",
        MaxDefault = 20
    });

    AddGame(new Game
    {
        Name = "Rocket-league",
        Logo = "rocket-league.png",
        MaxDefault = 20
    });

    // S

    AddGame(new Game
    {
        Name = "skribblio",
        Aliases = new HashSet<string>(new[] { "skribbl" }),
        Logo = "skribblio.jpg",
        MaxDefault = 15
    });

    AddGame(new Game
    {
        Name = "starwars-squadrons",
        Aliases = new HashSet<string>(new[] { "squadrons" }),
        Logo = "squadrons.png",
        MaxDefault = 12
    });

    // T

    // U

    // V
    AddGame(new Game
    {
        Name = "Valorant",
        Logo = "valorant.png",
        MaxDefault = 5
    });

    // W
    AddGame(new Game
    {
        Name = "Warframe",
        Logo = "warframe.png",
        MaxDefault = 4
    });

    AddGame(new Game
    {
        Name = "Warzone",
        Aliases = new HashSet<string>(new[] { "cod-wz" }),
        Logo = "warzone.png",
        MaxDefault = 4
    });

    AddGame(new Game
    {
        Name = "we-were-here",
        Logo = "we-were-here.png",
        MaxDefault = 2
    });

    AddGame(new Game
    {
        Name = "World-Of-Warcaft",
        Aliases = new HashSet<string>(new[] { "wow" }),
        Logo = "world-of-warcraft.png",
        MaxDefault = 30
    });

    // X

    // Y

    // Z

}
