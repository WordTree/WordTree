
namespace StatTracer
{
    partial class TraceForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlExt1 = new HZH_Controls.Controls.TabControlExt();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimeLine1 = new HZH_Controls.Controls.UCTimeLine();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TimeLine2 = new HZH_Controls.Controls.UCTimeLine();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TimeLine3 = new HZH_Controls.Controls.UCTimeLine();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControlExt1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControlExt1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlExt1.CloseBtnColor = System.Drawing.Color.Teal;
            this.tabControlExt1.Controls.Add(this.tabPage1);
            this.tabControlExt1.Controls.Add(this.tabPage2);
            this.tabControlExt1.Controls.Add(this.tabPage3);
            this.tabControlExt1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlExt1.HeadSelectedBackColor = System.Drawing.Color.Teal;
            this.tabControlExt1.HotTrack = true;
            this.tabControlExt1.IsShowCloseBtn = false;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(150, 50);
            this.tabControlExt1.Location = new System.Drawing.Point(0, 0);
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(800, 450);
            this.tabControlExt1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlExt1.TabIndex = 0;
            this.tabControlExt1.UncloseTabIndexs = null;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.TimeLine1);
            this.tabPage1.Font = new System.Drawing.Font("幼圆", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上周期";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TimeLine1
            // 
            this.TimeLine1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLine1.AutoScroll = true;
            this.TimeLine1.DetailsFont = new System.Drawing.Font("微软雅黑", 10F);
            this.TimeLine1.DetailsForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.TimeLine1.Items = new HZH_Controls.Controls.TimeLineItem[0];
            this.TimeLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.TimeLine1.Location = new System.Drawing.Point(3, 3);
            this.TimeLine1.Name = "TimeLine1";
            this.TimeLine1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.TimeLine1.Size = new System.Drawing.Size(541, 386);
            this.TimeLine1.TabIndex = 3;
            this.TimeLine1.TitleFont = new System.Drawing.Font("微软雅黑", 14F);
            this.TimeLine1.TitleForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.TimeLine1.Load += new System.EventHandler(this.TimeLine1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.TimeLine2);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "本周期";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TimeLine2
            // 
            this.TimeLine2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLine2.AutoScroll = true;
            this.TimeLine2.DetailsFont = new System.Drawing.Font("微软雅黑", 10F);
            this.TimeLine2.DetailsForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.TimeLine2.Items = new HZH_Controls.Controls.TimeLineItem[0];
            this.TimeLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.TimeLine2.Location = new System.Drawing.Point(0, 3);
            this.TimeLine2.Name = "TimeLine2";
            this.TimeLine2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.TimeLine2.Size = new System.Drawing.Size(541, 386);
            this.TimeLine2.TabIndex = 2;
            this.TimeLine2.TitleFont = new System.Drawing.Font("微软雅黑", 14F);
            this.TimeLine2.TitleForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TimeLine3);
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "下周期";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TimeLine3
            // 
            this.TimeLine3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLine3.AutoScroll = true;
            this.TimeLine3.DetailsFont = new System.Drawing.Font("微软雅黑", 10F);
            this.TimeLine3.DetailsForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.TimeLine3.Items = new HZH_Controls.Controls.TimeLineItem[0];
            this.TimeLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.TimeLine3.Location = new System.Drawing.Point(3, 3);
            this.TimeLine3.Name = "TimeLine3";
            this.TimeLine3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.TimeLine3.Size = new System.Drawing.Size(541, 386);
            this.TimeLine3.TabIndex = 3;
            this.TimeLine3.TitleFont = new System.Drawing.Font("微软雅黑", 14F);
            this.TimeLine3.TitleForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(607, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 164);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(627, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 164);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // TraceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlExt1);
            this.Name = "TraceForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TraceForm_Load);
            this.Shown += new System.EventHandler(this.TraceForm_Shown);
            this.tabControlExt1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public HZH_Controls.Controls.UCTimeLine TimeLine2;
        public HZH_Controls.Controls.UCTimeLine TimeLine1;
        public HZH_Controls.Controls.UCTimeLine TimeLine3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

