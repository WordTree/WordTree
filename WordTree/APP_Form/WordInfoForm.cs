using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree.Model;
using WordTree.Service;

namespace APP_Form
{
    public partial class WordInfoForm : Form
    {
        private Word targetWord;

        public WordInfoForm(Word targetWord)
        {
            this.targetWord = targetWord;
            InitializeComponent();
            label_Word.Text = targetWord.word;
            lblAccent.Text = targetWord.Accent;
            rtbWordInfo.AppendText(targetWord.Mean_cn + "\n\n");
            rtbWordInfo.AppendText(targetWord.Mean_en + "\n\n");
            rtbWordInfo.AppendText(targetWord.Sentence + "\n");
            rtbWordInfo.AppendText(targetWord.Sentence_trans + "\n\n");
            rtbWordInfo.AppendText(targetWord.Sentence_phrase + "\n");
            rtbWordInfo.AppendText(targetWord.Word_etyma + "\n");
            
            VoicePlayer.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + targetWord.word;
            VoicePlayer.Ctlcontrols.play();

        }

        private void button_Voice_Click(object sender, EventArgs e)
        {
            VoicePlayer.Ctlcontrols.play();
        }

        private void ucBtnExt_Next_BtnClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
