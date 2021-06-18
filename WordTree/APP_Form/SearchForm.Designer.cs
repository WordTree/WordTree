
namespace APP_Form
{
    partial class SearchForm
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
            this.comboBox_Searcher = new System.Windows.Forms.ComboBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.pnl_wordInfo = new System.Windows.Forms.Panel();
            this.panel_sentence = new System.Windows.Forms.Panel();
            this.label_everyday = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.label_content = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_wordInfo.SuspendLayout();
            this.panel_sentence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Searcher
            // 
            this.comboBox_Searcher.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Searcher.FormattingEnabled = true;
            this.comboBox_Searcher.ItemHeight = 25;
            this.comboBox_Searcher.Location = new System.Drawing.Point(210, 20);
            this.comboBox_Searcher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Searcher.Name = "comboBox_Searcher";
            this.comboBox_Searcher.Size = new System.Drawing.Size(216, 33);
            this.comboBox_Searcher.TabIndex = 0;
            this.comboBox_Searcher.SelectedIndexChanged += new System.EventHandler(this.comboBox_Searcher_SelectedIndexChanged);
            this.comboBox_Searcher.TextUpdate += new System.EventHandler(this.comboBox_Searcher_TextUpdate);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Search.Location = new System.Drawing.Point(141, 34);
            this.label_Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(41, 12);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "查询：";
            // 
            // pnl_wordInfo
            // 
            this.pnl_wordInfo.Controls.Add(this.panel_sentence);
            this.pnl_wordInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_wordInfo.Location = new System.Drawing.Point(0, 109);
            this.pnl_wordInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_wordInfo.Name = "pnl_wordInfo";
            this.pnl_wordInfo.Size = new System.Drawing.Size(609, 318);
            this.pnl_wordInfo.TabIndex = 2;
            // 
            // panel_sentence
            // 
            this.panel_sentence.BackColor = System.Drawing.Color.Transparent;
            this.panel_sentence.Controls.Add(this.label_everyday);
            this.panel_sentence.Controls.Add(this.label_note);
            this.panel_sentence.Controls.Add(this.label_content);
            this.panel_sentence.Controls.Add(this.pictureBox1);
            this.panel_sentence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sentence.Location = new System.Drawing.Point(0, 0);
            this.panel_sentence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_sentence.Name = "panel_sentence";
            this.panel_sentence.Size = new System.Drawing.Size(609, 318);
            this.panel_sentence.TabIndex = 0;
            // 
            // label_everyday
            // 
            this.label_everyday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_everyday.Location = new System.Drawing.Point(2, 0);
            this.label_everyday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_everyday.Name = "label_everyday";
            this.label_everyday.Size = new System.Drawing.Size(75, 23);
            this.label_everyday.TabIndex = 3;
            this.label_everyday.Text = "每日一句";
            this.label_everyday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_note
            // 
            this.label_note.BackColor = System.Drawing.Color.Transparent;
            this.label_note.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_note.Location = new System.Drawing.Point(3, 68);
            this.label_note.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(606, 58);
            this.label_note.TabIndex = 2;
            this.label_note.Text = "label2";
            // 
            // label_content
            // 
            this.label_content.BackColor = System.Drawing.Color.Transparent;
            this.label_content.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_content.Location = new System.Drawing.Point(1, 23);
            this.label_content.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(603, 51);
            this.label_content.TabIndex = 1;
            this.label_content.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 427);
            this.Controls.Add(this.pnl_wordInfo);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.comboBox_Searcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.pnl_wordInfo.ResumeLayout(false);
            this.panel_sentence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Searcher;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Panel pnl_wordInfo;
        private System.Windows.Forms.Panel panel_sentence;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label_content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_everyday;
    }
}

