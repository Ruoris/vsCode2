
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using System.Collections.Generic;
using AuxiliaryFunctions;

public class Game<T> where T : IPlayer
{
    private List<T> _players;

    public Game(List<T> players)
    {
        _players = players;
    }

    public T[] GetTop10Players()
    {
        T[] topPlayers = new T[10];


        _players = _players.OrderBy(player => player.Score).ToList();
        int j = 0;
        for (int i = _players.Count - 1; j < 10; j++, i--)
        {
            topPlayers[j] = _players[i];
        }


        return topPlayers;


    }
}