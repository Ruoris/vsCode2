using System;
using System.Collections.Generic;
public class Player : IPlayer, IComparable<Player>
{
    public Guid Id { get; set; }
    public int Score { get; set; }
    public List<Item> Items { get; set; }

    public int CompareTo(Player player)
    {
        // A null value means that this object is greater.
        if (player == null)
        {
            return 1;
        }
        else
        {
            return this.Score.CompareTo(player.Score);
        }

    }

}

public static class MyExtensions
{
    public static Item GetHighestLevelItem(this Player player)
    {
        List<Item> playersItems = player.Items;
        int maxval = int.MinValue;
        int theIndex = 0;
        for (int i = 0; i < playersItems.Count; i++)
        {
            if (maxval < playersItems[i].Level)
            {
                maxval = playersItems[i].Level;
                theIndex = i;
            }
        }

        return player.Items[theIndex];
    }
}