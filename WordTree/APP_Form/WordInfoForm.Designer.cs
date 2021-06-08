
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
            ((System.ComponentModel.ISupportInitialize)(this.VoicePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VoicePlayer
            // 
            this.VoicePlayer.Enabled = true;
            this.VoicePlayer.Location = new System.Drawing.Point(718, 415);
            this.VoicePlayer.Name = "VoicePlayer";
            this.VoicePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VoicePlayer.OcxState")));
            this.VoicePlayer.Size = new System.Drawing.Size(52, 44);
            this.VoicePlayer.TabIndex = 12;
            this.VoicePlayer.Visible = false;
            // 
            // label_phrase
            // 
            this.label_phrase.Font = new System.Drawing.Font("宋体", 12F);
            this.label_phrase.Location = new System.Drawing.Point(269, 281);
            this.label_phrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_phrase.Name = "label_phrase";
            this.label_phrase.Size = new System.Drawing.Size(518, 20);
            this.label_phrase.TabIndex = 18;
            // 
            // label_meanEN
            // 
            this.label_meanEN.Font = new System.Drawing.Font("宋体", 12F);
            this.label_meanEN.Location = new System.Drawing.Point(267, 129);
            this.label_meanEN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_meanEN.Name = "label_meanEN";
            this.label_meanEN.Size = new System.Drawing.Size(520, 80);
            this.label_meanEN.TabIndex = 17;
            // 
            // label_Example
            // 
            this.label_Example.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Example.Location = new System.Drawing.Point(265, 215);
            this.label_Example.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Example.Name = "label_Example";
            this.label_Example.Size = new System.Drawing.Size(522, 60);
            this.label_Example.TabIndex = 16;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.Location = new System.Drawing.Point(13, 70);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(155, 135);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // label_meanCN
            // 
            this.label_meanCN.Font = new System.Drawing.Font("宋体", 12F);
            this.label_meanCN.Location = new System.Drawing.Point(267, 83);
            this.label_meanCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_meanCN.Name = "label_meanCN";
            this.label_meanCN.Size = new System.Drawing.Size(520, 40);
            this.label_meanCN.TabIndex = 14;
            // 
            // button_Voice
            // 
            this.button_Voice.Location = new System.Drawing.Point(636, 34);
            this.button_Voice.Margin = new System.Windows.Forms.Padding(4);
            this.button_Voice.Name = "button_Voice";
            this.button_Voice.Size = new System.Drawing.Size(74, 29);
            this.button_Voice.TabIndex = 13;
            this.button_Voice.Text = "播音";
            this.button_Voice.UseVisualStyleBackColor = true;
            this.button_Voice.Click += new System.EventHandler(this.button_Voice_Click);
            // 
            // label_Word
            // 
            this.label_Word.Font = new System.Drawing.Font("宋体", 30F);
            this.label_Word.Location = new System.Drawing.Point(188, 22);
            this.label_Word.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(440, 61);
            this.label_Word.TabIndex = 11;
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_etyma
            // 
            this.label_etyma.Font = new System.Drawing.Font("宋体", 12F);
            this.label_etyma.Location = new System.Drawing.Point(269, 307);
            this.label_etyma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_etyma.Name = "label_etyma";
            this.label_etyma.Size = new System.Drawing.Size(518, 40);
            this.label_etyma.TabIndex = 23;
            // 
            // WordInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 489);
            this.Controls.Add(this.label_etyma);
            this.Controls.Add(this.VoicePlayer);
            this.Controls.Add(this.label_phrase);
            this.Controls.Add(this.label_meanEN);
            this.Controls.Add(this.label_Example);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_meanCN);
            this.Controls.Add(this.button_Voice);
            this.Controls.Add(this.label_Word);
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
    }
}