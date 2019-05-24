using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    public partial class Form1 : Form
    {
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0, turn = 1, player1 = 0, player2 = 0;

        class Player
        {
            public string getPlayer1()
            {
                return "X";
            }
            public string getPlayer2()
            {
                return "O";
            }
        }

        public Form1()
        {
            InitializeComponent();
            Text = "Tic-Tac-Toe Game";           
            label10.Text = "Note:" + Environment.NewLine + "- Player 1 = (X)" + Environment.NewLine + "- Player 2 = (O)";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)//start
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            label2.Text = "Player 1";
            button10.Enabled = false;
            button11.Enabled = true;
            label5.Text = player1.ToString();
            label6.Text = player2.ToString();
        }

        private void Button11_Click(object sender, EventArgs e)//reset
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Game akan dimulai dari awal dan seluruh\npoin akan dikembalikan ke 0. \n\nLanjutkan?", "Reset", buttons);
            if (result == DialogResult.Yes)
            {
                Cleargame();
                label2.Text = "";
                label5.Text = "";
                label6.Text = "";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = true;
                button11.Enabled = false;
                player1 = 0; player2 = 0;
            }
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = dkp.getPlayer1();
                }
                else
                {
                    button1.Text = dkp.getPlayer2();
                }
                turn++;
                click1++;
            }            
            Display();
            Check();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = dkp.getPlayer1();
                }
                else
                {
                    button2.Text = dkp.getPlayer2();
                }
                turn++;
                click2++;
            }
            Display();
            Check();
        }
      
        private void Button3_Click(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = dkp.getPlayer1();
                }
                else
                {
                    button3.Text = dkp.getPlayer2();
                }
                turn++;
                click3++;
            }
            Display();
            Check();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = dkp.getPlayer1();
                }
                else
                {
                    button4.Text = dkp.getPlayer2();
                }
                turn++;
                click4++;
            }
            Display();
            Check();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = dkp.getPlayer1();
                }
                else
                {
                    button5.Text = dkp.getPlayer2();
                }
                turn++;
                click5++;
            }
            Display();
            Check();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = dkp.getPlayer1();
                }
                else
                {
                    button6.Text = dkp.getPlayer2();
                }
                turn++;
                click6++;
            }
            Display();
            Check();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = dkp.getPlayer1();
                }
                else
                {
                    button7.Text = dkp.getPlayer2();
                }
                turn++;
                click7++;
            }
            Display();
            Check();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = dkp.getPlayer1();
                }
                else
                {
                    button8.Text = dkp.getPlayer2();
                }
                turn++;
                click8++;
            }
            Display();
            Check();
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            Player dkp = new Player();
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = dkp.getPlayer1();
                }
                else
                {
                    button9.Text = dkp.getPlayer2();
                }
                turn++;
                click9++;
            }
            Display();
            Check();
        }

        public void Display()
        {
            if (turn % 2 != 0)
            {
                label2.Text = "Player 1";
            }
            else
            {
                label2.Text = "Player 2";
            }
        }

        public void Check()
        {
            Player dkp = new Player();
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    if (button1.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    if (button4.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button7.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button1.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    if (button2.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button3.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button1.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button3.Text == dkp.getPlayer1())
                    {
                        MessageBox.Show("Player 1 Menang!", "Selamat!!");
                        player1++;
                        label5.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Menang!", "Selamat!!");
                        player2++;
                        label6.Text = player2.ToString();
                    }
                    Cleargame();
                }
            }
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Seri!");
                Cleargame();
            }
        }

        public void Cleargame()
        {
            click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0; turn = 1;
            label2.Text = "Player 1";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Black;
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Black;
        }       
    }
}
