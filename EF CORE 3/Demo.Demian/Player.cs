using System;
using System.Collections.Generic;

namespace Demo.Demian
{
    //球员
    public class Player
    {
        public Player()
        {
            gamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirthdath { get; set; }
        public List<GamePlayer> gamePlayers { get; set; }
    }
}