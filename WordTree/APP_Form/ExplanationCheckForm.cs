using APP_Form.Controller;
using HZH_Controls.Controls;
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
    public partial class ExplanationCheckForm : Form
    {
        Word trueWord;   //正确单词
        Word falseWord1;  //三个错误单词
        Word falseWord2;
        Word falseWord3;

        bool haveFalse = false;   //记录该单词是否选错过
        SoundPlayer soundPlayer = new SoundPlayer();

        public event Action True;
        public event Action False;

        public ExplanationCheckForm(Word trueWord, Word falseWord1, Word falseWord2, Word falseWord3)
        {

            InitializeComponent();
            mediaPlayer.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + trueWord.word;
            mediaPlayer.Ctlcontrols.play();
            this.trueWord = trueWord;
            this.falseWord1 = falseWord1;
            this.falseWord2 = falseWord2;
            this.falseWord3 = falseWord3;

            lblWordStr.Text = trueWord.word;
            btnTrueWord.BtnText = trueWord.Mean_cn;
            btnFalseWord1.BtnText = falseWord1.Mean_cn;
            btnFalseWord2.BtnText = falseWord2.Mean_cn;
            btnFalseWord3.BtnText = falseWord3.Mean_cn;

            UCBtnExt[] btns = { btnTrueWord , btnFalseWord1,btnFalseWord2,btnFalseWord3};
            DifferentRandomController<UCBtnExt>.Shuffle(btns);
 
            flp_Btns.Controls.Clear();
            foreach (var picturebox in btns)
            {
                flp_Btns.Controls.Add(picturebox);
            }
        }

        public ExplanationCheckForm()
        {
            InitializeComponent();
        }
        private void btnTrueWord_BtnClick(object sender, EventArgs e)
        {
            //mediaPlayer.URL = @"..\..\Resources\错误提示音.wav";
            //mediaPlayer.Ctlcontrols.play();
            soundPlayer.SoundLocation = @"..\..\Resources\正确提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();

            this.lblWordStr.ForeColor = Color.Green;
            btnTrueWord.FillColor = ColorTranslator.FromHtml("#1BA784");
            btnTrueWord.RectColor = ColorTranslator.FromHtml("#1BA784");
            btnTrueWord.Refresh();
            lblWordStr.Refresh();
            Thread.Sleep(500);

            if (haveFalse == true)
            {
                False();   //曾经选择错误过，显示单词详细信息，不修改当前单词的熟悉程度
            }
            else
            {
                True();   // 直接选择正确，直接下一个单词，修改当前单词的熟悉程度
            }
            this.Dispose();
        }

        private void btnFalseWord1_BtnClick(object sender, EventArgs e)
        {
            //mediaPlayer.URL = @"..\..\Resources\错误提示音.wav";
            //mediaPlayer.Ctlcontrols.play();
            soundPlayer.SoundLocation = @"..\..\Resources\错误提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();

            this.lblWordStr.ForeColor = Color.FromArgb(205, 92, 92);
            btnFalseWord1.FillColor = Color.FromArgb(205, 92, 92);
            btnFalseWord1.RectColor = Color.FromArgb(205, 92, 92);
            btnFalseWord1.Refresh();
            lblWordStr.Refresh();
            Thread.Sleep(500);
            lblWordStr.ForeColor = Color.Black;
            btnFalseWord1.FillColor = Color.FromArgb(224, 224, 224);
            btnFalseWord1.RectColor = Color.FromArgb(224, 224, 224);
            btnFalseWord1.Refresh();
            lblWordStr.Refresh();

            haveFalse = true;
        }

        private void btnFalseWord2_BtnClick(object sender, EventArgs e)
        {
            //mediaPlayer.URL = @"..\..\Resources\错误提示音.wav";
            //mediaPlayer.Ctlcontrols.play();
            soundPlayer.SoundLocation = @"..\..\Resources\错误提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();

            this.lblWordStr.ForeColor = Color.FromArgb(205, 92, 92);
            btnFalseWord2.FillColor = Color.FromArgb(205, 92, 92);
            btnFalseWord2.RectColor = Color.FromArgb(205, 92, 92);
            btnFalseWord2.Refresh();
            lblWordStr.Refresh();
            Thread.Sleep(500);
            lblWordStr.ForeColor = Color.Black;
            btnFalseWord2.FillColor = Color.FromArgb(224, 224, 224);
            btnFalseWord2.RectColor = Color.FromArgb(224, 224, 224);
            btnFalseWord2.Refresh();
            lblWordStr.Refresh();

            haveFalse = true;
        }

        private void btnFalseWord3_BtnClick(object sender, EventArgs e)
        {
            //mediaPlayer.URL = @"..\..\Resources\错误提示音.wav";
            //mediaPlayer.Ctlcontrols.play();
            soundPlayer.SoundLocation = @"..\..\Resources\错误提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();

            this.lblWordStr.ForeColor = Color.FromArgb(205, 92, 92);
            btnFalseWord3.FillColor = Color.FromArgb(205, 92, 92);
            btnFalseWord3.RectColor = Color.FromArgb(205, 92, 92);
            btnFalseWord3.Refresh();
            lblWordStr.Refresh();
            Thread.Sleep(500);
            lblWordStr.ForeColor = Color.Black;
            btnFalseWord3.FillColor = Color.FromArgb(224, 224, 224);
            btnFalseWord3.RectColor = Color.FromArgb(224, 224, 224);
            btnFalseWord3.Refresh();
            lblWordStr.Refresh();

            haveFalse = true;
        }
    }
}
