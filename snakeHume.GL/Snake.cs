using snakeHume.Model;

namespace snakeHume.GL
{
    public class Snake : ISnake
    {
        private snakeHume.Model.Snake snakeBody = new snakeHume.Model.Snake();
        public int snakeBodyLenght
        {
            get
            {
                return snakeBody.snkLenght.Count;
            }
        }
        public Snake()
        {

        }

        public bool snakeAddApple()
        {         
            try
            {
                snakeBody.snkLenght.Add(1);
            }
            catch(Exception ex){
                throw;
            }

            return true;
        }
    }
}