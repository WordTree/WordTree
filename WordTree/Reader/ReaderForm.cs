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

namespace Reader
{
    public partial class ReaderForm : Form
    {
        Paragraph p = new Paragraph();
        ParagraphManager manager = new ParagraphManager();
        Word selected = new Word();//用户选中的单词
        WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
        

        public ReaderForm()
        {
            InitializeComponent();
            wordAndDicManager.init("CET4");
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }
        /// <summary>
        /// 窗体间传递用户选择
        /// </summary>
        /// <param name="paraname"></param>
        private void SetParagraph(string paraname)
        {
            p.ParagraphName = paraname;
        }
        /// <summary>
        /// 子窗口回传文本显示命令
        /// </summary>
        private void TraceText()
        {
            manager.ContentInit(p);
            Paragraph_richTextBox.Text = p.content;
            List<string> test = new List<string>();
            test.Add("dull");
            manager.ContentImpact(test, Paragraph_richTextBox);
        }

        private void Paragraph_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void test_button_Click(object sender, EventArgs e)
        {
            /*manager.ContentInit(p);
            Paragraph_richTextBox.Text = p.content;
            List<string> test = new List<string>();
            test.Add("dull");
            manager.ContentImpact(test, Paragraph_richTextBox);
            */



        }

        private void testbutton2_Click(object sender, EventArgs e)
        {
            UserTextChoice choiceform = new UserTextChoice(SetParagraph, TraceText);
            choiceform.Show();
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
            
        }

        private void ReaderForm_Shown(object sender, EventArgs e)
        {
            UserTextChoice choiceform = new UserTextChoice(SetParagraph, TraceText);
            choiceform.Show();
        }
    }
}
