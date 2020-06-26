using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Demian
{
  public class GamePlayer
    {
        //防止空引用所以指针
      
        public int PlayerId { get; set; }//联合主键
        public int GameId { get; set; }
        public Game Game { get; set; }
        public Player Player { get; set; }
      

      
    }
}
