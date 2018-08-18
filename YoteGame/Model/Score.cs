using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoteGame.Model
{
    public class Score
    {
        public int Player_1 { get; set; }
        public int Player_2 { get; set; }

        public Score() { }
        public Score(int p1, int p2)
        {
            Player_1 = p1;
            Player_2 = p2;
        }
    }
}
