
namespace APP_Form
{
    partial class SpellingCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellingCheckForm));
            this.labelMeanCN = new System.Windows.Forms.Label();
            this.txbAnswer = new HZH_Controls.Controls.UCTextBoxEx();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnKey = new System.Windows.Forms.Button();
            this.btnAnnounce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMeanCN
            // 
            this.labelMeanCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMeanCN.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMeanCN.Location = new System.Drawing.Point(0, 0);
            this.labelMeanCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeanCN.Name = "labelMeanCN";
            this.labelMeanCN.Size = new System.Drawing.Size(817, 216);
            this.labelMeanCN.TabIndex = 0;
            this.labelMeanCN.Text = "中文释义";
            this.labelMeanCN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbAnswer
            // 
            this.txbAnswer.BackColor = System.Drawing.Color.Transparent;
            this.txbAnswer.ConerRadius = 15;
            this.txbAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAnswer.DecLength = 2;
            this.txbAnswer.FillColor = System.Drawing.Color.Gainsboro;
            this.txbAnswer.FocusBorderColor = System.Drawing.Color.Gainsboro;
            this.txbAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnswer.InputText = "";
            this.txbAnswer.InputType = HZH_Controls.TextInputType.NotControl;
            this.txbAnswer.IsFocusColor = true;
            this.txbAnswer.IsRadius = true;
            this.txbAnswer.IsShowClearBtn = false;
            this.txbAnswer.IsShowKeyboard = false;
            this.txbAnswer.IsShowRect = true;
            this.txbAnswer.IsShowSearchBtn = false;
            this.txbAnswer.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txbAnswer.Location = new System.Drawing.Point(252, 250);
            this.txbAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbAnswer.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txbAnswer.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.Padding = new System.Windows.Forms.Padding(5);
            this.txbAnswer.PasswordChar = '\0';
            this.txbAnswer.PromptColor = System.Drawing.Color.Gray;
            this.txbAnswer.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbAnswer.PromptText = "";
            this.txbAnswer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txbAnswer.RectWidth = 1;
            this.txbAnswer.RegexPattern = "";
            this.txbAnswer.Size = new System.Drawing.Size(322, 48);
            this.txbAnswer.TabIndex = 0;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(318, 445);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.mediaPlayer.TabIndex = 8;
            this.mediaPlayer.Visible = false;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.Transparent;
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCommit.FlatAppearance.BorderSize = 0;
            this.btnCommit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Location = new System.Drawing.Point(650, 9);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(14, 14);
            this.btnCommit.TabIndex = 9;
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnKey
            // 
            this.btnKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(186)))));
            this.btnKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKey.FlatAppearance.BorderSize = 0;
            this.btnKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKey.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKey.Location = new System.Drawing.Point(725, 365);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(80, 35);
            this.btnKey.TabIndex = 10;
            this.btnKey.Text = "瞄一眼";
            this.btnKey.UseVisualStyleBackColor = false;
            this.btnKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnKey_MouseDown);
            this.btnKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnKey_MouseUp);
            // 
            // btnAnnounce
            // 
            this.btnAnnounce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(186)))));
            this.btnAnnounce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnounce.FlatAppearance.BorderSize = 0;
            this.btnAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnounce.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnnounce.Location = new System.Drawing.Point(12, 365);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Size = new System.Drawing.Size(80, 35);
            this.btnAnnounce.TabIndex = 11;
            this.btnAnnounce.Text = "发音";
            this.btnAnnounce.UseVisualStyleBackColor = false;
            this.btnAnnounce.Click += new System.EventHandler(this.btnAnnounce_Click);
            // 
            // SpellingCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 468);
            this.Controls.Add(this.btnAnnounce);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.txbAnswer);
            this.Controls.Add(this.labelMeanCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpellingCheckForm";
            this.Text = "SpellingCheckForm";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMeanCN;
        public HZH_Controls.Controls.UCTextBoxEx txbAnswer;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.Button btnAnnounce;
    }
}