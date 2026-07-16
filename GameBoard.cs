using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XO_Game.Properties;

namespace XO_Game
{
    public partial class GameBoard : Form
    {
        enum enPlayer { Player1, Player2 }

        enum enWinner { Player1, Player2, Draw, InProgress }

        struct stGameState
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;
        }


        enPlayer PlayerTurn = enPlayer.Player1;
        stGameState GameState;

        public GameBoard()
        {
            InitializeComponent();
        }

        void EndGame()
        {
            lblTurn.Text = "Game Over";
            
            switch(GameState.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            string Result = lblWinner.Text;

            if (Result != "Draw")
                Result += " Wins";

            MessageBox.Show(
                "Game Over!\nResult: " + Result,
                "Game Over",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            bool IsThereNoEmptyBoxes = (btn1.Tag.ToString() != "?" && btn2.Tag.ToString() != "?" &&
                btn3.Tag.ToString() != "?");

            if(IsThereNoEmptyBoxes && btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.Cyan;
                btn2.BackColor = Color.Cyan;
                btn3.BackColor = Color.Cyan;

                if(btn1.Tag.ToString() == "X")
                {
                    GameState.Winner = enWinner.Player1;
                    GameState.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameState.Winner = enWinner.Player2;
                    GameState.GameOver = true;
                    EndGame();
                    return true;
                }
                
            }

            GameState.GameOver = false;
            return false;
        }
        void CheckWinner()
        {
            //checked rows
            //check Row1
            if (CheckValues(Button1, Button2, Button3))
                return;

            //check Row2
            if (CheckValues(Button4, Button5, Button6))
                return;

            //check Row3
            if (CheckValues(Button7, Button8, Button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(Button1, Button4, Button7))
                return;

            //check col2
            if (CheckValues(Button2, Button5, Button8))
                return;

            //check col3
            if (CheckValues(Button3, Button6, Button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(Button1, Button5, Button9))
                return;

            //check Diagonal2
            if (CheckValues(Button3, Button5, Button7))
                return;
        }
        void PlayTurn(Button btn)
        {
            if(btn.Tag.ToString() == "?" && !GameState.GameOver)
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.BackgroundImage = Resources.XNew;
                        PlayerTurn = enPlayer.Player2;
                        btn.Tag = "X";
                        lblTurn.Text = "Player2";
                        GameState.PlayCount++;
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.BackgroundImage = Resources.ONew;
                        PlayerTurn = enPlayer.Player1;
                        btn.Tag = "O";
                        lblTurn.Text = "Player1";
                        GameState.PlayCount++;
                        CheckWinner();
                        break;
                }
            }
            else
            {
                string ErrorMessage = "Wrong Choice!";

                if (GameState.GameOver)
                    ErrorMessage = "Game Over!\nRestart The Game To Play Again.";

                MessageBox.Show(
                    ErrorMessage,
                    "Wrong!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if(GameState.PlayCount == 9)
            {
                GameState.GameOver = false;
                GameState.Winner = enWinner.Draw;
                EndGame();
            }
        }
        private void BoardButtons_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            PlayTurn(Btn);
        }


        void ResetButton(Button btn)
        {
            btn.BackgroundImage = Resources.PuncNew;
            btn.BackColor = Color.Transparent;
            btn.Tag = "?";
        }
        void RestartGame()
        {
            ResetButton(Button1);
            ResetButton(Button2);
            ResetButton(Button3);
            ResetButton(Button4);
            ResetButton(Button5);
            ResetButton(Button6);
            ResetButton(Button7);
            ResetButton(Button8);
            ResetButton(Button9);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player1";
            GameState.GameOver = false;
            GameState.PlayCount = 0;
            GameState.Winner = enWinner.InProgress;
            lblWinner.Text = "In Progress";
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }


        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            Color Blue = Color.FromArgb(255, 0, 0, 82);

            Pen Pen = new Pen(Blue);
            Pen.Width = 15;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 621, 326, 1226, 326);
            e.Graphics.DrawLine(Pen, 621, 507, 1226, 507);
            e.Graphics.DrawLine(Pen, 808, 174, 808, 670);
            e.Graphics.DrawLine(Pen, 1033, 174, 1033, 670);
        }

        
    }
}
