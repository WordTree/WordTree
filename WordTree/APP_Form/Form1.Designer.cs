
namespace APP_Form
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Voice = new System.Windows.Forms.Button();
            this.label_Word = new System.Windows.Forms.Label();
            this.label_Explination = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_Example = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Searcher
            // 
            this.comboBox_Searcher.FormattingEnabled = true;
            this.comboBox_Searcher.ItemHeight = 12;
            this.comboBox_Searcher.Location = new System.Drawing.Point(159, 49);
            this.comboBox_Searcher.Name = "comboBox_Searcher";
            this.comboBox_Searcher.Size = new System.Drawing.Size(194, 20);
            this.comboBox_Searcher.TabIndex = 0;
            this.comboBox_Searcher.TextUpdate += new System.EventHandler(this.comboBox_Searcher_TextUpdate);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(99, 52);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(41, 12);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "查询：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Example);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.label_Explination);
            this.groupBox1.Controls.Add(this.button_Voice);
            this.groupBox1.Controls.Add(this.label_Word);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_Voice
            // 
            this.button_Voice.Location = new System.Drawing.Point(393, 50);
            this.button_Voice.Name = "button_Voice";
            this.button_Voice.Size = new System.Drawing.Size(33, 23);
            this.button_Voice.TabIndex = 5;
            this.button_Voice.Text = "button1";
            this.button_Voice.UseVisualStyleBackColor = true;
            // 
            // label_Word
            // 
            this.label_Word.Font = new System.Drawing.Font("宋体", 30F);
            this.label_Word.Location = new System.Drawing.Point(188, 28);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(153, 81);
            this.label_Word.TabIndex = 1;
            this.label_Word.Text = "Apple";
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Explination
            // 
            this.label_Explination.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Explination.Location = new System.Drawing.Point(214, 122);
            this.label_Explination.Name = "label_Explination";
            this.label_Explination.Size = new System.Drawing.Size(381, 75);
            this.label_Explination.TabIndex = 6;
            this.label_Explination.Text = "n.苹果";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.Location = new System.Drawing.Point(35, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(125, 106);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // label_Example
            // 
            this.label_Example.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Example.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Example.Location = new System.Drawing.Point(214, 197);
            this.label_Example.Name = "label_Example";
            this.label_Example.Size = new System.Drawing.Size(381, 69);
            this.label_Example.TabIndex = 8;
            this.label_Example.Text = "e.g I like apple.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.comboBox_Searcher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Searcher;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Voice;
        private System.Windows.Forms.Label label_Word;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_Explination;
        private System.Windows.Forms.Label label_Example;
    }
}

