
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
            this.label_phrase = new System.Windows.Forms.Label();
            this.label_meanEN = new System.Windows.Forms.Label();
            this.label_Example = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_meanCN = new System.Windows.Forms.Label();
            this.button_Voice = new System.Windows.Forms.Button();
            this.label_Word = new System.Windows.Forms.Label();
            this.label_etyma = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.ucBtnExt_Next = new HZH_Controls.Controls.UCBtnExt();
            ((System.ComponentModel.ISupportInitialize)(this.VoicePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VoicePlayer
            // 
            this.VoicePlayer.Enabled = true;
            this.VoicePlayer.Location = new System.Drawing.Point(748, 434);
            this.VoicePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.VoicePlayer.Name = "VoicePlayer";
            this.VoicePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VoicePlayer.OcxState")));
            this.VoicePlayer.Size = new System.Drawing.Size(52, 44);
            this.VoicePlayer.TabIndex = 12;
            this.VoicePlayer.Visible = false;
            // 
            // label_phrase
            // 
            this.label_phrase.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_phrase.Location = new System.Drawing.Point(202, 294);
            this.label_phrase.Name = "label_phrase";
            this.label_phrase.Size = new System.Drawing.Size(314, 32);
            this.label_phrase.TabIndex = 18;
            this.label_phrase.Text = "Phrase";
            // 
            // label_meanEN
            // 
            this.label_meanEN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_meanEN.Location = new System.Drawing.Point(200, 103);
            this.label_meanEN.Margin = new System.Windows.Forms.Padding(3);
            this.label_meanEN.Name = "label_meanEN";
            this.label_meanEN.Size = new System.Drawing.Size(316, 64);
            this.label_meanEN.TabIndex = 17;
            this.label_meanEN.Text = "MeanEN";
            // 
            // label_Example
            // 
            this.label_Example.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Example.Location = new System.Drawing.Point(199, 172);
            this.label_Example.Name = "label_Example";
            this.label_Example.Size = new System.Drawing.Size(317, 122);
            this.label_Example.TabIndex = 16;
            this.label_Example.Text = "Example\r\n\r\n\r\n\r\n";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.Location = new System.Drawing.Point(10, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(116, 108);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // label_meanCN
            // 
            this.label_meanCN.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_meanCN.Location = new System.Drawing.Point(200, 66);
            this.label_meanCN.Name = "label_meanCN";
            this.label_meanCN.Size = new System.Drawing.Size(316, 32);
            this.label_meanCN.TabIndex = 14;
            this.label_meanCN.Text = "meanCN";
            // 
            // button_Voice
            // 
            this.button_Voice.Location = new System.Drawing.Point(442, 29);
            this.button_Voice.Name = "button_Voice";
            this.button_Voice.Size = new System.Drawing.Size(59, 24);
            this.button_Voice.TabIndex = 13;
            this.button_Voice.Text = "播音";
            this.button_Voice.UseVisualStyleBackColor = true;
            this.button_Voice.Click += new System.EventHandler(this.button_Voice_Click);
            // 
            // label_Word
            // 
            this.label_Word.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Word.Location = new System.Drawing.Point(106, 4);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(330, 49);
            this.label_Word.TabIndex = 11;
            this.label_Word.Text = "Word";
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_etyma
            // 
            this.label_etyma.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_etyma.Location = new System.Drawing.Point(199, 347);
            this.label_etyma.Name = "label_etyma";
            this.label_etyma.Size = new System.Drawing.Size(314, 32);
            this.label_etyma.TabIndex = 23;
            this.label_etyma.Text = "etyma";
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Location = new System.Drawing.Point(33, 196);
            this.btnAddPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(62, 24);
            this.btnAddPlan.TabIndex = 24;
            this.btnAddPlan.Text = "加入计划";
            this.btnAddPlan.UseVisualStyleBackColor = true;
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // ucBtnExt_Next
            // 
            this.ucBtnExt_Next.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_Next.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_Next.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_Next.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_Next.BtnText = "NEXT>>";
            this.ucBtnExt_Next.ConerRadius = 5;
            this.ucBtnExt_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_Next.EnabledMouseEffect = false;
            this.ucBtnExt_Next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_Next.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_Next.IsRadius = true;
            this.ucBtnExt_Next.IsShowRect = true;
            this.ucBtnExt_Next.IsShowTips = false;
            this.ucBtnExt_Next.Location = new System.Drawing.Point(12, 286);
            this.ucBtnExt_Next.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_Next.Name = "ucBtnExt_Next";
            this.ucBtnExt_Next.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_Next.RectWidth = 1;
            this.ucBtnExt_Next.Size = new System.Drawing.Size(124, 40);
            this.ucBtnExt_Next.TabIndex = 25;
            this.ucBtnExt_Next.TabStop = false;
            this.ucBtnExt_Next.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_Next.TipsText = "";
            this.ucBtnExt_Next.Visible = false;
            // 
            // WordInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 423);
            this.Controls.Add(this.ucBtnExt_Next);
            this.Controls.Add(this.btnAddPlan);
            this.Controls.Add(this.label_etyma);
            this.Controls.Add(this.VoicePlayer);
            this.Controls.Add(this.label_phrase);
            this.Controls.Add(this.label_meanEN);
            this.Controls.Add(this.label_Example);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_meanCN);
            this.Controls.Add(this.button_Voice);
            this.Controls.Add(this.label_Word);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WordInfoForm";
            this.Text = "WordInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.VoicePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer VoicePlayer;
        private System.Windows.Forms.Label label_phrase;
        private System.Windows.Forms.Label label_meanEN;
        private System.Windows.Forms.Label label_Example;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_meanCN;
        private System.Windows.Forms.Button button_Voice;
        private System.Windows.Forms.Label label_Word;
        private System.Windows.Forms.Label label_etyma;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button btnAddPlan;
        public HZH_Controls.Controls.UCBtnExt ucBtnExt_Next;
    }
}