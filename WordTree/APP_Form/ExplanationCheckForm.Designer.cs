
namespace APP_Form
{
    partial class ExplanationCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplanationCheckForm));
            this.lblWordStr = new System.Windows.Forms.Label();
            this.flp_Btns = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrueWord = new HZH_Controls.Controls.UCBtnExt();
            this.btnFalseWord1 = new HZH_Controls.Controls.UCBtnExt();
            this.btnFalseWord2 = new HZH_Controls.Controls.UCBtnExt();
            this.btnFalseWord3 = new HZH_Controls.Controls.UCBtnExt();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.flp_Btns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordStr
            // 
            this.lblWordStr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWordStr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordStr.Location = new System.Drawing.Point(0, 0);
            this.lblWordStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordStr.Name = "lblWordStr";
            this.lblWordStr.Size = new System.Drawing.Size(817, 101);
            this.lblWordStr.TabIndex = 0;
            this.lblWordStr.Text = "Word";
            this.lblWordStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_Btns
            // 
            this.flp_Btns.Controls.Add(this.btnTrueWord);
            this.flp_Btns.Controls.Add(this.btnFalseWord1);
            this.flp_Btns.Controls.Add(this.btnFalseWord2);
            this.flp_Btns.Controls.Add(this.btnFalseWord3);
            this.flp_Btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_Btns.Location = new System.Drawing.Point(0, 116);
            this.flp_Btns.Margin = new System.Windows.Forms.Padding(4);
            this.flp_Btns.Name = "flp_Btns";
            this.flp_Btns.Size = new System.Drawing.Size(817, 352);
            this.flp_Btns.TabIndex = 1;
            // 
            // btnTrueWord
            // 
            this.btnTrueWord.BackColor = System.Drawing.Color.White;
            this.btnTrueWord.BtnBackColor = System.Drawing.Color.White;
            this.btnTrueWord.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrueWord.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrueWord.BtnText = null;
            this.btnTrueWord.ConerRadius = 25;
            this.btnTrueWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrueWord.EnabledMouseEffect = false;
            this.btnTrueWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrueWord.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnTrueWord.IsRadius = true;
            this.btnTrueWord.IsShowRect = true;
            this.btnTrueWord.IsShowTips = false;
            this.btnTrueWord.Location = new System.Drawing.Point(10, 10);
            this.btnTrueWord.Margin = new System.Windows.Forms.Padding(10);
            this.btnTrueWord.Name = "btnTrueWord";
            this.btnTrueWord.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrueWord.RectWidth = 1;
            this.btnTrueWord.Size = new System.Drawing.Size(788, 60);
            this.btnTrueWord.TabIndex = 0;
            this.btnTrueWord.TabStop = false;
            this.btnTrueWord.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnTrueWord.TipsText = "";
            this.btnTrueWord.BtnClick += new System.EventHandler(this.btnTrueWord_BtnClick);
            // 
            // btnFalseWord1
            // 
            this.btnFalseWord1.BackColor = System.Drawing.Color.White;
            this.btnFalseWord1.BtnBackColor = System.Drawing.Color.White;
            this.btnFalseWord1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFalseWord1.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFalseWord1.BtnText = null;
            this.btnFalseWord1.ConerRadius = 25;
            this.btnFalseWord1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalseWord1.EnabledMouseEffect = false;
            this.btnFalseWord1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFalseWord1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnFalseWord1.IsRadius = true;
            this.btnFalseWord1.IsShowRect = true;
            this.btnFalseWord1.IsShowTips = false;
            this.btnFalseWord1.Location = new System.Drawing.Point(10, 90);
            this.btnFalseWord1.Margin = new System.Windows.Forms.Padding(10);
            this.btnFalseWord1.Name = "btnFalseWord1";
            this.btnFalseWord1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFalseWord1.RectWidth = 1;
            this.btnFalseWord1.Size = new System.Drawing.Size(788, 60);
            this.btnFalseWord1.TabIndex = 1;
            this.btnFalseWord1.TabStop = false;
            this.btnFalseWord1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnFalseWord1.TipsText = "";
            this.btnFalseWord1.BtnClick += new System.EventHandler(this.btnFalseWord1_BtnClick);
            // 
            // btnFalseWord2
            // 
            this.btnFalseWord2.BackColor = System.Drawing.Color.White;
            this.btnFalseWord2.BtnBackColor = System.Drawing.Color.White;
            this.btnFalseWord2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFalseWord2.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFalseWord2.BtnText = null;
            this.btnFalseWord2.ConerRadius = 25;
            this.btnFalseWord2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalseWord2.EnabledMouseEffect = false;
            this.btnFalseWord2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFalseWord2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnFalseWord2.IsRadius = true;
            this.btnFalseWord2.IsShowRect = true;
            this.btnFalseWord2.IsShowTips = false;
            this.btnFalseWord2.Location = new System.Drawing.Point(10, 170);
            this.btnFalseWord2.Margin = new System.Windows.Forms.Padding(10);
            this.btnFalseWord2.Name = "btnFalseWord2";
            this.btnFalseWord2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFalseWord2.RectWidth = 1;
            this.btnFalseWord2.Size = new System.Drawing.Size(788, 60);
            this.btnFalseWord2.TabIndex = 2;
            this.btnFalseWord2.TabStop = false;
            this.btnFalseWord2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnFalseWord2.TipsText = "";
            this.btnFalseWord2.BtnClick += new System.EventHandler(this.btnFalseWord2_BtnClick);
            // 
            // btnFalseWord3
            // 
            this.btnFalseWord3.BackColor = System.Drawing.Color.White;
            this.btnFalseWord3.BtnBackColor = System.Drawing.Color.White;
            this.btnFalseWord3.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFalseWord3.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFalseWord3.BtnText = null;
            this.btnFalseWord3.ConerRadius = 25;
            this.btnFalseWord3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalseWord3.EnabledMouseEffect = false;
            this.btnFalseWord3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFalseWord3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnFalseWord3.IsRadius = true;
            this.btnFalseWord3.IsShowRect = true;
            this.btnFalseWord3.IsShowTips = false;
            this.btnFalseWord3.Location = new System.Drawing.Point(10, 250);
            this.btnFalseWord3.Margin = new System.Windows.Forms.Padding(10);
            this.btnFalseWord3.Name = "btnFalseWord3";
            this.btnFalseWord3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFalseWord3.RectWidth = 1;
            this.btnFalseWord3.Size = new System.Drawing.Size(788, 60);
            this.btnFalseWord3.TabIndex = 3;
            this.btnFalseWord3.TabStop = false;
            this.btnFalseWord3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnFalseWord3.TipsText = "";
            this.btnFalseWord3.BtnClick += new System.EventHandler(this.btnFalseWord3_BtnClick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(565, 12);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.mediaPlayer.TabIndex = 2;
            this.mediaPlayer.Visible = false;
            // 
            // ExplanationCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 468);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.flp_Btns);
            this.Controls.Add(this.lblWordStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExplanationCheckForm";
            this.Text = "ExplanationCheckForm";
            this.flp_Btns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWordStr;
        private System.Windows.Forms.FlowLayoutPanel flp_Btns;
        private HZH_Controls.Controls.UCBtnExt btnTrueWord;
        private HZH_Controls.Controls.UCBtnExt btnFalseWord1;
        private HZH_Controls.Controls.UCBtnExt btnFalseWord2;
        private HZH_Controls.Controls.UCBtnExt btnFalseWord3;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}