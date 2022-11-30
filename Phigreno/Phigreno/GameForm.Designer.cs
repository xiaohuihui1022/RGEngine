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
            this.pdsingle = new System.Windows.Forms.PictureBox();
            this.panding = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pdline)).BeginInit();
            this.pdcircle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdsingle)).BeginInit();
            this.SuspendLayout();
            // 
            // pdline
            // 
            this.pdline.Image = ((System.Drawing.Image)(resources.GetObject("pdline.Image")));
            this.pdline.Location = new System.Drawing.Point(422, 11);
            this.pdline.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pdline.Name = "pdline";
            this.pdline.Size = new System.Drawing.Size(349, 494);
            this.pdline.TabIndex = 0;
            this.pdline.TabStop = false;
            // 
            // GmInfo
            // 
            this.GmInfo.AutoSize = true;
            this.GmInfo.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GmInfo.Location = new System.Drawing.Point(14, 98);
            this.GmInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GmInfo.Name = "GmInfo";
            this.GmInfo.Size = new System.Drawing.Size(315, 140);
            this.GmInfo.TabIndex = 1;
            this.GmInfo.Text = "玩家名：X_huihui\r\n曲名：HomeBound\r\n难度：114514\r\n歌曲进度：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(14, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musicpro
            // 
            this.musicpro.Location = new System.Drawing.Point(20, 281);
            this.musicpro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.musicpro.Name = "musicpro";
            this.musicpro.Size = new System.Drawing.Size(369, 29);
            this.musicpro.TabIndex = 3;
            // 
            // pdcircle
            // 
            this.pdcircle.BackColor = System.Drawing.Color.Transparent;
            this.pdcircle.Controls.Add(this.pdsingle);
            this.pdcircle.ForeColor = System.Drawing.Color.Transparent;
            this.pdcircle.Location = new System.Drawing.Point(432, 24);
            this.pdcircle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pdcircle.Name = "pdcircle";
            this.pdcircle.Size = new System.Drawing.Size(326, 419);
            this.pdcircle.TabIndex = 4;
            // 
            // pdsingle
            // 
            this.pdsingle.BackColor = System.Drawing.Color.Aqua;
            this.pdsingle.Image = ((System.Drawing.Image)(resources.GetObject("pdsingle.Image")));
            this.pdsingle.Location = new System.Drawing.Point(-11, 360);
            this.pdsingle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pdsingle.Name = "pdsingle";
            this.pdsingle.Size = new System.Drawing.Size(349, 47);
            this.pdsingle.TabIndex = 5;
            this.pdsingle.TabStop = false;
            // 
            // panding
            // 
            this.panding.AutoSize = true;
            this.panding.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panding.Location = new System.Drawing.Point(314, 33);
            this.panding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panding.Name = "panding";
            this.panding.Size = new System.Drawing.Size(0, 22);
            this.panding.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 76);
            this.button2.TabIndex = 7;
            this.button2.Text = "判定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panding);
            this.Controls.Add(this.pdcircle);
            this.Controls.Add(this.musicpro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GmInfo);
            this.Controls.Add(this.pdline);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GameForm";
            this.Text = "Phigreno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pdline)).EndInit();
            this.pdcircle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdsingle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pdline;
        private System.Windows.Forms.Label GmInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar musicpro;
        private System.Windows.Forms.Panel pdcircle;
        private System.Windows.Forms.PictureBox pdsingle;
        private System.Windows.Forms.Label panding;
        private System.Windows.Forms.Button button2;
    }
}