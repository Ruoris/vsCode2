using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using System.Collections.Generic;
using AuxiliaryFunctions;
namespace vsCode2
{

    class Program
    {
        public static void ProcessEachItem(Player player, Action<Item> process)
        {
            foreach (Item i in player.Items)
            {
                process(i);
            }
        }



        public static void PrintItem(Item item)
        {
            Console.WriteLine("Item id is: " + item.Id + " and level is: " + item.Level);
        }
        static void Main(string[] args)
        {
            // Kohta 1
            // Auxiliary.CreateMillionPlayers();
            // Console.WriteLine("Waiting results");
            // Console.WriteLine("Done");


            // Kohta 2

            // Auxiliary.CreateItems();




            //  Kohta 3
            // Auxiliary.Kohta3();

            //Kohta 4
            //Auxiliary.Kohta4();

            //Kohta 5

            // Player player = new Player();

            // player.Items = new List<Item>();
            // player.Items.Add(new Item() { Level = 6, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 200, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 9, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 12, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 3, Id = Guid.NewGuid() });
            // Action<Item> delegaatti = PrintItem;

            // ProcessEachItem(player, delegaatti);





            //Kohta 6

            // Action<Player, Action<Item>> Processeachitem = (player, process) =>
            // {
            //     foreach (Item i in player.Items)
            //     {
            //         process(i);
            //     }
            // };
            // Action<Item> delegaatti = (item) => Console.WriteLine("Item id is: " + item.Id + " and level is: " + item.Level);
            // Player player = new Player();

            // player.Items = new List<Item>();
            // player.Items.Add(new Item() { Level = 6, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 200, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 9, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 12, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            // player.Items.Add(new Item() { Level = 3, Id = Guid.NewGuid() });

            // Processeachitem(player, delegaatti);


            //Kohta 7


            List<Player> players = new List<Player>();
            List<PlayerForAnotherGame> playerForAnotherGames = new List<PlayerForAnotherGame>();



            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                int c = random.Next(1000);
                players.Add(new Player() { Score = c });
                playerForAnotherGames.Add(new PlayerForAnotherGame() { Score = c });

            }


            Game<Player> game = new Game<Player>(players);
            Game<PlayerForAnotherGame> anotherGame = new Game<PlayerForAnotherGame>(playerForAnotherGames);

            Player[] top10players = game.GetTop10Players();
            PlayerForAnotherGame[] top10ofAnotherGame = anotherGame.GetTop10Players();

            foreach (Player player in top10players)
            {
                Console.WriteLine(player.Score);
            }
            Console.WriteLine("And results from another Game: ");
            foreach (PlayerForAnotherGame player in top10ofAnotherGame)
            {
                Console.WriteLine(player.Score);
            }


        }



    }



}

