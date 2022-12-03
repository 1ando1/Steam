using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Data
{
    public class SteamSeeder
    {
        public static List<Game> GetGames()
        {
            return new List<Game>()
            {
                new Game()
                {
                    Id = 1,
                    Name = "Red Dead Redemption 2",
                    Image = "https://grywator.pl/wp-content/uploads/2021/09/Hpl5MtwQgOVF9vJqlfui6SDB5Jl4oBSq.jpg",
                    Trailer = "https://www.youtube.com/watch?v=eaW0tYpxyp0&t=36s",
                    Weight = 150.0,
                    Creator = "Rockstar Games",
                    Publisher = "Rockstar Games",
                    Price = 37,
                    Genre = "Shooter",
                    Description = "America, 1899 Arthur Morgan and other henchmen of Dutch van" +
                    "der Linde are forced to go on the run. Their gang will take part inthefts," +
                    "robberies and shootings in the heart of America. Behind them are federal" +
                    "agents and the best bounty hunters in the country, and the gang itself is" +
                    "torn apart by internal contradictions.Arthur will have to choose what is" +
                    "more important to him: his own ideals or loyalty to the people who raised him" +
                    "The bundle includes new content for the Story Mode, a full photo mode and" +
                    "access to co-op play in the world of Red Dead Online, allowing players to" +
                    "find their place in the Wild West. You can track dangerous criminals as a" +
                    "bounty hunter, develop your own business as a merchant, look for unique" +
                    "treasures as a collector, open an underground alcohol production as a" +
                    "moonshiner, and much more." +
                    "Red Dead Redemption 2 for PC harnesses the power of today's computers to" +
                    "bring every corner of this vast, richly detailed world to life. Graphic" +
                    "and technical improvements include increased draw distance; improvements" +
                    "to the global illumination system and diffuse shading, providing a more" +
                    "realistic change in the time of day; improved reflections and higher" +
                    "resolution shadows at all distances; tessellation of tree bark textures" +
                    "and higher quality grass and fur textures, due to which animals and" +
                    "plants look even more naturalistic." +
                    "In addition, Red Dead Redemption 2 for PC supports HDR, 4K resolutions" +
                    "and above, multi-monitor configurations, widescreen monitors, higher" +
                    "frame rates, and more."
                },
                new Game()
                {
                    Id = 2,
                    Name = "GTA V",
                    Image = "https://image.jeuxvideo.com/medias-sm/163129/1631287693-8700-jaquette-avant.jpg",
                    Trailer = "https://www.youtube.com/watch?v=QkkoHAzjnUs&t=11s",
                    Weight = 86.32,
                    Creator = "Rockstar Games",
                    Publisher = "Rockstar Games",
                    Price = 15,
                    Genre = "Shooter",
                    Description = "When a young street crook, a retired bank robber and a" +
                    "socially dangerous psychopath are embroiled in a showdown with the most" +
                    "frightening and crazy representatives of the criminal world, the US" +
                    "government and the entertainment industry, they must perform a series of" +
                    "risky raids in order to survive in a ruthless city where they cannot" +
                    "trust to no one, and especially to each other." +
                    "Grand Theft Auto V for PC allows players to explore the iconic world of" +
                    "Los Santos and Blaine County in resolutions up to 4k and beyond at 60" +
                    "frames per second." +
                    "The game offers many settings unique to the computer, including more than" +
                    "25 individual settings for adjusting texture quality, shaders," +
                    "tessellation, anti - aliasing and more, as well as keyboard and mouse" +
                    "control support and customization.Additional features include a city" +
                    "population slider that controls traffic density for cars and pedestrians," +
                    "support for two and three monitors, 3D support, and a plug - and - play" +
                    "function for gamepads." +
                    "In addition, Grand Theft Auto V for PC includes Grand Theft Auto Online" +
                    "with support for 30 players and two spectators. Grand Theft Auto Online" +
                    "for PC includes all of the previously released gameplay enhancements and" +
                    "Rockstar-created content, including the recently released Heist Update" +
                    "and Showdown Mode, available from day one." +
                    "The PC version of Grand Theft Auto V and Grand Theft Auto Online features" +
                    "a first-person perspective that takes you even closer to the incredibly" +
                    "authentic world of Los Santos and Blaine County." +
                    "Grand Theft Auto V for PC debuts the Rockstar Editor, a suite of powerful" +
                    "creative tools for quickly and easily capturing, editing and sharing" +
                    "videos shot in Grand Theft Auto V and Grand Theft Auto Online. Available" +
                    "in the Rockstar Editor, Director Mode allows players to create their own" +
                    "scenes with famous characters from Story Mode, pedestrians, and even" +
                    "animals. In addition to an advanced camera control system, editing modes" +
                    "including fast and slow motion, and a range of camera filters, players" +
                    "can add music from the GTA V radio station library and dynamically change" +
                    "the intensity of the game's music playback. Finished videos can be easily" +
                    "uploaded directly from the Rockstar Editor to YouTube or the Rockstar" +
                    "Games Social Club." +
                    "The creators of the game's soundtrack, The Alchemist and Oh No, are back" +
                    "as hosts of a new radio station called The Lab FM, which broadcasts new" +
                    "and exclusive music from these creators based on the original soundtrack" +
                    "of the game. The station's guests include Earl Sweatshirt, Freddie Gibbs," +
                    "Little Dragon, Killer Mike, Sam Herring from Future Islands and other" +
                    "musicians. Additionally, players can explore Los Santos and Blaine County" +
                    "to the music of their choice with the new Self Radio, which plays" +
                    "player-generated soundtracks." +
                    "To access these exclusive content, you must be a member of the Social" +
                    "Club. Details can be found at http://rockstargames.com/V/bonuscontent"
                },
                new Game()
                {
                    Id = 3,
                    Name = "The Withcer Enhunced Edition",
                    Image ="https://cdn.akamai.steamstatic.com/steam/apps/20900/capsule_616x353.jpg?t=1659616192",
                    Trailer = "https://www.youtube.com/watch?v=m3EF-71dodo",
                    Weight = 15.0,
                    Creator = "CD PROJECT RED",
                    Publisher = "CD PROJEKT RED, 1C-SoftClub",
                    Price = 5,
                    Genre = "Action-adventure",
                    Description = "The Witcher is an RPG set in a dark fantasy world. Morality" +
                    "here is a relative concept, and the line between good and evil is erased." +
                    "The creators of the game paid great attention to the story and character" +
                    "development, and a carefully thought-out real-time combat system makes" +
                    "the story even more dynamic." +
                    "Playing as the witcher Geralt of Rivia, you will find yourself in the" +
                    "thick of the intrigue that opposing forces weave in an effort to gain" +
                    "power over the world. You will often have to make difficult choices and" +
                    "deal with the consequences of your decisions. This game will immerse you" +
                    "in an amazing fairy tale, the likes of which cannot be found."
                },
                new Game()
                {
                    Id = 4,
                    Name = "Mafia: The City of Lost Heaven",
                    Image = "https://m.media-amazon.com/images/M/MV5BMTUxODQyNjYtNmJkMS00MDg0LTgxNmItYzdkZjcwZDY3NWI1XkEyXkFqcGdeQXVyMTA0MTM5NjI2._V1_FMjpg_UX1000_.jpg",
                    Trailer = "https://www.youtube.com/watch?v=b0lyjl27jFE",
                    Weight = 2.6,
                    Creator = "Illusion Softworks",
                    Publisher = "2K",
                    Price = 5,
                    Genre = "Shooter",
                    Description = "1930 After a chance meeting with representatives of the" +
                    "mafia, taxi driver Tommy Angelo, against his will, was drawn into the" +
                    "world of organized crime. And although at first it was not easy for him" +
                    "to get along in the Salieri mafia family, the advantages of the new" +
                    "position soon became too obvious to be ignored. The higher he moves up" +
                    "the career ladder, the more his income grows, but each new job turns out" +
                    "to be dirtier than the previous one. Tommy can earn the respect of the" +
                    "entire Salieri family and become a real thief in law, but this title will" +
                    "make him seriously rethink the loyalty of the chosen path." +
                    "Explore the city of New Haven: Explore New Haven, a typical 1930s American" +
                    "city spanning thirty square kilometers that recreates Depression-era" +
                    "architecture and culture." +
                    "Realistic story and dynamic gameplay: More than 20 exciting tasks are" +
                    "waiting for you, inspired by the events of the 30s of the last century." +
                    "Follow the career path in the Salieri family from an ordinary gang member" +
                    "to a thief in law, carry out assassination orders, participate in chases" +
                    "and shootouts, engage in illegal alcohol trade, bank robbery and other" +
                    "criminal amusements." +
                    "Time-appropriate vehicles and weapons: Feel like a mafia driver, get" +
                    "behind the wheel of any of the more than 60 cars created according to" +
                    "historical models. The behavior of the cars reflects the physical" +
                    "characteristics of the cars of those years, and the damage is calculated" +
                    "in real time. Fulfill mafia criminal orders using more than a dozen types" +
                    "of weapons.Baseball bats, sawn-off shotguns, revolvers and the famous" +
                    "Thompson submachine gun - choose for yourself how best to deal with those" +
                    "who dare to stand in your way." +
                    "Note: The soundtrack has been changed in this re - release of Mafia and" +
                    "does not contain any licensed music."
                },
                new Game()
                {
                    Id = 5,
                    Name = "Wallpaper Engine",
                    Image = "https://play-lh.googleusercontent.com/MumkEpSL7dj16Rt_JfqgKPmMhaWlBhQN5HD2sxNpCgKhUEiIkfcktW_pllWM3wfKeQ",
                    Trailer = null,
                    Weight = 0.5,
                    Creator = "Wallpaper Engien Team",
                    Publisher = "Wallpaper Engine Team",
                    Price = 2,
                    Genre = "Programm",
                    Description = "Wallpaper Engine allows you to install live wallpapers on" +
                    "your Windows desktop. Various types of animated wallpapers are supported," +
                    "including 3D and 2D animations, websites, videos, and even certain apps." +
                    "Choose existing wallpapers or create your own and share them on the Steam" +
                    "Workshop! In addition to this, you can use the free Wallpaper Engine" +
                    "companion app for Android to transfer your favorite wallpapers to your" +
                    "Android mobile device and choose live wallpapers on the go." +
                    "NEW: Use the free Android companion app to transfer your favorite" +
                    "wallpapers to your Android mobile device."
                },
                new Game()
                {
                    Id = 6,
                    Name = "Marc Eckō's Getting Up: Contents Under Pressure",
                    Image = "https://upload.wikimedia.org/wikipedia/en/e/e4/Getting_Up.jpg",
                    Trailer = "https://www.youtube.com/watch?v=1EREQPdHp0w",
                    Weight = 2.71,
                    Creator = "The Collective, General Arcade",
                    Publisher = "Devolver Digital",
                    Price = 6,
                    Genre = "Action-adventure",
                    Description = "Play as Trane, a 'toy' graffiti artist with the street" +
                    "smarts, athletic prowess and vision to become an 'All City King' - the" +
                    "most reputable of all graffiti artists. Along your quest, uncover the" +
                    "mayor's deep, dark secret and use your fighting talents and high-wire" +
                    "graffiti to expose the city's leader as a corrupt tyrant. As you struggle" +
                    "to save a neighborhood from an oppressive government, one question stands" +
                    "out: What if graffiti could change the world? Risk your life battling city" +
                    "authorities and rival graf gangs - mere obstacles in your attempt to get" +
                    "your tag up. And in this city, not just any tag will do. You have to 'Get" +
                    "IN, Get UP and Get OUT" +
                    "Combat: master a unique fighting technique and use improvised weapons" +
                    "Graffiti: create tags in pressure situations, using multiple skills and" +
                    "styles" +
                    "Intuition: follow your sixth sense to find the best spots to tag" +
                    "Sneak mode: infiltrate areas and avoid capture as you creep silently" +
                    "through the city" +
                    "Navigation: utilize a unique guidance system to 'get up' and tag"

                },
                new Game()
                {
                    Id = 7,
                    Name = "Euro Truck Simulator 2",
                    Image = "https://f.allegroimg.com/s512/03f36b/939fb3ce46ee98850070c1e89a2f/EURO-TRUCK-SIMULATOR-2-PL-STEAM-ETS-2-GRATIS",
                    Trailer = "https://www.youtube.com/watch?v=xlTuC18xVII",
                    Weight = 20.0,
                    Creator = "SCS Software",
                    Publisher = "SCS Software",
                    Price = 5,
                    Genre = "Simulator",
                    Description = "Join your friends and keep on truckin' together in 8 player" +
                    "Convoy multiplayer mode, now available! Start your new truck empire in the" +
                    "United States! Try the demo of American Truck Simulator and visit the Steam" +
                    "store page. Become the king of European roads - a truck driver who" +
                    "delivers important goods over long distances! Dozens of cities in the UK," +
                    "Belgium, Germany, Italy, the Netherlands, Poland and more are waiting for" +
                    "you. Test your skills, endurance and speed. Prove that you are ready to" +
                    "become part of the elite community of truckers!" +
                    "In the game you will be able to: Deliver a wide variety of cargo to 60+" +
                    "European cities. Manage your business, which grows even when you yourself" +
                    "are driving and delivering cargo. Create your truck fleet, buy garages," +
                    "hire drivers and increase the profitability of the company. Customize" +
                    "trucks to your taste: from technical specifications to appearance. Replace" +
                    "headlights, horns, flashing beacons, exhaust systems, and more on your" +
                    "cars. Drive along real roads thousands of kilometers long and see hundreds" +
                    "of famous places and structures." +
                    "World of Trucks Experience all the features of Euro Truck Simulator 2 by" +
                    "joining the World of Trucks online community. This is our hub for driver" +
                    "players around the world who are interested in Euro Truck Simulator 2 and" +
                    "future truck simulators from SCS Software. Use the in-game Photo Mode to" +
                    "capture your best moments and share them with thousands of truck lovers." +
                    "Add images you like to favorites and view them whenever you want. Discuss" +
                    "pictures with other players on the World of Trucks portal. See carefully" +
                    "selected shots in a selection updated almost every day from the creators" +
                    "of the game. Your picture can also be included! Upload your avatar and" +
                    "license plate to the game. New features coming soon!"
                },
                new Game()
                {
                    Id = 8,
                    Name = "The Witcher 2: Assassins of Kings Enhanced Edition",
                    Image = "https://savegame.pro/wp-content/uploads/2020/04/the-witcher-2-assassins-of-kings-enhanced-edition-cover.jpg",
                    Trailer = "https://www.youtube.com/watch?v=IEgBseW52JE",
                    Weight = 19.63,
                    Creator = "CD PROJECT RED",
                    Publisher = "CD PROJEKT RED, 1C-SoftClub",
                    Price = 7,
                    Genre = "Action-adventure",
                    Description = "The Witcher 2: Assassins of Kings, the second part of the" +
                    "adventures of professional monster hunter Geralt of Rivia, unfolds a" +
                    "mature, philosophical story - the sequel to one of the most detailed" +
                    "role-playing games ever released for PC. It's time for unprecedented" +
                    "chaos. Powerful forces collide in a struggle for power and greatness. The" +
                    "northern kingdoms are preparing for war. But even the armies cannot stop" +
                    "this plot, and blood will be shed..." +
                    "KEY FEATURES FASCINATING NON-LINEAR STORY: The deep non-linear plot of the" +
                    "game will not leave anyone indifferent. Embark on a long and difficult" +
                    "adventure in the original magical world from the books of Andrzej" +
                    "Sapkowski. Experience over 40 hours of story-driven gameplay with four" +
                    "start options and sixteen ending options. And remember: every decision you" +
                    "make can lead to irreversible consequences." +
                    "SPECTACULAR AND BRUTAL TACTICAL BATTLE: The unique combat system combines" +
                    "dynamic action and thoughtful role-playing game mechanics. At your" +
                    "disposal are unique magical weapons for melee and ranged combat. The" +
                    "tactical possibilities are very rich: you can create potions, set traps," +
                    "cast spells and sneak up on the enemy unnoticed."
                },
                new Game()
                {
                    Id = 9,
                    Name = "The Witcher 3: Wild Hunt",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Witcher_3_cover_art.jpg/220px-Witcher_3_cover_art.jpg",
                    Trailer = "https://www.youtube.com/watch?v=c0i88t0Kacs",
                    Weight = 49.87,
                    Creator = "CD PROJECT RED",
                    Publisher = "CD PROJEKT RED, 1C-SoftClub",
                    Price = 15,
                    Genre = "Action-adventure",
                    Description = "The Witcher 3: Wild Hunt is a story-driven open world RPG." +
                    "It takes place in an amazing magical universe, and any decision you make" +
                    "can lead to serious consequences. You play as professional monster hunter" +
                    "Geralt of Rivia, tasked with finding the Child of Destiny in a vast world" +
                    "full of trade cities, pirate islands, dangerous mountain passes and" +
                    "abandoned caves." +
                    "KEY FEATURES: PLAY AS A PROFESSIONAL MONSTER Slayer Witchers have been" +
                    "preparing to fight monsters since childhood. Thanks to mutations and" +
                    "diligent training, witchers acquire superhuman abilities, strength and" +
                    "reaction speed. Only they can fight back the monsters, which are not" +
                    "uncommon in their world. Destroy enemies without mercy as a professional" +
                    "monster hunter. You have a whole arsenal of upgradable weapons, mutagenic" +
                    "potions and combat spells at your disposal. Hunt a variety of monsters," +
                    "from wild highland creatures to cunning creatures that lurk in the dark" +
                    "alleys of big cities. With the money you earn, upgrade your weapons," +
                    "purchase unprecedented armor... or just spend it all on horse racing," +
                    "games, fistfights and other pleasant entertainment. EXPLORE AN OPEN" +
                    "FANTASTIC WORLD devoid of morality The huge world of The Witcher, created" +
                    "specifically for endless adventures, sets new standards for gaming" +
                    "universes. Explore abandoned ruins, caves and shipwrecks.Trade with" +
                    "merchants and dwarven craftsmen in cities.Hunt in the wastelands, in the" +
                    "mountains and at sea. Make deals with treacherous warlords, treacherous" +
                    "witches, and venal nobility - and render them dark and dangerous services." +
                    "Make decisions in situations where the concepts of good and evil do not" +
                    "apply -and be prepared for unexpected, far - reaching consequences. FIND" +
                    "THE CHILD OF DESIGNATION Enter into the most important contract - to find" +
                    "the Child of Destiny, the key to saving or destroying this world. At the" +
                    "height of the war, seek out the Child of Destiny, a living weapon of" +
                    "incredible power, whose coming was foretold in legends. Fight against cruel" +
                    "rulers, wild spirits and hidden threats - because everyone around you is" +
                    "obsessed with the idea of ​​​​taking over the world! And is this world worth" +
                    "saving? FULLY COMPLIANT WITH THE NEXT GENERATION Designed exclusively for" +
                    "next generation hardware, REDengine 3 recreates the world of The Witcher" +
                    "in every detail and color. A dynamic weather system and switching between" +
                    "day and night affect the behavior of people and monsters. A huge open" +
                    "world with many storylines in the main and additional scenarios is now" +
                    "even more sensitive to the actions and decisions of the player."
                },
                new Game()
                {
                    Id = 10,
                    Name = "Call of Juarez: Gunslinger",
                    Image = "https://static.wikia.nocookie.net/callofjuarez/images/d/df/Call_of_Juarez_Gunslinger.jpg/revision/latest?cb=20130518211613",
                    Trailer = "https://www.youtube.com/watch?v=OHh2RHuswqA",
                    Weight = 4.65,
                    Creator = "Techland",
                    Publisher = "Techland Publishing",
                    Price = 3,
                    Genre = "Shooter",
                    Description = "CAN YOU STAND AGAINST THE MOST DANGEROUS GUNTS OF THE WILD WEST?" +
                    "Product description: Goldfields and saloon mud: Call of Juarez®:" +
                    "Gunslinger pays homage to the tales of the Wild West. Embark on an epic" +
                    "journey through the wilderness as a ruthless bounty hunter of the most" +
                    "notorious criminals. Blurring the line between man and legend, this" +
                    "adventure will reveal an unexpected truth about the Old West's most famous" +
                    "legends."
                },
                new Game()
                {
                    Id = 11,
                    Name = "Counter Strike: Global Offensive",
                    Image = "https://cdn.windowsreport.com/wp-content/uploads/2020/06/CSGO-packet-loss-1200x1200.jpg",
                    Trailer = "https://www.youtube.com/watch?v=edYCtaNueQY",
                    Weight = 30.7,
                    Creator = "Valve, Hidden Path Entertainment",
                    Publisher = "Valve",
                    Price = 0,
                    Genre = "Shooter",
                    Description = "Counter-Strike: Global Offensive (CS:GO) expands the" +
                    "boundaries of the whirlwind team game introduced 19 years ago. CS:GO" +
                    "includes new maps, characters, weapons and game modes, as well as" +
                    "improvements to the classic CS component (de_dust2, etc.). “Counter-Strike" +
                    "surprised the entire gaming industry when an unremarkable modification" +
                    "became one of the most popular shooters in the world almost immediately" +
                    "after its release in August 1999,” says Valve's Doug Lombardi. “For 12" +
                    "years now, it has continued to be one of the most popular games in the" +
                    "world and has led the esports competition with over 25 million games sold" +
                    "worldwide. CS:GO promises to push the boundaries of the award-winning" +
                    "gaming experience and offer it to players not only on PC, but also on" +
                    "next-gen consoles and Macs.”"
                },
                new Game()
                {
                    Id = 12,
                    Name = "Rebel Cops",
                    Image = "https://s3.gaming-cdn.com/images/products/5504/orig-fallback-v1/rebel-cops-pc-mac-game-steam-cover.jpg?v=1651500912",
                    Trailer = "https://www.youtube.com/watch?v=WtvX2FOk8Ew",
                    Weight = 2.02,
                    Creator = "Weappy Studio",
                    Publisher = "THQ Nordic",
                    Price = 5,
                    Genre = "Strategy",
                    Description = "Rebel Cops is a spin-off of This Is the Police entirely" +
                    "dedicated to turn-based tactical operations. Lead a squad of ragged cops" +
                    "in rebellion against the criminal authorities and see how long you can" +
                    "hold out when supplies are constantly in short supply, and a single" +
                    "bullet can cost your fighter his life. " +
                    "You are not quite the police, but only you now protect the law: Viktor Zuev," +
                    "a brutal crime lord, took over Ripton in a matter of weeks, subjugating the" +
                    "local elite and even the police department. With the help of blackmail and" +
                    "threats, Zuev keeps the whole city in fear. The only ones who dared to" +
                    "oppose him were a small detachment of former policemen who refused to serve" +
                    "the new government and handed over their badges. The goal is to send Viktor" +
                    "Zuev to jail. The chances are slim, but the townspeople have no one else to" +
                    "rely on."
                },
                new Game()
                {
                    Id = 13,
                    Name = "The Long Dark",
                    Image = "https://static.wikia.nocookie.net/intothelongdark/images/8/8d/The_Long_Dark_Poster.jpg/revision/latest?cb=20171129011333",
                    Trailer = "https://www.youtube.com/watch?v=WJ-1O_w2KTg",
                    Weight = 12.88,
                    Creator = "Hinterland Studio Inc.",
                    Publisher = "Hinterland Studio Inc.",
                    Price = 10,
                    Genre = "Survival",
                    Description = "A bright light cuts through the night sky. The wind rages" +
                    "behind the thin walls of your wooden hut. A wolf howls in the distance." +
                    "Looking around the meager supplies in your backpack, you recall with a" +
                    "sigh the days before the mysterious blackout. How much more can you" +
                    "survive? Meet THE LONG DARK with its new take on survival and exploration" +
                    "- what Wired magazine called 'the icing on the cake of the entire genre.'" +
                    "The Long Dark is an elaborate survival and exploration game where players" +
                    "will have to make their own decisions as they travel through a vast, cold" +
                    "wilderness that has survived a geomagnetic disaster. There are no zombies" +
                    "in it - just you, the cold and what Mother Nature has prepared for you." +
                    "Part of the first story season of The Long Dark, WINTERMUTE includes two" +
                    "of its five episodes. In December 2018, in the Redux update, we radically" +
                    "redesigned both episodes: we changed the quest system, rewrote the plot," +
                    "dialogue, animation, and more." +
                    "EPISODE 1: Long-range pilot Will Mackenzie (player character) and Dr." +
                    "Astrid Greenwood find themselves separated when a mysterious flash of" +
                    "light causes their plane to crash into the wilds of northern Canada." +
                    "Desperate to survive and find Astrid, Mackenzie comes to the town of" +
                    "Milton, where he begins to realize the extent of this silent catastrophe." +
                    "EPISODE 2: 'Light Fugue' Astrid's search leads Mackenzie deep into the" +
                    "snow-covered wilderness. Perhaps the mysterious trapper will be able to" +
                    "help him, but can he be trusted?" +
                    "The first two episodes of 'WINTERMUTE' take about 15 game hours. The next" +
                    "three episodes are included in the price of the game and will be unlocked" +
                    "for free when released. The characters were voiced by Jennifer Hale, Mark" +
                    "Mir, David Hayter and Elias Toufexis (third episode). Music composed by" +
                    "Chris Velasco." +
                    "Survival Mode is a free survival oriented storyless sandbox mode that has" +
                    "been polished for nearly three years in Early Access. Your goal is" +
                    "survival, and death is the only end of the path. Write your story in every" +
                    "game." +
                    "NO HINTS: The game calls for making decisions on their own, providing" +
                    "players with information, but not answers.You must earn your right to live." +
                    "PERMANENT DEATH: At the time of death in survival mode, the saved game will" +
                    "be deleted.Every decision matters. [In 'WINTERMUTE', the permanent death" +
                    "function is not used.]" +
                    "STATE OF THE ORGANISM AND CALORIES: Keep track of hunger, thirst and" +
                    "temperature, trying to find a balance between the search for resources and" +
                    "the forces expended on it.Every action burns calories, and time is your most" +
                    "valuable resource.Think before you do anything." +
                    "LOOK FOR SUPPLIES: Over 100 pieces of gear including tools, lights, weapons," +
                    "first aid supplies, clothing and more." +
                    "HUGE LIVING WORLD: Explore 50 square kilometers of the wilderness of" +
                    "northern Canada in search of supplies. In winter. The dynamic change of" +
                    "time of day, weather, presence of wild animals and other factors only" +
                    "complicates this process." +
                    "THE FITTEST WILL SURVIVE: Hunt, fish, set traps, climb, draw maps, look for" +
                    "food and equipment that can save your life, avoid encounters with dangerous" +
                    "animals, avoid hypothermia, frostbite, dysentery(and other unpleasant" +
                    "complications), find and repair equipment.You will face wolves, bears, moose," +
                    "rabbits, deer, crows and many more in future updates.Hunt them or become prey" +
                    "- it's all up to you." +
                    "CHOOSE YOUR PATH: Four levels of difficulty give you the opportunity to" +
                    "choose the level of challenge that suits you, ranging from 'Pilgrim'," +
                    "designed for a calm and thoughtful passage, to 'Intruder', in which even" +
                    "the most experienced players will last only a week.If none of them suits" +
                    "you - create the one that will be to your liking using the 'Custom Mode'." +
                    "Music composed by Sasha Dikisian." +
                    "Several separate challenge modes offer tasks that take 1-3 hours to" +
                    "complete. For example, 'Whiteout', where in a limited time you need to" +
                    "collect enough supplies to survive a terrible snowstorm. Or 'Victim'," +
                    "where you have to run away from a bloodthirsty bear. Complete them to" +
                    "unlock Deeds, long-term upgrades in Survival Mode. There will be five" +
                    "challenges available at launch, with more to come." +
                    "In addition to releasing the three remaining episodes of WINTERMUTE, we" +
                    "plan to keep improving Survival Mode as we always have (we've released" +
                    "almost 100 updates/patches in three years of Early Access). The price of" +
                    "The Long Dark includes all five episodes of WINTERMUTE and subsequent" +
                    "survival mode updates." +
                    "SUBSCRIBE TO NEWSLETTER" +
                    "JOIN THE COMMUNITY" +
                    "A LITTLE ABOUT HINTERLAND: Hinterland is a small independent developer of" +
                    "original interactive entertainment. Headquartered in Vancouver, Canada," +
                    "The Long Dark is built by veteran AAA game developers, with leading" +
                    "developers working at renowned companies such as Valve, Ubisoft Montreal," +
                    "Relic, Volition, Capcom, Radical, BioWare, Sony London, United Front" +
                    "games and others." +
                    "info(at)hinterlandgames(dot)com" +
                    "hinterlandgames.com" +
                    "thelongdark.com"
                },
                new Game()
                {
                    Id = 14,
                    Name = "American Truck Simulator",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/20/American_Truck_Simulator_Steam_Cover.jpg/220px-American_Truck_Simulator_Steam_Cover.jpg",
                    Trailer = "https://www.youtube.com/watch?v=Yu32OisFgWI",
                    Weight = 12.0,
                    Creator = "SCS Software",
                    Publisher = "SCS Software",
                    Price = 11,
                    Genre = "Simulator",
                    Description = "Join your friends and keep on truckin' together in 8 player" +
                    "Convoy multiplayer mode, now available! Start your new truck empire in" +
                    "Europe! Try the demo of Euro Truck Simulator 2 and visit the Steam store" +
                    "page. Experience legendary American trucks and deliver various cargoes" +
                    "across sunny California, sandy Nevada, and the Grand Canyon State of" +
                    "Arizona. American Truck Simulator takes you on a journey through the" +
                    "breathtaking landscapes and widely recognized landmarks around the States." +
                    "Game mechanics are based on the highly successful model from Euro Truck" +
                    "Simulator 2 and have been expanded with new features, creating the most" +
                    "captivating game experience from SCS Software. American Truck Simulator" +
                    "puts you in the seat of a driver for hire entering the local freight" +
                    "market, making you work your way up to become an owner -operator, and go" +
                    "on to create one of the largest transportation companies in the United" +
                    "States." +
                    "Features: Drive highly detailed truck models officially licensed from" +
                    "iconic truck manufacturers. Your truck is your new home. Make it yours by" +
                    "changing cabins, chassis, paintjobs, adding tuning accessories or more" +
                    "powerful engines. Lots of different cargoes to choose: From food to" +
                    "machinery to hazard cargoes. " +
                    "Multiple types of trailers – from reefers to flatbeds, from dumpers to" +
                    "lowboys and goosenecks. The longest trailers (up to 53 ft) will challenge" +
                    "your skills and patience while hauling and during parking. " +
                    "Deliver your cargoes to a rich variety of companies and locations like" +
                    "refineries, oil storage, gas stations, car factories, or roadworks."
                },
            };
        }

        public static Game GetGamesById(int id)
        {
            return GetGames().FirstOrDefault(g => g.Id == id);
        }
    }
}
