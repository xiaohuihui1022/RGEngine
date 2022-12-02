using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGEngine.Sound;
using Newtonsoft.Json.Linq;

namespace RGEngine.Graphics
{
    public class ChartLoader   
    {
        Render noteRender = new Render();
        RGSound rgsound = new RGSound();
        public void Init(Render render, RGSound sound)
        {
            noteRender = render;
            rgsound = sound;
        }
        public void LoadChart(string chartFileName)
        {
            // JObject.Parse();
        }

        private void LoadChartThread()
        {
            
        }
    }
}
