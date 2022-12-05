using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGEngine.Sound;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace RGEngine.Graphics
{
    public class ChartLoader   
    {
        Render noteRender = new Render();
        RGSound rgsound = new RGSound();
        Thread loadChartThread;
        JObject chartRead;
        string initChartJson = "{\"time\" : []}";
        JObject chartWrite;
        string chartWriteStr = "";
        bool isFirstWrite = true;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="render">渲染器（需要已经init过的）</param>
        /// <param name="sound">播放器（需要正在播放的）</param>
        public void Init(Render render, RGSound sound)
        {
            noteRender = render;
            rgsound = sound;
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="chartFileName">谱面文件名</param>
        public void LoadChart(string chartFileName)
        {
            chartRead = JObject.Parse(File.ReadAllText(chartFileName));
            loadChartThread = new Thread(LoadChartThread);
        }

        /// <summary>
        /// 写入单个（每render一次写入一次）
        /// </summary>
        public void WriteChartJson()
        {
            double sp = rgsound.GetSoundProgress();
            if (isFirstWrite)
            {
                chartWrite = JObject.Parse(initChartJson);
                isFirstWrite = false;
            }
            if (chartWriteStr == "")
            {
                chartWriteStr = sp.ToString();
            }
            else
            {
                chartWriteStr = chartWriteStr + "," + sp.ToString();
            }
            Console.WriteLine(chartWriteStr);
            chartWrite.Remove("time");
            chartWrite.Add("time", chartWriteStr);
            /*
            JArray awa = (JArray)chartWrite["time"];
            
            var sortarray = new JArray(awa.OrderBy(z => z["time"]));
            Console.WriteLine(sortarray);*/
        }

        /// <summary>
        /// 当你的谱面创作完成时，写入全部info到一个json文件内
        /// 相当于保存谱面
        /// </summary>
        /// <param name="chartFileName"></param>
        public void WriteChartFile(string chartFileName)
        {
            if (isFirstWrite)
            {
                throw new Exception("请先render一些note再执行此函数。");
            }
            File.WriteAllText(chartFileName, 
                JsonConvert.SerializeObject(chartWrite,
                Formatting.Indented
                )
            );
            chartWrite.RemoveAll();
            isFirstWrite = true;
        }

        // 私有类线程
        private void LoadChartThread()
        {
            foreach (double nowTime in chartRead["time"])
            {
                while (true)
                {
                    if (rgsound.GetSoundProgress() == nowTime)
                    {
                        noteRender.RenderNote();
                        break;
                    }
                    Thread.Sleep(10);
                }
            }

        }
    }
}
