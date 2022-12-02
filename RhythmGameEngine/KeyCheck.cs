using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RGEngine.Graphics;

namespace RGEngine.Key
{
    public class KeyCheck
    {
        Panel boxes;
        PictureBox line;
        Label plable;
        /// <summary>
        /// 初始化函数
        /// </summary>
        /// <param name="render">渲染器（需要先文档内全局newRender）然后每次新增note都需要执行一次init</param>
        /// <param name="singleLine">判定线（Panel内的）</param>
        /// <param name="pdlabel">显示判定Label</param>
        public void Init(Render render, PictureBox singleLine
            , Label pdlabel)
        {
            boxes = render.pdpanel;
            line = singleLine;
            plable = pdlabel;
        }

        /// <summary>
        /// 按下任意键就判定在线上的note消失的方法
        /// </summary>
        public void User_PressAnyKeyEvent()
        {
            foreach (Control c in boxes.Controls)
            {
                PictureBox pb = (PictureBox)c;
                if (pb.SizeMode == PictureBoxSizeMode.StretchImage)
                {
                    // 判断note是否与判定线重合
                    Rectangle pictureBox1ScreenBounds = pb.Bounds;
                    Rectangle pictureBox2ScreenBounds = line.Bounds;
                    bool intersected = pictureBox2ScreenBounds.IntersectsWith(pictureBox1ScreenBounds);
                    if (intersected)
                    {
                        plable.ForeColor = Color.Gold;
                        plable.Text = "Perfect";
                        boxes.Controls.Remove(pb);
                        continue;
                    }
                    else
                    {
                        plable.ForeColor = Color.Gray;
                        plable.Text = "Miss";
                    }
                }
            }
        }
    }
}
