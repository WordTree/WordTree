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
    public partial class SearchForm : Form
    {
        ///<summary>Search的目标集合</summary>
        List<string> searchTarget = new List<string>();
        ///<summary>Search的结果集合</summary>
        List<string> searchResult = new List<string>();

        WordInfoForm wordInfoForm;

        WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
        
        public SearchForm()
        {
            InitializeComponent();

            VocabularyDic allWordsDic = wordAndDicManager.getVocabularyDic("AllWords");
            searchTarget = new List<string>(allWordsDic.List);
        }
        /**<summary>
         * 输入内容时自动触发 Search 方法,
         * 并设置相关的属性.
         * </summary>
         */
        private void comboBox_Searcher_TextUpdate(object sender, EventArgs e)
        {
            Search();
            //使光标保持在最后一栏
            this.comboBox_Searcher.SelectionStart = this.comboBox_Searcher.Text.Length;
            //使光标不被遮挡
            Cursor = Cursors.Default;
        }

        /**<summary>
         * 在 searchTarget 中查询,结果存入searchResult,
         * 并更新到comboBox_Searcher.
         * Problem To Solve:第一次搜索自动选择第一个元素.
         * </summary>
         */
        private void Search()
        {
            if (comboBox_Searcher.Text == "")
            {
                comboBox_Searcher.Items.Clear();
            }
            else
            {
                comboBox_Searcher.Items.Clear();
                searchResult.Clear();
                comboBox_Searcher.DroppedDown = true;
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

        private void comboBox_Searcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Searcher.SelectedIndex >= 0)
            {
                pnl_wordInfo.Controls.Clear();
                Word targetWord = wordAndDicManager.getWord((string)comboBox_Searcher.SelectedItem);
                wordInfoForm = new WordInfoForm(targetWord);
                wordInfoForm.TopLevel = false;
                wordInfoForm.FormBorderStyle = FormBorderStyle.None;
                wordInfoForm.Dock = DockStyle.Fill;
                pnl_wordInfo.Controls.Add(wordInfoForm);
                wordInfoForm.Show();
            }
        }


    }
}
