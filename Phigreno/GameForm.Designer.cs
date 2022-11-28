namespace Phigreno
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pdline = new System.Windows.Forms.PictureBox();
            this.GmInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.musicpro = new System.Windows.Forms.ProgressBar();
            this.pdcircle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pdline)).BeginInit();
            this.SuspendLayout();
            // 
            // pdline
            // 
            this.pdline.Image = ((System.Drawing.Image)(resources.GetObject("pdline.Image")));
            this.pdline.Location = new System.Drawing.Point(426, 11);
            this.pdline.Name = "pdline";
            this.pdline.Size = new System.Drawing.Size(346, 492);
            this.pdline.TabIndex = 0;
            this.pdline.TabStop = false;
            // 
            // GmInfo
            // 
            this.GmInfo.AutoSize = true;
            this.GmInfo.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GmInfo.Location = new System.Drawing.Point(12, 123);
            this.GmInfo.Name = "GmInfo";
            this.GmInfo.Size = new System.Drawing.Size(315, 140);
            this.GmInfo.TabIndex = 1;
            this.GmInfo.Text = "玩家名：X_huihui\r\n曲名：？\r\n难度：114514\r\n歌曲进度：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("得意黑", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musicpro
            // 
            this.musicpro.Location = new System.Drawing.Point(18, 289);
            this.musicpro.Name = "musicpro";
            this.musicpro.Size = new System.Drawing.Size(386, 24);
            this.musicpro.TabIndex = 3;
            // 
            // pdcircle
            // 
            this.pdcircle.Location = new System.Drawing.Point(436, 22);
            this.pdcircle.Name = "pdcircle";
            this.pdcircle.Size = new System.Drawing.Size(323, 383);
            this.pdcircle.TabIndex = 4;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.pdcircle);
            this.Controls.Add(this.musicpro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GmInfo);
            this.Controls.Add(this.pdline);
            this.Font = new System.Drawing.Font("得意黑", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "GameForm";
            this.Text = "Phigreno";
            ((System.ComponentModel.ISupportInitialize)(this.pdline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pdline;
        private System.Windows.Forms.Label GmInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar musicpro;
        private System.Windows.Forms.Panel pdcircle;
    }
}