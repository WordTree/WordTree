using APP_Form.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        bool haveFalse = false;   //记录该单词是否选错过

        Image trueImage = Image.FromFile(@"D:\VS2019\Project\WordTree\WordTree\WordTree\APP_Form\Resources\正确.png");
        Image falseImage = Image.FromFile(@"D:\VS2019\Project\WordTree\WordTree\WordTree\APP_Form\Resources\错误.png");

        public event Action True;
        public event Action False;


        public ImageCheckForm(Word trueWord,Word falseWord1,Word falseWord2,Word falseWord3)
        {
            InitializeComponent();
            this.trueWord = trueWord;
            this.falseWord1 = falseWord1;
            this.falseWord2 = falseWord2;
            this.falseWord3 = falseWord3;

            lblWordStr.Text = trueWord.word;

            //播音


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

        private void picTrueWord_Click(object sender, EventArgs e)
        {
            //出现笑脸
            picTrueWord.Controls.Add(picTrueOrFalse);
            picTrueOrFalse.Parent = picTrueWord;
            picTrueOrFalse.Image = trueImage;
            picTrueWord.Controls.SetChildIndex(picTrueOrFalse, 100);
            Thread.Sleep(500);
            


            if (haveFalse == true)
                True();
            else
                True();   //显示单词详细信息界面，修改当前单词的熟悉程度

        }

        private void picFalseWord1_Click(object sender, EventArgs e)
        {



            haveFalse = true;
        }

        private void picFalseWord2_Click(object sender, EventArgs e)
        {



            haveFalse = true;
        }

        private void picFalseWord3_Click(object sender, EventArgs e)
        {

            haveFalse = true;
        }
    }
}
