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
        player player;
        Game game1;


        public Form2()
        {
            rand = new Random();
            easyInt = rand.Next(0, hiddenWord.Length);
            fortuneWheel = new Wheel();
            words = new word(hiddenWord[easyInt]);
            txtBox = new txtBox[words.size];
            game1 = new Game("Player");
            wheelMoved = false;
            wheelTime = 100;
            InitializeComponent();
            
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
    }
}
