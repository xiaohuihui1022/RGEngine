using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RGEngine.Graphics;
using RGEngine.Sound;
using RGEngine.Dev;

namespace Phigreno
{
    public partial class GameForm : Form
    {
        Sound sound = new Sound();
        
        public GameForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NAPlayer auplayer = new NAPlayer();
            auplayer.OpenFile(".\\sound\\Homebound.mp3", musicpro, this);
            auplayer.PlayAction();
            Render render = new Render();
            render.Init(this, @".\res\note.png", pdcircle, 64, 25);
            render.RenderNote();
        }
    }
}
