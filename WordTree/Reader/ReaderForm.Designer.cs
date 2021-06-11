
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
            this.Info_richTextBox = new System.Windows.Forms.RichTextBox();
            this.read_switchbutton = new System.Windows.Forms.Button();
            this.word_axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.word_axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Paragraph_richTextBox
            // 
            this.Paragraph_richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.Paragraph_richTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Paragraph_richTextBox.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paragraph_richTextBox.Location = new System.Drawing.Point(0, 0);
            this.Paragraph_richTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Paragraph_richTextBox.Name = "Paragraph_richTextBox";
            this.Paragraph_richTextBox.Size = new System.Drawing.Size(653, 597);
            this.Paragraph_richTextBox.TabIndex = 0;
            this.Paragraph_richTextBox.Text = "";
            this.Paragraph_richTextBox.Click += new System.EventHandler(this.Paragraph_richTextBox_Click);
            this.Paragraph_richTextBox.TextChanged += new System.EventHandler(this.Paragraph_richTextBox_TextChanged);
            // 
            // Info_richTextBox
            // 
            this.Info_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_richTextBox.Location = new System.Drawing.Point(694, 11);
            this.Info_richTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Info_richTextBox.Name = "Info_richTextBox";
            this.Info_richTextBox.Size = new System.Drawing.Size(76, 553);
            this.Info_richTextBox.TabIndex = 1;
            this.Info_richTextBox.Text = "";
            // 
            // read_switchbutton
            // 
            this.read_switchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.read_switchbutton.Location = new System.Drawing.Point(694, 568);
            this.read_switchbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.read_switchbutton.Name = "read_switchbutton";
            this.read_switchbutton.Size = new System.Drawing.Size(77, 29);
            this.read_switchbutton.TabIndex = 3;
            this.read_switchbutton.Text = "阅读";
            this.read_switchbutton.UseVisualStyleBackColor = true;
            this.read_switchbutton.Click += new System.EventHandler(this.testbutton2_Click);
            // 
            // word_axWindowsMediaPlayer
            // 
            this.word_axWindowsMediaPlayer.Enabled = true;
            this.word_axWindowsMediaPlayer.Location = new System.Drawing.Point(615, 0);
            this.word_axWindowsMediaPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.word_axWindowsMediaPlayer.Name = "word_axWindowsMediaPlayer";
            this.word_axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("word_axWindowsMediaPlayer.OcxState")));
            this.word_axWindowsMediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.word_axWindowsMediaPlayer.TabIndex = 4;
            this.word_axWindowsMediaPlayer.Visible = false;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 597);
            this.Controls.Add(this.word_axWindowsMediaPlayer);
            this.Controls.Add(this.read_switchbutton);
            this.Controls.Add(this.Info_richTextBox);
            this.Controls.Add(this.Paragraph_richTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReaderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.Shown += new System.EventHandler(this.ReaderForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.word_axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Paragraph_richTextBox;
        private System.Windows.Forms.RichTextBox Info_richTextBox;
        private System.Windows.Forms.Button read_switchbutton;
        private AxWMPLib.AxWindowsMediaPlayer word_axWindowsMediaPlayer;
    }
}

