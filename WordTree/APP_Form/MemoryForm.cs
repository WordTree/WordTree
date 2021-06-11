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
namespace APP_Form
{
    public partial class MemoryForm : Form
    {
        public WordLinkedList words;
        public int count = 0;
        public int index;
        public Word currentWord;
        public MemoryForm()
        {
            InitializeComponent();
            var manager = WordAndDicManager.getInstance();
            words = new WordLinkedList();
            words.Add(manager.getWord("kingdom"));
            words.Add(manager.getWord("kit"));
            words.Add(manager.getWord("knee"));
            words.Add(manager.getWord("knowledge"));
            wordCheckIn();
        }
        /// <summary>
        /// 检查拼写是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CommitSpelling_Click(object sender, EventArgs e)
        {
            if (textBox_SpellingBox.Text.Equals(currentWord.word))
            {
                words.Remove(index);
                wordCheckIn();
                count += 1;
            }
            else
            {
                index = (index + 1) % words.Count;
                wordCheckIn();
            }
        }

        /// <summary>
        /// 开始复习
        /// </summary>
        private void wordCheckIn()
        {
            if (!words.IsEmpty())
            {
                var word = words.GetElem(index);
                label_meanZN.Text = word.Mean_cn;
                this.currentWord = word;
            }
            else
            {
                label_meanZN.Text = "今天的单词已经背完了！";
                button_CommitSpelling.Enabled = false;
            }
        }
    }
}
