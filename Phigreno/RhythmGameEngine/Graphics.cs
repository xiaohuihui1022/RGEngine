using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace RGEngine.Graphics
{
    /// <summary>
    /// 主窗口渲染层面
    /// </summary>
    public class Render
    {
        // note的picturebox
        PictureBox noteBox = new PictureBox();

        // note的文件名
        string noteFileName;

        // 用来渲染note的form
        public Panel pdpanel;

        // note图片的宽度
        int noteWidth;

        // note图片的高度
        int noteHeight;

        /// <summary>
        /// 初始化函数
        /// </summary>
        /// <param name="formToRender">要渲染note的窗口</param>
        /// <param name="noteFile">note文件名</param>
        /// <param name="pandingline">判定窗的picturebox</param>
        /// <param name="w">Weight（note图片的宽度）</param>
        /// <param name="h">Height（note图片的高度）</param>
        public void Init(Form formToRender, string noteFile,
            Panel pandingline, int w, int h)
        {
            noteFileName = noteFile;
            pdpanel = pandingline;
            noteWidth = w;
            noteHeight = h;
        }

        public void RenderNote()
        {
            noteBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = noteWidth,
                Height = noteHeight,
                Image = Image.FromFile(noteFileName),
                Location = RandomPoint()
            };
            // 在panel上渲染notebox
            pdpanel.Controls.Add(noteBox);
            // 将notebox前置
            noteBox.BringToFront();
            
        }

        // 内部类
        private Point RandomPoint()
        {
            Random r = new Random();
            int rx = r.Next(0, pdpanel.Width - noteBox.Width);
            return new Point(rx, 3);
        }

        /// <summary>
        /// 让note下降（如果Panel内没有note会报错，建议用Thread）
        /// </summary>
        public void NoteDown()
        {
            while (true)
            {
                foreach (Control c in pdpanel.Controls)
                {
                    PictureBox pb = (PictureBox)c;
                    if (pb.SizeMode == PictureBoxSizeMode.StretchImage)
                    {
                        pb.Location = new Point(pb.Location.X, pb.Location.Y + 3);
                        Thread.Sleep(50);
                    }
                }
            }
            
        }
    }
}
