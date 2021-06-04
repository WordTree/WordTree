using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree;
using WordTree.Model;

namespace APP_Form
{
    public partial class Form1 : Form
    {
        ///<summary>Search的目标集合</summary>
        List<string> searchTarget = new List<string>();
        ///<summary>Search的结果集合</summary>
        List<string> searchResult = new List<string>();

        WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
        
        public Form1()
        {
            InitializeComponent();
            wordAndDicManager.init("CET4");
            searchTarget = new List<string>(wordAndDicManager.targetDic.List);
            //TestInit();
        }
        /**<summary>
         * 输入内容时自动触发 Search 方法,
         * 并设置相关的属性.
         * </summary>
         */
        private void comboBox_Searcher_TextUpdate(object sender, EventArgs e)
        {
            Search();
            comboBox_Searcher.DroppedDown = true;
            //使光标保持在最后一栏
            this.comboBox_Searcher.SelectionStart = this.comboBox_Searcher.Text.Length;
            //使光标不被遮挡
            Cursor = Cursors.Default;
        }

        /**<summary>
         * 在 searchTarget 中查询,结果存入searchResult,
         * 并更新到comboBox_Searcher.
         * 
         * Problem To Solve:第一次搜索自动选择第一个元素.
         * </summary>
         */
        private void Search()
        {
            if (comboBox_Searcher.Text == "")
            {
                comboBox_Searcher.DroppedDown = false;
            }
            else
            {
                comboBox_Searcher.Items.Clear();
                searchResult.Clear();
                foreach (var wordstr in searchTarget)
                {
                    if (wordstr.StartsWith(comboBox_Searcher.Text.ToLower()))
                    {
                        searchResult.Add(wordstr);
                    }
                }
                comboBox_Searcher.Items.AddRange(searchResult.ToArray());
            }
        }

        /**<summary>
         * 更改查询结果的详细信息
         * </summary>
         */
        private void SetWord(string word,string explination,string example,Image image)
        {
            label_Word.Text = word;
            label_meanCN.Text = explination;
            label_Example.Text = example;
            pictureBox.Image = image;
        }
        private void TestInit()
        {
            
        }

        private void comboBox_Searcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Word targetWord = wordAndDicManager.getWord((string)comboBox_Searcher.SelectedItem);
            label_Word.Text = targetWord.word;
            label_meanCN.Text = targetWord.Mean_cn;
            label_meanEN.Text = targetWord.Mean_en;
            label_Example.Text = targetWord.Sentence + "\n" + targetWord.Sentence_trans;
            label_else.Text = targetWord.Sentence_phrase + "\n" + targetWord.Word_etyma;
            axWindowsMediaPlayer1.URL = "http://dict.youdao.com/dictvoice?type=1&audio="+targetWord.word;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
            //pictureBox.Image = image;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Voice_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_meanCN_Click(object sender, EventArgs e)
        {

        }
    }
}
