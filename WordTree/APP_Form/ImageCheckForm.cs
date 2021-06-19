using APP_Form.Controller;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree.Model;

namespace APP_Form
{
  
    public partial class ImageCheckForm : Form
    {
        Word trueWord;   //正确单词
        Word falseWord1;  //三个错误单词
        Word falseWord2; 
        Word falseWord3;

        public event Action True; //选对正确答案后的事件

        SoundPlayer soundPlayer = new SoundPlayer();
 
        public ImageCheckForm(Word trueWord,Word falseWord1,Word falseWord2,Word falseWord3)
        {

            InitializeComponent();
            mediaPlayer.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + trueWord.word;
            mediaPlayer.Ctlcontrols.play();
            this.trueWord = trueWord;
            this.falseWord1 = falseWord1;
            this.falseWord2 = falseWord2;
            this.falseWord3 = falseWord3;

            lblWordStr.Text = trueWord.word;

            //将单词图片绑定在各个pictureBox上，并打乱顺序显示
            GetPicture(picTrueWord, trueWord.Picture);
            GetPicture(picFalseWord1, falseWord1.Picture);
            GetPicture(picFalseWord2, falseWord2.Picture);
            GetPicture(picFalseWord3, falseWord3.Picture);
            PictureBox[] pictureBoxes = { picTrueWord, picFalseWord1, picFalseWord2, picFalseWord3 };
            //洗牌
            DifferentRandomController<PictureBox>.Shuffle(pictureBoxes);
            flp_Pictures.Controls.Clear();
            foreach (var picturebox in pictureBoxes)
            {
                flp_Pictures.Controls.Add(picturebox);
            }
        }

        /// <summary>
        /// 获取图片
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="url"></param>
        private void GetPicture(PictureBox pictureBox, string url)
        {
            try {
                    WebRequest webreq = System.Net.WebRequest.Create(url);
                    WebResponse webres = webreq.GetResponse();
                    using (System.IO.Stream stream = webres.GetResponseStream())
                    {
                    pictureBox.Image = Image.FromStream(stream);
                    }
                }
            catch(Exception la) { };
            }

        /// <summary>
        /// 选中正确单词对应的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTrueWord_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = @"..\..\Resources\正确提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();

            //mediaPlayer.URL = @"D:\VS2019\Project\WordTree\WordTree\WordTree\APP_Form\Resources\正确提示音.wav";
            //mediaPlayer.Ctlcontrols.play();
            this.lblWordStr.ForeColor = Color.Green;
            lblWordStr.Refresh();
            Thread.Sleep(500);

            True();
            this.Dispose();
        }

        private void picFalseWord1_Click(object sender, EventArgs e)
        {
            
            soundPlayer.SoundLocation = @"..\..\Resources\错误提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();

            this.lblWordStr.ForeColor = Color.FromArgb(205, 92, 92);
            //mediaPlayer.URL = @"D:\VS2019\Project\WordTree\WordTree\WordTree\APP_Form\Resources\错误提示音.wav";
            //mediaPlayer.Ctlcontrols.play();

            lblWordStr.Refresh();
            Thread.Sleep(500);
            lblWordStr.ForeColor = Color.Black;
            lblWordStr.Refresh();
        }

        private void picFalseWord2_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = @"..\..\Resources\错误提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();
            //mediaPlayer.URL = @"D:\VS2019\Project\WordTree\WordTree\WordTree\APP_Form\Resources\错误提示音.wav";
            //mediaPlayer.Ctlcontrols.play();
            this.lblWordStr.ForeColor = Color.FromArgb(205, 92, 92);
            lblWordStr.Refresh();
            Thread.Sleep(500);
            lblWordStr.ForeColor = Color.Black;
            lblWordStr.Refresh();

        }

        private void picFalseWord3_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = @"..\..\Resources\错误提示音.wav";
            soundPlayer.Load();
            soundPlayer.Play();
            //mediaPlayer.URL = @"D:\VS2019\Project\WordTree\WordTree\WordTree\APP_Form\Resources\错误提示音.wav";
            //mediaPlayer.Ctlcontrols.play();
            this.lblWordStr.ForeColor = Color.FromArgb(205, 92, 92);
            lblWordStr.Refresh();
            Thread.Sleep(500);
            lblWordStr.ForeColor = Color.Black;
            lblWordStr.Refresh();

        }

    }
}
