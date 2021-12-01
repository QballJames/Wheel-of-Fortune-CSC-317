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
        player player1;
        Game game;


        public Form2()
        {
            rand = new Random();
            easyInt = rand.Next(0, hiddenWord.Length);
            fortuneWheel = new Wheel();
            words = new word(hiddenWord[easyInt]);
            txtBox = new txtBox[words.size];
            player1 = new player("Player");
            wheelMoved = false;
            wheelTime = 100;
            InitializeComponent();
            createWord();
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += wheelTimer_Tick;

            letterBtn = new Button[26];
            wordBtn = new Button[9];

            letterBtn[0] = button1;
            letterBtn[1] = button2;
            letterBtn[2] = button3;
            letterBtn[3] = button4;
            letterBtn[4] = button5;
            letterBtn[5] = button6;
            letterBtn[6] = button7;
            letterBtn[7] = button8;
            letterBtn[8] = button9;
            letterBtn[9] = button10;
            letterBtn[10] = button11;
            letterBtn[11] = button12;
            letterBtn[12] = button13;
            letterBtn[13] = button14;
            letterBtn[14] = button15;
            letterBtn[15] = button16;
            letterBtn[16] = button17;
            letterBtn[17] = button18;
            letterBtn[18] = button19;
            letterBtn[19] = button20;
            letterBtn[20] = button21;
            letterBtn[21] = button22;
            letterBtn[22] = button23;
            letterBtn[23] = button24;
            letterBtn[24] = button25;
            letterBtn[25] = button26;

            wordBtn[0] = button1;
            wordBtn[1] = button2;
            wordBtn[2] = button3;
            wordBtn[3] = button4;
            wordBtn[4] = button5;
            wordBtn[5] = button6;
            wordBtn[6] = button7;
            wordBtn[7] = button8;
            wordBtn[8] = button9;

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
            lblFeedback = player.guessFeedback[0];

            gameTime.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void buttonHandle(object sender, EventArgs e)
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
        }

        public Bitmap imageRotator()
        {
            Bitmap rotatedImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((pictureBox1.Width / 2), pictureBox1.Height / 2);
                g.RotateTransform(fortuneWheel.spin);
                g.TranslateTransform(-pictureBox1.Width / 2, -pictureBox1.Height / 2);
                g.DrawImage(fortuneWheel.tempPicture, new Point(0, 0));
            }
        }

        public static Bitmap imageRotator()
        {
            return imageRotator(Image, new PointF((float)image.Width / 2, (float)Image.Height / 2), angle);
        }

        public static Bitmap imageRotator(Image image, PointF offset, float angle)
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


        }

        public void createWord()
        {
            for (int i = 0; i < txtBox.Length; i++)
            {
                this.Controls.Add(words.txtBox[i]);
            }
        }
    }
}
