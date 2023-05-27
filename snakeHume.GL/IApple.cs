using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeHume.GL
{
    internal interface IApple
    {
        public bool appleNewPosition(ref int xPositionByRef, ref int yPositionByRef);
    }
}
