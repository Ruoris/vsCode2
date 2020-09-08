using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using System.Collections.Generic;

namespace AuxiliaryFunctions
{
    public static class Auxiliary
    {

        //Kohta 1 käyttää tätä
        public static void CreateMillionPlayers()
        {

            var player = new Player[1000000];

            var bigHeapOGuids = new HashSet<Guid>();



            //int c = 0;
            for (long i = 0; i < player.Length; i++)
            {
                player[i] = new Player();
                Guid g = Guid.NewGuid();
                if (bigHeapOGuids.Contains(g))
                {
                    Console.WriteLine("duplicate found");
                }
                else
                {
                    bigHeapOGuids.Add(g);
                    player[i].Id = g;
                }
                // Console.WriteLine(i);



            }




        }
        //Kohta2 käyttää tätä
        public static void CreateItems()
        {
            Player player = new Player();

            player.Items = new List<Item>();
            player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 200, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 9, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 12, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 16555, Id = Guid.NewGuid() });


            Item highestItem = player.GetHighestLevelItem();
            Console.WriteLine(highestItem.Level);



        }
        //Kohta 3 Ajaa tän kautta

        public static void Kohta3()
        {
            Player player = new Player();

            player.Items = new List<Item>();
            player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 200, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 9, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 12, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 16555, Id = Guid.NewGuid() });

            Item[] arrayedListWithForLoop = Auxiliary.GetItems(player);
            Item[] arrayedListWithLinq = Auxiliary.GetItemsWithLinq(player);

            for (int i = 0; i < arrayedListWithForLoop.Length; i++)
            {
                Console.WriteLine(arrayedListWithForLoop[i].Level);
            }

            Console.WriteLine("Ja tulokset linq menetelmäl");
            for (int i = 0; i < arrayedListWithLinq.Length; i++)
            {
                Console.WriteLine(arrayedListWithLinq[i].Level);
            }

        }




        public static Item[] GetItemsWithLinq(Player player)
        {


            return player.Items.ToArray();
        }
        public static Item[] GetItems(Player player)
        {
            Item[] arrayOfItems = new Item[player.Items.Count];

            for (int i = 0; i < player.Items.Count; i++)
            {

                arrayOfItems[i] = player.Items[i];
            }

            return arrayOfItems;


        }

        public static void Kohta4()
        {
            Player player = new Player();

            player.Items = new List<Item>();
            player.Items.Add(new Item() { Level = 6, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 1, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 5, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 200, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 7, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 9, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 12, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 165555, Id = Guid.NewGuid() });
            player.Items.Add(new Item() { Level = 3, Id = Guid.NewGuid() });

            Player nullplayer = new Player();

            nullplayer.Items = new List<Item>();

            Console.WriteLine(Auxiliary.FirstItem(player).Level);
            if (Auxiliary.FirstItem(nullplayer) == null)
            {
                Console.WriteLine("First was null");
            }

            Console.WriteLine(Auxiliary.FirstItemWithLinq(player).Level);
            if (Auxiliary.FirstItemWithLinq(nullplayer) == null)
            {
                Console.WriteLine("Linq First was null");
            }



        }
        public static Item FirstItem(Player player)
        {
            if (player.Items.Count != 0)
            {
                return player.Items[0];
            }
            else
            {
                return null;
            }
            // return player.Items.FirstOrDefault(item =>item!=)

        }
        public static Item FirstItemWithLinq(Player player)
        {

            return player.Items.FirstOrDefault();

        }

        public delegate void ProcessEachItem(Player player, Action<Item> process);
        public delegate void PrintItem(Item item);
    }
}

