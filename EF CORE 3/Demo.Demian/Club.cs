using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Demian
{//足球队
   public class Club
    {
        public Club()
        {
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        [Column(TypeName ="date")]
        public DateTime DateofEstablishment { get; set; }
        public string History { get; set; }
        public League League { get; set; }//导航属性  一对多      
        public List<Player> Players { get; set; }//多个球员，导航属性。在构造函数中初始化一下
    }
}
