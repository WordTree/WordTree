
namespace Reader
{
    partial class ReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.Paragraph_richTextBox = new System.Windows.Forms.RichTextBox();
            this.read_switchbutton = new System.Windows.Forms.Button();
            this.word_axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoPanelTitle = new HZH_Controls.Controls.UCPanelTitle();
            this.Info_richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.word_axWindowsMediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infoPanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paragraph_richTextBox
            // 
            this.Paragraph_richTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Paragraph_richTextBox.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paragraph_richTextBox.Location = new System.Drawing.Point(3, 2);
            this.Paragraph_richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Paragraph_richTextBox.Name = "Paragraph_richTextBox";
            this.Paragraph_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Paragraph_richTextBox.Size = new System.Drawing.Size(757, 752);
            this.Paragraph_richTextBox.TabIndex = 0;
            this.Paragraph_richTextBox.Text = "";
            this.Paragraph_richTextBox.Click += new System.EventHandler(this.Paragraph_richTextBox_Click);
            this.Paragraph_richTextBox.TextChanged += new System.EventHandler(this.Paragraph_richTextBox_TextChanged);
            // 
            // read_switchbutton
            // 
            this.read_switchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.read_switchbutton.BackgroundImage = global::Reader.Properties.Resources.refresh2;
            this.read_switchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.read_switchbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.read_switchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.read_switchbutton.Location = new System.Drawing.Point(880, 647);
            this.read_switchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.read_switchbutton.Name = "read_switchbutton";
            this.read_switchbutton.Size = new System.Drawing.Size(76, 69);
            this.read_switchbutton.TabIndex = 3;
            this.read_switchbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.read_switchbutton.UseVisualStyleBackColor = true;
            this.read_switchbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // word_axWindowsMediaPlayer
            // 
            this.word_axWindowsMediaPlayer.Enabled = true;
            this.word_axWindowsMediaPlayer.Location = new System.Drawing.Point(615, 0);
            this.word_axWindowsMediaPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.word_axWindowsMediaPlayer.Name = "word_axWindowsMediaPlayer";
            this.word_axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("word_axWindowsMediaPlayer.OcxState")));
            this.word_axWindowsMediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.word_axWindowsMediaPlayer.TabIndex = 4;
            this.word_axWindowsMediaPlayer.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.infoPanelTitle);
            this.panel1.Controls.Add(this.Paragraph_richTextBox);
            this.panel1.Controls.Add(this.read_switchbutton);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 756);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Page 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(777, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // infoPanelTitle
            // 
            this.infoPanelTitle.BackColor = System.Drawing.Color.Transparent;
            this.infoPanelTitle.BorderColor = System.Drawing.Color.Teal;
            this.infoPanelTitle.ConerRadius = 10;
            this.infoPanelTitle.Controls.Add(this.Info_richTextBox);
            this.infoPanelTitle.FillColor = System.Drawing.Color.White;
            this.infoPanelTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoPanelTitle.IsCanExpand = true;
            this.infoPanelTitle.IsExpand = false;
            this.infoPanelTitle.IsRadius = true;
            this.infoPanelTitle.IsShowRect = true;
            this.infoPanelTitle.Location = new System.Drawing.Point(776, 23);
            this.infoPanelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoPanelTitle.Name = "infoPanelTitle";
            this.infoPanelTitle.Padding = new System.Windows.Forms.Padding(1);
            this.infoPanelTitle.RectColor = System.Drawing.Color.Teal;
            this.infoPanelTitle.RectWidth = 1;
            this.infoPanelTitle.Size = new System.Drawing.Size(200, 434);
            this.infoPanelTitle.TabIndex = 4;
            this.infoPanelTitle.Title = "提示板";
            this.infoPanelTitle.Load += new System.EventHandler(this.infoPanelTitle_Load);
            // 
            // Info_richTextBox
            // 
            this.Info_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info_richTextBox.Location = new System.Drawing.Point(1, 1);
            this.Info_richTextBox.Name = "Info_richTextBox";
            this.Info_richTextBox.Size = new System.Drawing.Size(198, 432);
            this.Info_richTextBox.TabIndex = 1;
            this.Info_richTextBox.Text = "";
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1041, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.word_axWindowsMediaPlayer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReaderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.Shown += new System.EventHandler(this.ReaderForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.word_axWindowsMediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infoPanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Paragraph_richTextBox;
        private System.Windows.Forms.Button read_switchbutton;
        private AxWMPLib.AxWindowsMediaPlayer word_axWindowsMediaPlayer;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCPanelTitle infoPanelTitle;
        private System.Windows.Forms.RichTextBox Info_richTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

