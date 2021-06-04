
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Searcher = new System.Windows.Forms.ComboBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Example = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_meanCN = new System.Windows.Forms.Label();
            this.button_Voice = new System.Windows.Forms.Button();
            this.label_Word = new System.Windows.Forms.Label();
            this.label_meanEN = new System.Windows.Forms.Label();
            this.label_else = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Searcher
            // 
            this.comboBox_Searcher.FormattingEnabled = true;
            this.comboBox_Searcher.ItemHeight = 15;
            this.comboBox_Searcher.Location = new System.Drawing.Point(212, 61);
            this.comboBox_Searcher.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Searcher.Name = "comboBox_Searcher";
            this.comboBox_Searcher.Size = new System.Drawing.Size(257, 23);
            this.comboBox_Searcher.TabIndex = 0;
            this.comboBox_Searcher.SelectedIndexChanged += new System.EventHandler(this.comboBox_Searcher_SelectedIndexChanged);
            this.comboBox_Searcher.TextUpdate += new System.EventHandler(this.comboBox_Searcher_TextUpdate);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(132, 65);
            this.label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(52, 15);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "查询：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox1.Controls.Add(this.label_else);
            this.groupBox1.Controls.Add(this.label_meanEN);
            this.groupBox1.Controls.Add(this.label_Example);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.label_meanCN);
            this.groupBox1.Controls.Add(this.button_Voice);
            this.groupBox1.Controls.Add(this.label_Word);
            this.groupBox1.Location = new System.Drawing.Point(13, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(793, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label_Example
            // 
            this.label_Example.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Example.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Example.Location = new System.Drawing.Point(285, 192);
            this.label_Example.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Example.Name = "label_Example";
            this.label_Example.Size = new System.Drawing.Size(508, 60);
            this.label_Example.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.Location = new System.Drawing.Point(47, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(167, 132);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // label_meanCN
            // 
            this.label_meanCN.Font = new System.Drawing.Font("宋体", 12F);
            this.label_meanCN.Location = new System.Drawing.Point(285, 75);
            this.label_meanCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_meanCN.Name = "label_meanCN";
            this.label_meanCN.Size = new System.Drawing.Size(500, 40);
            this.label_meanCN.TabIndex = 6;
            this.label_meanCN.Click += new System.EventHandler(this.label_meanCN_Click);
            // 
            // button_Voice
            // 
            this.button_Voice.Location = new System.Drawing.Point(670, 26);
            this.button_Voice.Margin = new System.Windows.Forms.Padding(4);
            this.button_Voice.Name = "button_Voice";
            this.button_Voice.Size = new System.Drawing.Size(74, 29);
            this.button_Voice.TabIndex = 5;
            this.button_Voice.Text = "播音";
            this.button_Voice.UseVisualStyleBackColor = true;
            this.button_Voice.Click += new System.EventHandler(this.button_Voice_Click);
            // 
            // label_Word
            // 
            this.label_Word.Font = new System.Drawing.Font("宋体", 30F);
            this.label_Word.Location = new System.Drawing.Point(242, 14);
            this.label_Word.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(420, 61);
            this.label_Word.TabIndex = 1;
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_meanEN
            // 
            this.label_meanEN.Font = new System.Drawing.Font("宋体", 12F);
            this.label_meanEN.Location = new System.Drawing.Point(285, 115);
            this.label_meanEN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_meanEN.Name = "label_meanEN";
            this.label_meanEN.Size = new System.Drawing.Size(500, 60);
            this.label_meanEN.TabIndex = 9;
            this.label_meanEN.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_else
            // 
            this.label_else.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_else.Font = new System.Drawing.Font("宋体", 12F);
            this.label_else.Location = new System.Drawing.Point(289, 264);
            this.label_else.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_else.Name = "label_else";
            this.label_else.Size = new System.Drawing.Size(496, 60);
            this.label_else.TabIndex = 10;
            this.label_else.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(710, 308);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.comboBox_Searcher);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.Label label_meanCN;
        private System.Windows.Forms.Label label_Example;
        private System.Windows.Forms.Label label_meanEN;
        private System.Windows.Forms.Label label_else;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

