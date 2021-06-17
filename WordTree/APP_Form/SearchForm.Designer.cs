
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
            this.SuspendLayout();
            // 
            // comboBox_Searcher
            // 
            this.comboBox_Searcher.FormattingEnabled = true;
            this.comboBox_Searcher.ItemHeight = 15;
            this.comboBox_Searcher.Location = new System.Drawing.Point(215, 28);
            this.comboBox_Searcher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Searcher.Name = "comboBox_Searcher";
            this.comboBox_Searcher.Size = new System.Drawing.Size(257, 23);
            this.comboBox_Searcher.TabIndex = 0;
            this.comboBox_Searcher.SelectedIndexChanged += new System.EventHandler(this.comboBox_Searcher_SelectedIndexChanged);
            this.comboBox_Searcher.TextUpdate += new System.EventHandler(this.comboBox_Searcher_TextUpdate);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Search.Location = new System.Drawing.Point(139, 31);
            this.label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(52, 15);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "查询：";
            // 
            // pnl_wordInfo
            // 
            this.pnl_wordInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_wordInfo.Location = new System.Drawing.Point(0, 72);
            this.pnl_wordInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_wordInfo.Name = "pnl_wordInfo";
            this.pnl_wordInfo.Size = new System.Drawing.Size(825, 416);
            this.pnl_wordInfo.TabIndex = 2;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(825, 489);
            this.Controls.Add(this.pnl_wordInfo);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.comboBox_Searcher);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Searcher;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Panel pnl_wordInfo;
    }
}

