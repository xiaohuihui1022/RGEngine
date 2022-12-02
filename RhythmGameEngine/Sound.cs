using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RGEngine.Dev;

namespace RGEngine.Sound
{
    public class RGSound
    {
        NAPlayer auplayer = new NAPlayer();

        /// <summary>
        /// 加载音频（全格式支持）
        /// </summary>
        /// <param name="FileName">文件名</param>
        /// <param name="progress">进度条显示</param>
        /// <param name="form">窗口句柄</param>
        public void SoundLoad(string FileName, ProgressBar progress, Form form)
        {
            auplayer.OpenFile(FileName, progress, form);
        }

        /// <summary>
        /// 播放音乐
        /// </summary>
        public void SoundPlay()
        {
            auplayer.PlaySound();
        }

        /// <summary>
        /// 暂停音乐（再次播放会从当前进度开始）
        /// </summary>
        public void SoundPause()
        {
            auplayer.PauseSound();
        }

        /// <summary>
        /// 终止音乐（再次播放就会从头开始）
        /// </summary>
        public void SoundStop()
        {
            auplayer.StopSound();
        }

        /// <summary>
        /// 释放音乐（需重新Load）
        /// </summary>
        public void SoundDispose()
        {
            auplayer.DisposeAll();
        }

        /// <summary>
        /// 获取sound进度
        /// </summary>
        /// <returns>进度(double)</returns>
        public double GetSoundProgress()
        {
            return 0.0;
        }
    }
}
