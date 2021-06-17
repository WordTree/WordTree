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
using WordTree;
using System.Threading;
using APP_Form.Controller;

namespace APP_Form
{
    public partial class MemoryForm : Form
    {
        public MemoryManager memoryManager = new MemoryManager();
        WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
        /// <summary>
        /// 用于实现页面跳转
        /// </summary>
        private TransferController transfer = TransferController.GetController();

        public WordLinkedList words;
        public int count = 0;
        public int index;
        public Word currentWord;
        public MemoryForm()
        {
            InitializeComponent();


            memoryManager.NeedNum = 30;

            // words = memoryManager.GetNextWords(count);

            //wordCheckIn();
        }
        /// <summary>
        /// 检查拼写是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //        private void button_CommitSpelling_Click(object sender, EventArgs e)
        //        {
        //            if (textBox_SpellingBox.Text.Equals(currentWord.word))
        //            {
        //                words.Remove(index);
        //                if (words.GetElem(index) == null)
        //                {
        //                    index = index % words.Count;
        //                }
        //                MessageBox.Show("正确");
        //                wordCheckIn();
        //                textBox_SpellingBox.Text = "";
        //                count += 1;
        //            }
        //            else
        //            {
        //                index = (index + 1) % words.Count;
        //                MessageBox.Show("错误");
        //                wordCheckIn();
        //            }
        //        }

        //        /// <summary>
        //        /// 开始复习
        //        /// </summary>
        //        private void wordCheckIn()
        //        {
        //            if (!words.IsEmpty())
        //            {
        //                var node = words.GetElem(index);
        //                label_meanZN.Text = node.Data.Mean_cn;
        //                this.currentWord = node.Data;
        //            }
        //            else
        //            {
        //                label_meanZN.Text = "今天的单词已经背完了！";
        //                button_CommitSpelling.Enabled = false;
        //            }
        //        }

        //        private void button1_Click(object sender, EventArgs e)
        //        {
        //            axWindowsMediaPlayer1.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + currentWord.word;
        //            axWindowsMediaPlayer1.Ctlcontrols.play();
        //        }
        //    }
    }
}
