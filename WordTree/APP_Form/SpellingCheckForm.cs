using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree.Model;

namespace APP_Form
{
    public partial class SpellingCheckForm : Form
    {
        Word trueWord;
        string tempAnswer;

        SoundPlayer soundPlayer = new SoundPlayer();
        public event Action True;
        public event Action False;

        public bool haveFalse = false;
        public SpellingCheckForm(Word trueWord)
        {
            InitializeComponent();
            AcceptButton = btnCommit;
            btnCommit.Enabled = true;
            this.trueWord = trueWord;
            labelMeanCN.Text = trueWord.Mean_cn;
            txbAnswer.txtInput.Focus();

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (txbAnswer.InputText.Equals(trueWord.word) && !haveFalse)
            {
                soundPlayer.SoundLocation = @"..\..\Resources\正确提示音.wav";
                soundPlayer.Load();
                soundPlayer.Play();

                txbAnswer.RectColor = ColorTranslator.FromHtml("#1BA784");
                txbAnswer.InputText = "                 (๑•̀ㅂ•́)و✧";
                txbAnswer.Refresh();
                Thread.Sleep(500);

                True();
                this.Dispose();
            }
            else if (txbAnswer.InputText.Equals(trueWord.word) && haveFalse)
            {
                soundPlayer.SoundLocation = @"..\..\Resources\正确提示音.wav";
                soundPlayer.Load();
                soundPlayer.Play();

                txbAnswer.RectColor = ColorTranslator.FromHtml("#1BA784");
                txbAnswer.InputText = "                 (๑•̀ㅂ•́)و✧";
                txbAnswer.Refresh();
                Thread.Sleep(500);

                False();
                this.Dispose();
            }
            else
            {
                haveFalse = true;
                soundPlayer.SoundLocation = @"..\..\Resources\错误提示音.wav";
                soundPlayer.Load();
                soundPlayer.Play();

                txbAnswer.RectColor = Color.FromArgb(205, 92, 92);
                txbAnswer.InputText = "           (°ー°〃)";
                txbAnswer.Refresh();
                Thread.Sleep(500);
                txbAnswer.RectColor = Color.FromArgb(220, 220, 220);
                txbAnswer.InputText = "";
            }
        }

        private void btnKey_MouseUp(object sender, MouseEventArgs e)
        {
            txbAnswer.InputText = tempAnswer;
            txbAnswer.Refresh();
            btnCommit.Enabled = true;
        }

        private void btnKey_MouseDown(object sender, MouseEventArgs e)
        {
            tempAnswer = txbAnswer.InputText;
            txbAnswer.InputText = trueWord.word;
            txbAnswer.Refresh();
            btnCommit.Enabled = false;
        }

        private void btnAnnounce_Click(object sender, EventArgs e)
        {
            mediaPlayer.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + trueWord.word;
            mediaPlayer.Ctlcontrols.play();
        }
    }



}
