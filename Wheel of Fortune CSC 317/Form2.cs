using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel_of_Fortune_CSC_317
{
    public partial class Form2 : Form
    {
        word words;
        txtBox[] txtBox;
        Wheel fortuneWheel;
        bool wheelMoved;
        float startWheel;
        float wheelTime;
        Timer gameTime;
        Timer wheelTimer;
        String[] hiddenWord =
        {
            "ABHORRENT",
            "LIFEHACKS",
            "RECOGNIZE",
            "REFLEXIVE",
            "TECHNIQUE"
        };
        Random rand;
        int easyInt;
        Button[] letterBtn;
        Button[] wordBtn;
        Button[] compBtn;
        PlayerClass player1;
        PlayerClass player2;
        PlayerClass player3;

        Game game;


        public Form2()
        {
            rand = new Random();
            easyInt = rand.Next(0, hiddenWord.Length);
            fortuneWheel = new Wheel();
            words = new word(hiddenWord[easyInt]);
            txtBox = new txtBox[words.size];
            wheelMoved = false;
            wheelTime = 100;
            InitializeComponent();
            createWord();
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += wheelTimer_Tick;

            letterBtn = new Button[26];
            wordBtn = new Button[9];
            compBtn = new Button[26];


            letterBtn[0] = LetterAbutton; 
            letterBtn[1] = LetterBbutton;
            letterBtn[2] = LetterCbutton;
            letterBtn[3] = LetterDbutton;
            letterBtn[4] = LetterEbutton;
            letterBtn[5] = LetterFbutton;
            letterBtn[6] = LetterGbutton;
            letterBtn[7] = LetterHbutton;
            letterBtn[8] = LetterIbutton;
            letterBtn[9] = LetterJbutton;
            letterBtn[10] = LetterKbutton;
            letterBtn[11] = LetterLbutton;
            letterBtn[12] = LetterMbutton;
            letterBtn[13] = LetterNbutton;
            letterBtn[14] = LetterObutton;
            letterBtn[15] = LetterPbutton;
            letterBtn[16] = LetterQbutton;
            letterBtn[17] = LetterRbutton;
            letterBtn[18] = LetterSbutton;
            letterBtn[19] = LetterTbutton;
            letterBtn[20] = LetterUbutton;
            letterBtn[21] = LetterVbutton;
            letterBtn[22] = LetterWbutton;
            letterBtn[23] = LetterXbutton;
            letterBtn[24] = LetterYbutton;
            letterBtn[25] = LetterZbutton;

            wordBtn[0] = LetterAbutton;
            wordBtn[1] = LetterBbutton;
            wordBtn[2] = LetterCbutton;
            wordBtn[3] = LetterDbutton;
            wordBtn[4] = LetterEbutton;
            wordBtn[5] = LetterFbutton;
            wordBtn[6] = LetterGbutton;
            wordBtn[7] = LetterHbutton;
            wordBtn[8] = LetterIbutton;

            compBtn[0] = LetterAbutton;
            compBtn[1] = LetterBbutton;
            compBtn[2] = LetterCbutton;
            compBtn[3] = LetterDbutton;
            compBtn[4] = LetterEbutton;
            compBtn[5] = LetterFbutton;
            compBtn[6] = LetterGbutton;
            compBtn[7] = LetterHbutton;
            compBtn[8] = LetterIbutton;
            compBtn[9] = LetterJbutton;
            compBtn[10] = LetterKbutton;
            compBtn[11] = LetterLbutton;
            compBtn[12] = LetterMbutton;
            compBtn[13] = LetterNbutton;
            compBtn[14] = LetterObutton;
            compBtn[15] = LetterPbutton;
            compBtn[16] = LetterQbutton;
            compBtn[17] = LetterRbutton;
            compBtn[18] = LetterSbutton;
            compBtn[19] = LetterTbutton;
            compBtn[20] = LetterUbutton;
            compBtn[21] = LetterVbutton;
            compBtn[22] = LetterWbutton;
            compBtn[23] = LetterXbutton;
            compBtn[24] = LetterYbutton;
            compBtn[25] = LetterZbutton;

            for (int i = 0; i < 25; i++)
            {
                letterBtn[i].IsAccessible = true;
                letterBtn[i].Enabled = true;
                letterBtn[i].Visible = false;
            }

            game = new Game();

            gameTime = new Timer();
            gameTime.Interval = 100;
            gameTime.Tick += gameTime_Tick;
            lblFeedback.Text = game.guessFeedback[0];

            gameTime.Start();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            player1 = PlayerForm.player1;
            player2 = PlayerForm.player2;
            player3 = PlayerForm.player3;
            Player1lbl.Text = $" {PlayerForm.player1.playerName} points: ";
            Player2lbl.Text = $" {PlayerForm.player2.playerName} points: ";
            Player3lbl.Text = $" {PlayerForm.player3.playerName} points: ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       /* private void buttonHandle(object sender, EventArgs e)
        {
            Boolean ifExist = false;
            Button btnObj = (Button)sender;

            for (int i = 0; i < words.size; i++)
            {
                if ((words.txtBox[i].Text).Equals(btnObj.Text))
                {
                    words.txtBox[i].UseSystemPasswordChar = false;
                    btnObj.IsAccessible = false;

                    if (btnObj.Text.Equals("A")
                        || btnObj.Text.Equals("E")
                        || btnObj.Text.Equals("I")
                        || btnObj.Text.Equals("O")
                        || btnObj.Text.Equals("U")
                        || btnObj.Text.Equals("Y"))
                    {
                        player1.playerScore -= 300;
                        lblP1Points.Text = Convert.ToString(player1.playerScore);
                    }
                    else
                    {
                        game.guessWord += 1;
                        player1.playerScore += game.scorePossible;
                        lblP1Points.Text = Convert.ToString(player1.playerScore);
                        game.setup = 3;
                    }

                    ifExist = true;
                    words.lettersGuessed++;
                }
            }

            if (!ifExist)
            {
                lblFeedback.Text = game.guessFeedback[4];
                game.guessWord = 0;
                game.setup = 1;
            }
        }*/

       /* public Bitmap rotateImage()
        {
            Bitmap rotatedImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((pictureBox1.Width / 2), pictureBox1.Height / 2);
                g.RotateTransform(fortuneWheel.spin);
                g.TranslateTransform(-pictureBox1.Width / 2, -pictureBox1.Height / 2);
                g.DrawImage(fortuneWheel.tempPicture, new Point(0, 0));
            }
            return rotatedImage;
        }*/

        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }

        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            Graphics g = Graphics.FromImage(rotatedBmp);

            g.TranslateTransform(offset.X, offset.Y);

            g.RotateTransform(angle);

            g.TranslateTransform(-offset.X, -offset.Y);

            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void wheelTimer_Tick(object sender, EventArgs e)
        {
            lblFeedback.Visible = false;

            if(wheelMoved && wheelTime > 0)
            {
                fortuneWheel.val += wheelTime / 10;
                fortuneWheel.val = fortuneWheel.val % 360;
                RotateImage(pictureBox1, fortuneWheel.picture, fortuneWheel.val);
                wheelTime--;
            }

            fortuneWheel.spin = Convert.ToInt32(Math.Ceiling(fortuneWheel.val / 18));

            if (fortuneWheel.spin == 0)
            {
                fortuneWheel.spin = 0;
            }
            else
            {
                fortuneWheel.spin -= 1;
            }

            game.scorePossible = fortuneWheel.wheelValues[fortuneWheel.spin];
            game.guessFeedback[2] = "Score possible: " + game.scorePossible;


            if (wheelTime == 0)
            {
                wheelMoved = false;

                for (int i = 0; i < letterBtn.Length; i++)
                {
                    if (letterBtn[i].IsAccessible)
                    {
                        letterBtn[i].Visible = true;
                    }

                    if(fortuneWheel.wheelValues[fortuneWheel.spin] == 0)
                    {
                        player1.playerScore = 0;
                        game.setup = 1;
                    }
                    else
                    {
                        game.setup = 2;
                    }

                    wheelTimer.Stop();
                }
            }

        }

        private void gameTime_Tick(object sender, EventArgs e)
        {

            switch (game.setup)
            {
                case 1:
                    setup1();
                    break;
                case 2:
                    setup2();
                    break;
                case 3:
                    setup3();
                    break;
            }

            if (words.lettersGuessed > 0 && words.lettersGuessed == words.size)
            {
                player1.wordGuessed = true;
                words.lettersGuessed = 0;
            }

            if (player1.wordGuessed)
            {
                gameTime.Stop();

                if (DialogResult.OK == MessageBox.Show("You won: " + player1.playerScore + ". Do you want to play again? ", "Alert"
                              , MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
                player1.wordGuessed = false;

            }

        }


        public void setup1()
        {
            lblFeedback.Visible = true;

            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < letterBtn.Length; i++)
            {
                letterBtn[i].Visible = false;
            }

        }

        public void setup2()
        {
            lblFeedback.Visible = true;
            lblFeedback.Text = game.guessFeedback[2];
            pictureBox1.Click -= new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < wordBtn.Length; i++)
            {
                if (wordBtn[i].IsAccessible)
                {
                    wordBtn[i].Enabled = false;
                }

            }

            for (int i = 0; i < compBtn.Length; i++)
            {
                if (compBtn[i].IsAccessible)
                {
                    compBtn[i].Enabled = true;
                    compBtn[i].Visible = true;
                }
                else
                {
                    compBtn[i].Enabled = false;
                    compBtn[i].Visible = false;
                }
            }
        }

        public void setup3()
        {
            lblFeedback.Text = game.guessFeedback[1];
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < compBtn.Length; i++)
            {
                compBtn[i].Enabled = false;
            }

            if (player1.playerScore >= 300)
            {
                for (int i = 0; i < wordBtn.Length; i++) wordBtn[i].Enabled = true;
            }
            else
            {
                for (int i = 0; i < wordBtn.Length; i++) wordBtn[i].Enabled = false;
            }

            for (int i = 0; i < compBtn.Length; i++)
            {
                compBtn[i].Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wheelMoved = true;
            Random rand = new Random();
            wheelTime = rand.Next(150, 200);
            startWheel = wheelTime;

            for (int i = 0; i < letterBtn.Length; i++)
            {
                letterBtn[i].Visible = false;
            }
            wheelTimer.Start();

        }


        public void createWord()
        {
            for (int i = 0; i < txtBox.Length; i++)
            {
                this.Controls.Add(words.txtBox[i]);
            }
        }

        private void LetterAbutton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
