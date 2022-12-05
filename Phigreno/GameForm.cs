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
        RGSound sound = new RGSound();
        KeyCheck key = new KeyCheck();
        Render render = new Render();
        ChartLoader cloader = new ChartLoader();
        Thread NDown;
        bool renderPressed = false;
        public GameForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            sound.SoundLoad(".\\sound\\Homebound.mp3", musicpro, this);
            key.Init(render, pdsingle, panding);
        }


        // render
        private void button1_Click(object sender, EventArgs e)
        {
            render.Init(this, @".\res\note.png", pdcircle, 64, 25);
            render.RenderNote();
            key.Init(render, pdsingle, panding);
            cloader.Init(render, sound);
            cloader.WriteChartJson();
            cloader.WriteChartFile(@".\chart\awa.json");
            if (renderPressed)
            {
                NDown = new Thread(render.NoteDown);
                NDown.Start();
            }
            else
            {
                renderPressed = true;
                sound.SoundPlay();
                NDown = new Thread(render.NoteDown);
                NDown.Start();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        // pd
        private void button2_Click(object sender, EventArgs e)
        {
            if (renderPressed)
            {
                key.User_PressAnyKeyEvent();
            }
        }


        // load
        private void button3_Click(object sender, EventArgs e)
        {
            if (renderPressed)
            {
                MessageBox.Show("目前正处于创建谱面状态，请重启软件再点击这个按钮");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cloader.LoadChart(openFileDialog.FileName);
                sound.SoundPlay();
            }
        }
    }
}
