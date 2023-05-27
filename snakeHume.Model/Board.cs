using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeHume.Model
{
    public class Board
    {
        public string[,] boardCoordinates = new string[20,12];
        public Board()
        {
            boardCoordinates[6, 6] = "snakeHead";
            boardCoordinates[14, 6] = "justAnApple";
        }
    }
}
