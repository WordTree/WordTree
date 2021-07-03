using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree.Model;
using WordTree;
using Newtonsoft.Json;
using WordTree.Service;

namespace Reader
{
    public partial class ReaderForm : Form
    {
        WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
        Paragraph p = new Paragraph();
        ParagraphManager manager = new ParagraphManager();
        Word selected = new Word();//用户选中的单词
        List<string> userchoices = new List<string>();

        public string type = "CET4";//文段类型
        const string cetpath = "..\\..\\..\\Reader\\Pictures\\cet.png";
        const string toeflpath = "..\\..\\..\\Reader\\Pictures\\toefl.png";
        const string ieltspath = "..\\..\\..\\Reader\\Pictures\\ielts.png";
        const string grepath = "..\\..\\..\\Reader\\Pictures\\gre.png";



        public ReaderForm()
        {
            InitializeComponent();
            //wordAndDicManager.init("CET4");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }
        public ReaderForm(string type)
        {
            InitializeComponent();
            //wordAndDicManager.init("CET4");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.type = type;
        }
        /// <summary>
        /// 用户选择
        /// </summary>
        /// <param name="paraname"></param>
        private void SetParagraph(string paraname)
        {
            p.ParagraphName = paraname;
        }
        /// <summary>
        /// 文本显示
        /// </summary>
        private void TraceParaText()
        {
            manager.ContentInit(p);
            Paragraph_richTextBox.Text = p.content;
            string dicInfo = File.ReadAllText("..\\..\\..\\WordTree\\Words\\VocabularyDic\\重点词汇.json");
            VocabularyDic importantDic = JsonConvert.DeserializeObject<VocabularyDic>(dicInfo);
            List<string> keywords = importantDic.List.ToList();
            manager.ContentImpact(keywords, Paragraph_richTextBox);
        }



        private void Paragraph_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Paragraph_richTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                selected = wordAndDicManager.getWord(manager.SlectedStringScanner(Paragraph_richTextBox));
                Info_richTextBox.Text = "\r\n"+"\r\n"+selected.word + "\r\n" + selected.Mean_cn +"\r\n" + selected.Mean_en;
                word_axWindowsMediaPlayer.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + selected.word;
                word_axWindowsMediaPlayer.Ctlcontrols.play();
            }
            catch(Exception ex) { };
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            userchoices = manager.GetAllParagraghNames(type);
            string userchoice = userchoices.FirstOrDefault();
            SetParagraph(userchoice);
            TraceParaText();
        }

        private void ReaderForm_Shown(object sender, EventArgs e)
        {
            //UserTextChoice choiceform = new UserTextChoice(SetParagraph, TraceText);
            //choiceform.Show();
        }

        int scan = 0;//用于文件目录循环遍历
        private void readbutton_Click(object sender, EventArgs e)
        {
            label1.Text = $"Page {scan+1}";
            string imagepath = "";
            switch (type)
            {
                case "CET4":
                    imagepath = cetpath;
                    break;
                case "CET6":
                    imagepath = cetpath;
                    break;
                case "TOEFL":
                    imagepath = toeflpath;
                    break;
                case "IELTS":
                    imagepath = ieltspath;
                    break;
                case "GRE":
                    imagepath = grepath;
                    break;
            }
            pictureBox1.Image = Image.FromFile(imagepath);

            userchoices = manager.GetAllParagraghNames(type);
            string userchoice = userchoices.FirstOrDefault();
            SetParagraph(userchoice);
            TraceParaText();
            scan = (scan + 1) % userchoices.Count;
            userchoice = userchoices[scan];
            SetParagraph(userchoice);
            TraceParaText();
        }

        private void Info_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoPanelTitle_Load(object sender, EventArgs e)
        {

        }

        private void Info_richTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
