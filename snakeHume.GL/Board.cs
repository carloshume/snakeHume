using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeHume.GL
{
    public class Board : IBoard
    {
        private const string appleTitle = "justAnApple";
        private const string snakeTitle = "snakeHead";

        private snakeHume.Model.Board snakeBoard = new snakeHume.Model.Board();
        public string[ , ] snakeBoardCoordinates
        {
            get
            {
                return snakeBoard.boardCoordinates;
            }
        }

        public Board()
        {

        }

        public bool boardUpdateApplePosition(int appleX, int appleY)
        {
            try
            {
                snakeBoard.boardCoordinates[appleX, appleY] = appleTitle;
            }                        
            catch(Exception ex){
                throw;
            }

            return true;
        }

        public bool boardUpdateSnakeHeadPosition(int snakeHeadX, int snakeHeadY)
        {
            try
            {
                snakeBoard.boardCoordinates[snakeHeadX, snakeHeadY] = snakeTitle;
            }
            catch (Exception ex)
            {
                throw;
            }

            return true;
        }

    }
}
