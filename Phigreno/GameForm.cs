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
using RGEngine.Key;
using System.Threading;

namespace Phigreno
{
    public partial class GameForm : Form
    {
        Sound sound = new Sound();
        KeyCheck key = new KeyCheck();
        Render render = new Render();
        Thread NDown;
        bool renderPressed = false;
        public GameForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            sound.SoundLoad(".\\sound\\Homebound.mp3", musicpro, this);
            sound.SoundPlay();
            key.Init(render, pdsingle, panding);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            render.Init(this, @".\res\note.png", pdcircle, 64, 25);
            render.RenderNote();
            key.Init(render, pdsingle, panding);
            if (renderPressed)
            {
                NDown = new Thread(render.NoteDown);
                NDown.Start();
            }
            else
            {
                renderPressed = true;
                NDown = new Thread(render.NoteDown);
                NDown.Start();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (renderPressed)
            {
                key.User_PressAnyKeyEvent();
            }
        }
    }
}
