
namespace APP_Form
{
    partial class WordInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordInfoForm));
            this.VoicePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.label_Word = new System.Windows.Forms.Label();
            this.ucBtnExt_Next = new HZH_Controls.Controls.UCBtnExt();
            this.rtbWordInfo = new System.Windows.Forms.RichTextBox();
            this.lblAccent = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_AddPlan = new System.Windows.Forms.Button();
            this.button_Voice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VoicePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VoicePlayer
            // 
            this.VoicePlayer.Enabled = true;
            this.VoicePlayer.Location = new System.Drawing.Point(742, 428);
            this.VoicePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VoicePlayer.Name = "VoicePlayer";
            this.VoicePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VoicePlayer.OcxState")));
            this.VoicePlayer.Size = new System.Drawing.Size(58, 38);
            this.VoicePlayer.TabIndex = 12;
            this.VoicePlayer.Visible = false;
            // 
            // label_Word
            // 
            this.label_Word.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Word.Location = new System.Drawing.Point(129, 9);
            this.label_Word.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(370, 60);
            this.label_Word.TabIndex = 11;
            this.label_Word.Text = "Word";
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBtnExt_Next
            // 
            this.ucBtnExt_Next.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_Next.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_Next.BtnFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ucBtnExt_Next.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucBtnExt_Next.BtnText = "NEXT>>";
            this.ucBtnExt_Next.ConerRadius = 15;
            this.ucBtnExt_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_Next.EnabledMouseEffect = false;
            this.ucBtnExt_Next.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.ucBtnExt_Next.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_Next.IsRadius = true;
            this.ucBtnExt_Next.IsShowRect = true;
            this.ucBtnExt_Next.IsShowTips = false;
            this.ucBtnExt_Next.Location = new System.Drawing.Point(7, 326);
            this.ucBtnExt_Next.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_Next.Name = "ucBtnExt_Next";
            this.ucBtnExt_Next.RectColor = System.Drawing.Color.MediumSeaGreen;
            this.ucBtnExt_Next.RectWidth = 1;
            this.ucBtnExt_Next.Size = new System.Drawing.Size(78, 30);
            this.ucBtnExt_Next.TabIndex = 25;
            this.ucBtnExt_Next.TabStop = false;
            this.ucBtnExt_Next.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_Next.TipsText = "";
            this.ucBtnExt_Next.Visible = false;
            this.ucBtnExt_Next.BtnClick += new System.EventHandler(this.ucBtnExt_Next_BtnClick);
            // 
            // rtbWordInfo
            // 
            this.rtbWordInfo.BackColor = System.Drawing.Color.White;
            this.rtbWordInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbWordInfo.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbWordInfo.Location = new System.Drawing.Point(100, 95);
            this.rtbWordInfo.Name = "rtbWordInfo";
            this.rtbWordInfo.ReadOnly = true;
            this.rtbWordInfo.Size = new System.Drawing.Size(446, 286);
            this.rtbWordInfo.TabIndex = 26;
            this.rtbWordInfo.Text = "";
            // 
            // lblAccent
            // 
            this.lblAccent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccent.Location = new System.Drawing.Point(134, 69);
            this.lblAccent.Margin = new System.Windows.Forms.Padding(0);
            this.lblAccent.Name = "lblAccent";
            this.lblAccent.Size = new System.Drawing.Size(365, 23);
            this.lblAccent.TabIndex = 27;
            this.lblAccent.Text = "Accent";
            this.lblAccent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.Transparent;
            this.button_enter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_enter.FlatAppearance.BorderSize = 0;
            this.button_enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.Location = new System.Drawing.Point(599, -1);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(1, 1);
            this.button_enter.TabIndex = 28;
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.ucBtnExt_Next_BtnClick);
            // 
            // button_AddPlan
            // 
            this.button_AddPlan.BackColor = System.Drawing.Color.Transparent;
            this.button_AddPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_AddPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddPlan.FlatAppearance.BorderSize = 0;
            this.button_AddPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_AddPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_AddPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddPlan.ForeColor = System.Drawing.Color.Transparent;
            this.button_AddPlan.Location = new System.Drawing.Point(493, 28);
            this.button_AddPlan.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddPlan.Name = "button_AddPlan";
            this.button_AddPlan.Size = new System.Drawing.Size(41, 40);
            this.button_AddPlan.TabIndex = 29;
            this.button_AddPlan.UseVisualStyleBackColor = false;
            this.button_AddPlan.Click += new System.EventHandler(this.button_AddPlan_Click);
            // 
            // button_Voice
            // 
            this.button_Voice.BackColor = System.Drawing.Color.Transparent;
            this.button_Voice.BackgroundImage = global::APP_Form.Properties.Resources.喇叭;
            this.button_Voice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Voice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Voice.FlatAppearance.BorderSize = 0;
            this.button_Voice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Voice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Voice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Voice.ForeColor = System.Drawing.Color.Transparent;
            this.button_Voice.Location = new System.Drawing.Point(542, 30);
            this.button_Voice.Margin = new System.Windows.Forms.Padding(4);
            this.button_Voice.Name = "button_Voice";
            this.button_Voice.Size = new System.Drawing.Size(41, 40);
            this.button_Voice.TabIndex = 13;
            this.button_Voice.UseVisualStyleBackColor = false;
            this.button_Voice.Click += new System.EventHandler(this.button_Voice_Click);
            // 
            // WordInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 382);
            this.Controls.Add(this.button_AddPlan);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.lblAccent);
            this.Controls.Add(this.rtbWordInfo);
            this.Controls.Add(this.ucBtnExt_Next);
            this.Controls.Add(this.VoicePlayer);
            this.Controls.Add(this.button_Voice);
            this.Controls.Add(this.label_Word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordInfoForm";
            this.Text = "WordInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.VoicePlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer VoicePlayer;
        private System.Windows.Forms.Button button_Voice;
        private System.Windows.Forms.Label label_Word;
        public HZH_Controls.Controls.UCBtnExt ucBtnExt_Next;
        private System.Windows.Forms.RichTextBox rtbWordInfo;
        private System.Windows.Forms.Label lblAccent;
        public System.Windows.Forms.Button button_enter;
        public System.Windows.Forms.Button button_AddPlan;
    }
}