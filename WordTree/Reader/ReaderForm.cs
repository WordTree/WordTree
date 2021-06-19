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

        string type = "ForFun";//文段类型

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
        private void TraceText()
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
                Info_richTextBox.Text = selected.word + "\r\n" + selected.Mean_cn;
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
            TraceText();
        }

        private void ReaderForm_Shown(object sender, EventArgs e)
        {
            //UserTextChoice choiceform = new UserTextChoice(SetParagraph, TraceText);
            //choiceform.Show();
        }

        int scan = 0;//用于文件目录循环遍历
        private void readbutton_Click(object sender, EventArgs e)
        {
            //UserTextChoice choiceform = new UserTextChoice(SetParagraph, TraceText);
            //choiceform.Show();
            scan = (scan + 1) % userchoices.Count;
            string userchoice = userchoices[scan];
            SetParagraph(userchoice);
            TraceText();
        }
    }
}
