using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeHume.GL
{
    internal interface IBoard
    {
        public bool boardUpdateApplePosition(int appleX, int appleY);
        public bool boardUpdateSnakeHeadPosition(int snakeHeadX, int snakeHeadY);
    }
}
