using snakeHume.GL;
using snakeHume.Helpers;

namespace snakeHume.UI
{
    public partial class testBoard : Form
    {
        private const string appleTitle = "justAnApple";
        private const string snakeTitle = "snakeHead";

        private snakeHume.GL.Snake snakeBody = new snakeHume.GL.Snake();
        private snakeHume.GL.Apple appleMap = new snakeHume.GL.Apple();
        private snakeHume.GL.Board snakeBoard = new snakeHume.GL.Board();
        private snakeHume.Helpers.arrayFunction snakeArrayHelpers = new snakeHume.Helpers.arrayFunction();

        public testBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lstBoxResults.Items.Clear();

                int xPositionByRef = 0;
                int yPositionByRef = 0;

                string tmpMessage = "";
                tmpMessage = "getting Snake's initial's body count: " + snakeBody.snakeBodyLenght.ToString();
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                tmpMessage = "adding a new Apple to the Snake's body count..." ;
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");
                snakeBody.snakeAddApple();

                tmpMessage = "getting most recent Snake's body count: " + snakeBody.snakeBodyLenght.ToString();
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                tmpMessage = "finding Apple's initial's [14,6] coord on Board: " + snakeBoard.snakeBoardCoordinates[14, 6];
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                tmpMessage = "getting most recent Apple's Coord X/Y on Board: " + appleMap.snakeAppleX + " / " + appleMap.snakeAppleY;
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                tmpMessage = "generating new Apple's Random Coord X/Y on Board...";
                lstBoxResults.Items.Add(tmpMessage);
                appleMap.appleNewPosition(ref xPositionByRef, ref yPositionByRef);
                lstBoxResults.Items.Add("");

                tmpMessage = "updating most recent Apple's Coord X/Y on Snake Object...";
                lstBoxResults.Items.Add(tmpMessage);
                snakeBoard.boardUpdateApplePosition(xPositionByRef, yPositionByRef);
                lstBoxResults.Items.Add("");

                tmpMessage = "checking that recent generated Random Coord[" + xPositionByRef.ToString() + "," + yPositionByRef.ToString() + "] for the Apple are correct: " + snakeBoard.snakeBoardCoordinates[xPositionByRef, yPositionByRef];
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                tmpMessage = "searching for the most recent Apple's Coord X/Y on Board by KEY-Name 'justAnApple' on Array[,]...";
                lstBoxResults.Items.Add(tmpMessage);
                snakeArrayHelpers.getXYCoordByValue(snakeBoard.snakeBoardCoordinates, appleTitle, ref xPositionByRef, ref yPositionByRef);
                lstBoxResults.Items.Add("");

                tmpMessage = "getting most recent Apple's Coord X/Y on Board: " + appleMap.snakeAppleX + " / " + appleMap.snakeAppleY;
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                btnMoveSnakeRight.Enabled = true;

                btnStart.Enabled= false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                btnMoveSnakeRight.Enabled = false;
                lstBoxResults.Items.Clear();
            }
        }

        private void btnMoveSnakeRight_Click(object sender, EventArgs e)
        {
            try
            {
                int xPositionByRef = 0;
                int yPositionByRef = 0;

                string tmpMessage = "";

                tmpMessage = "finding Snakes's initial's [6,6] coord on Board: " + snakeBoard.snakeBoardCoordinates[6, 6];
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                tmpMessage = "moving the Snake Head 4 positions to the Right and updating values...";
                lstBoxResults.Items.Add(tmpMessage);
                snakeArrayHelpers.getXYCoordByValue(snakeBoard.snakeBoardCoordinates, snakeTitle, ref xPositionByRef, ref yPositionByRef);
                snakeBoard.boardUpdateSnakeHeadPosition(xPositionByRef + 4, yPositionByRef);
                lstBoxResults.Items.Add("");

                tmpMessage = "searching for the most recent Snake's Coord X/Y on Board by KEY-Name 'snakeHead' on Array[,]...";
                lstBoxResults.Items.Add(tmpMessage);
                snakeArrayHelpers.getXYCoordByValue(snakeBoard.snakeBoardCoordinates, snakeTitle, ref xPositionByRef, ref yPositionByRef);
                lstBoxResults.Items.Add("");

                tmpMessage = "getting most recent Snake's Coord X/Y on Board: " + xPositionByRef + " / " + yPositionByRef;
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                tmpMessage = "checking that recent generated Random Coord[" + xPositionByRef.ToString() + "," + yPositionByRef.ToString() + "] for the Apple are correct: " + snakeBoard.snakeBoardCoordinates[xPositionByRef, yPositionByRef];
                lstBoxResults.Items.Add(tmpMessage);
                lstBoxResults.Items.Add("");

                btnMoveSnakeRight.Enabled = false;
                btn_close.Enabled= true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                btnMoveSnakeRight.Enabled = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            testBoard.ActiveForm.Close();
        }
    }
}