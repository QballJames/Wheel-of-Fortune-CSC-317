using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Wheel_of_Fortune_CSC_317
{
    public class txtBox : System.Windows.Forms.TextBox
    {
        public txtBox()
        {
            this.Width = 40;
            this.Height = 40;
            this.BackColor = Color.White;
            this.Font = new Font("Georgia", 16);
            this.TextAlign = HorizontalAlignment.Center;
            this.ReadOnly = true;
            this.Enabled = false;
            this.UseSystemPasswordChar = true;
            this.ForeColor = Color.Black;
            this.Visible = true;
        }
        public txtBox(string z)
        {
            this.Width = 40;
            this.Height = 40;
            this.BackColor = Color.White;
            this.Font = new Font("Georgia", 16);
            this.TextAlign = HorizontalAlignment.Center;
            this.ReadOnly = true;
            this.Enabled = false;
            this.UseSystemPasswordChar = true;
            this.ForeColor = Color.Black;
            this.Visible = true;
        }
        public txtBox(txtBox p)
        {
            this.Width = p.Width;
            this.Height = p.Height;
            this.BackColor = p.BackColor;
            this.Name = p.Name;
            this.Font = p.Font;
            this.TextAlign = HorizontalAlignment.Center;
            this.ReadOnly = true;
            this.Enabled = false;
            this.UseSystemPasswordChar = true;
            this.ForeColor = Color.Black;
            this.Visible = true;
        }
    }

    public class word
    {
        public int size;
        public string password;
        public txtBox[] txtBox;
        public int lettersGuessed;

        public word()
        {
            size = 0;
            txtBox = new txtBox[password.Length];
            password = "0";
            lettersGuessed = 0;
        }

        public word(string s)
        {
            txtBox = new txtBox[s.Length];
            size = s.Length;
            password = s;

            for (int i = 0; i <txtBox.Length; i++)
            {
                txtBox[i] = new txtBox();
                txtBox[i].Name = "Letter " + i;
                txtBox[i].Location = new Point(60 * i + 80, 120);
                txtBox[i].Text = Convert.ToString(password[i]);
            }
        }
    }

    public class Letter
    {
        public int x;
        public int y;
        public char sign;
        public int size;
        public bool state;

        public Letter()
        {
            this.x = 0;
            this.y = 0;
            this.sign = '0';
            this.size = 40;
            this.state = false;
        }

        public Letter(char z)
        {
            this.x = 0;
            this.y = 0;
            this.sign = z;
            this.size = 40;
            this.state = false;
        }
    }

    public class Wheel
    {
        public Bitmap picture;
        public Bitmap tempPicture;
        public int spin;
        public int[] wheelValues;
        public float val;
        
        
        public Wheel()
        {
            tempPicture = new Bitmap(Properties.Resources.wheel);
            picture = new Bitmap(Properties.Resources.wheel);
            wheelValues = new int[] { 425, 225, 375, -1, 25, 275, 400, 325, 100, 0, 200, 50, 350, 3000, 175, 475, 300, 125, 75, 500 };
            val = 0.0f;

        }
    }

    class player
    {
        public String playerName;
        public int playerScore;
        public bool wordGuessed;

        public player(string i)
        {
            playerName = i;
            playerScore = 0;
            wordGuessed = false;

        }
    }

    class Game
    {
        public int setup;
        public bool endGame;
        public string[] guessFeedback;
        public int guessWord;
        public int scorePossible;

        public Game()
        {
            setup = 1;
            endGame = false;
            scorePossible = 0;
            guessWord = 0;
            guessFeedback = new string[]
            {
                "Click the Wheel to Spin",
                "Buy a vowel or spin the wheel.",
                "Play for"+scorePossible,
                "Oh no, you're Bankrupt!",
                "This letter is not in the word."
            };
        }

        public void checkGame()
        {

        }

    }

    class Class1
    {
    }
}
