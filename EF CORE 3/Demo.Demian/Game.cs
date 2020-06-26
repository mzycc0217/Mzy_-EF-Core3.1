using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demian
{
    //比赛
   public class Game
    {
        //构造函数初始化
        public Game()
        {
            gamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
       // 轮
        public int Round { get; set; }
        //可空的
        public DateTimeOffset? StartTime { get; set; }
        public List<GamePlayer> gamePlayers { get; set; }
    }
}
