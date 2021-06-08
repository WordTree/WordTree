
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
            this.search_switchbutton = new System.Windows.Forms.Button();
            this.read_switchbutton = new System.Windows.Forms.Button();
            this.word_axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.plan_switchbutton = new System.Windows.Forms.Button();
            this.memory_swtichbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.word_axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Paragraph_richTextBox
            // 
            this.Paragraph_richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.Paragraph_richTextBox.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paragraph_richTextBox.Location = new System.Drawing.Point(-1, 0);
            this.Paragraph_richTextBox.Name = "Paragraph_richTextBox";
            this.Paragraph_richTextBox.Size = new System.Drawing.Size(691, 410);
            this.Paragraph_richTextBox.TabIndex = 0;
            this.Paragraph_richTextBox.Text = "";
            this.Paragraph_richTextBox.Click += new System.EventHandler(this.Paragraph_richTextBox_Click);
            this.Paragraph_richTextBox.TextChanged += new System.EventHandler(this.Paragraph_richTextBox_TextChanged);
            // 
            // Info_richTextBox
            // 
            this.Info_richTextBox.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_richTextBox.Location = new System.Drawing.Point(696, 0);
            this.Info_richTextBox.Name = "Info_richTextBox";
            this.Info_richTextBox.Size = new System.Drawing.Size(100, 410);
            this.Info_richTextBox.TabIndex = 1;
            this.Info_richTextBox.Text = "";
            // 
            // search_switchbutton
            // 
            this.search_switchbutton.Location = new System.Drawing.Point(438, 415);
            this.search_switchbutton.Name = "search_switchbutton";
            this.search_switchbutton.Size = new System.Drawing.Size(75, 23);
            this.search_switchbutton.TabIndex = 2;
            this.search_switchbutton.Text = "查词";
            this.search_switchbutton.UseVisualStyleBackColor = true;
            this.search_switchbutton.Click += new System.EventHandler(this.test_button_Click);
            // 
            // read_switchbutton
            // 
            this.read_switchbutton.Location = new System.Drawing.Point(597, 416);
            this.read_switchbutton.Name = "read_switchbutton";
            this.read_switchbutton.Size = new System.Drawing.Size(75, 23);
            this.read_switchbutton.TabIndex = 3;
            this.read_switchbutton.Text = "阅读";
            this.read_switchbutton.UseVisualStyleBackColor = true;
            this.read_switchbutton.Click += new System.EventHandler(this.testbutton2_Click);
            // 
            // word_axWindowsMediaPlayer
            // 
            this.word_axWindowsMediaPlayer.Enabled = true;
            this.word_axWindowsMediaPlayer.Location = new System.Drawing.Point(615, 0);
            this.word_axWindowsMediaPlayer.Name = "word_axWindowsMediaPlayer";
            this.word_axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("word_axWindowsMediaPlayer.OcxState")));
            this.word_axWindowsMediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.word_axWindowsMediaPlayer.TabIndex = 4;
            this.word_axWindowsMediaPlayer.Visible = false;
            // 
            // plan_switchbutton
            // 
            this.plan_switchbutton.Location = new System.Drawing.Point(262, 416);
            this.plan_switchbutton.Name = "plan_switchbutton";
            this.plan_switchbutton.Size = new System.Drawing.Size(75, 23);
            this.plan_switchbutton.TabIndex = 6;
            this.plan_switchbutton.Text = "计划";
            this.plan_switchbutton.UseVisualStyleBackColor = true;
            // 
            // memory_swtichbutton
            // 
            this.memory_swtichbutton.Location = new System.Drawing.Point(100, 416);
            this.memory_swtichbutton.Name = "memory_swtichbutton";
            this.memory_swtichbutton.Size = new System.Drawing.Size(75, 23);
            this.memory_swtichbutton.TabIndex = 7;
            this.memory_swtichbutton.Text = "记忆";
            this.memory_swtichbutton.UseVisualStyleBackColor = true;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memory_swtichbutton);
            this.Controls.Add(this.plan_switchbutton);
            this.Controls.Add(this.word_axWindowsMediaPlayer);
            this.Controls.Add(this.read_switchbutton);
            this.Controls.Add(this.search_switchbutton);
            this.Controls.Add(this.Info_richTextBox);
            this.Controls.Add(this.Paragraph_richTextBox);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.Button search_switchbutton;
        private System.Windows.Forms.Button read_switchbutton;
        private AxWMPLib.AxWindowsMediaPlayer word_axWindowsMediaPlayer;
        private System.Windows.Forms.Button plan_switchbutton;
        private System.Windows.Forms.Button memory_swtichbutton;
    }
}

