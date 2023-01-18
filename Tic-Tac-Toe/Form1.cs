namespace Tic_Tac_Toe
{
    public partial class Form1 : Form

        
    {
        int scoreO = 0;
        int scoreX = 0;
        string symbol = " ";
        int plays = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void xBttn_Click(object sender, EventArgs e)
        {
            symbol = "X";
        }

        private void oBttn_Click(object sender, EventArgs e)
        {
            symbol = "O";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = symbol;
            isWin();
            plays++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = symbol;
            isWin();
            plays++;
            IsNine();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = symbol;
            isWin();
            plays++;
            IsNine();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = symbol;
            isWin();
            plays++;
            IsNine();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = symbol;
            isWin();
            plays++;
            IsNine();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = symbol;
            plays++;
            isWin();
            IsNine();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = symbol;
            isWin();
            plays++;
            IsNine();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = symbol;
            isWin();
            plays++;
            IsNine();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = symbol;
            isWin();
            plays++;
            IsNine();

        }
        public void IsNine()
        {
            if (plays == 9)
            {
                plays = 0;
                if (symbol == "X")
                {scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                }
                else if (symbol == "X")
                {
                    scoreX++;
                }
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button8.Text = "";
                button9.Text = "";
                button7.Text = "";
                button10.Text = $"Score: X : {scoreX}, O : {scoreO}";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }
        private void isWin()
        {
            if (symbol == "O")
            {
                if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {scoreO++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
            }
            else if (symbol == "X")
            {
                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    scoreX++;
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button7.Text = "";
                    plays = 0;

                }


            }
            button10.Text = $"Score: X : {scoreX}, O : {scoreO}";
        }

    }
}