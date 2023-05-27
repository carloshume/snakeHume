using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeHume.GL
{
    public class Apple : IApple
    {
        private snakeHume.Model.Apple appleMap = new snakeHume.Model.Apple();
        public int snakeAppleX
        {
            get
            {
                return appleMap.xPosition;
            }
        }
        public int snakeAppleY
        {
            get
            {
                return appleMap.yPosition;
            }
        }
        public Apple()
        {

        }

        public bool appleNewPosition(ref int xPositionByRef, ref int yPositionByRef)
        {
            try 
            { 
            Random rnd = new Random();

            appleMap.xPosition = rnd.Next(20);
            appleMap.yPosition = rnd.Next(12);

            xPositionByRef = appleMap.xPosition;
            yPositionByRef = appleMap.yPosition;

            return true;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
