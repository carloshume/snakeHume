namespace snakeHume.Helpers
{
    public class arrayFunction
    {
        public arrayFunction() 
        { 
        
        }

        public bool getXYCoordByValue(string[,] data, string valToCheck, ref int xPos, ref int yPos) 
        {
            try
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        if (valToCheck.Equals(data[i, j]))
                        {
                            xPos = i;
                            yPos = j;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return true;
        }

    }
}