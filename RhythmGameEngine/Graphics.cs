using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RGEngine.Graphics
{
    /// <summary>
    /// 主窗口渲染层面
    /// </summary>
    public class Render
    {
        // note的picturebox
        PictureBox noteBox = new PictureBox();

        // 暂时没用
        Form form;

        // note的文件名
        string noteFileName;

        // 用来渲染note的form
        Panel pdline;

        // note图片的宽度
        int noteWidth;

        // note图片的高度
        int noteHeight;

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
            pdline.Controls.Add(noteBox);
            // 将notebox前置
            noteBox.BringToFront();
        }

        // 内部类
        private Point RandomPoint()
        {
            Random r = new Random();
            int rx = r.Next(0, pdline.Width - noteBox.Width);
            return new Point(rx, 3);
        }

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
            form = formToRender;
            noteFileName = noteFile;
            pdline = pandingline;
            noteWidth = w;
            noteHeight = h;
        }



    }
}
