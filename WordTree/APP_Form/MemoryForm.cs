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
using HZH_Controls.Forms;

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

        private Node[] savedWords = new Node[10];  //保存每一轮的10个单词
        private WordLinkedList changingWords = new WordLinkedList();  //动态变化的单词循环链表
        private int count = 0;
        private int index;
        private Node currentNode;
        
        public MemoryForm()
        {
            InitializeComponent();
            memoryManager.NeedNum = 20;

            Memory(null,null);
            //wordCheckIn();
        }

        /// <summary>
        /// 控制单个单词记忆的界面跳转逻辑
        /// </summary>
        private void Memory(object sender, EventArgs args)
        {
            try
            {
                //循环链表不为空则取出单词，否则获取新的一轮单词
                if (!changingWords.IsEmpty())
                {
                    try
                    {
                        currentNode = changingWords.GetElem(index);
                    }catch(ApplicationException e)
                    {
                        index = index % changingWords.Count;
                        currentNode = changingWords.GetElem(index);
                    }
                        
                }
                else
                {
                    changingWords = memoryManager.GetNextWords(count);
                    Node temp = changingWords.head.Next;
                    int i = 0;
                    while (temp != changingWords.head)
                    {
                        savedWords[i] = temp;
                        i++;
                        temp = temp.Next;
                    }
                    currentNode = changingWords.GetElem(index);
                }

                switch (currentNode.StrangeDegree)
                {
                    case 3: 
                        ImageCheck(currentNode);
                        break;
                    case 2:
                        ExplanationCheck(currentNode);
                        break;
                    case 1:
                        SpellingCheck(currentNode);
                        break;
                }

            }
            catch (ApplicationException e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void ImageCheck(Node currentNode)
        {
            if (currentNode.Data.Picture != null)
            {
                Word trueWord = currentNode.Data;
                Node[] tempWords = new Node[9];
                int index = 0;
                foreach (Node node in savedWords)
                {
                    if (node != currentNode)
                    {
                        tempWords[index] = node;
                        index++;
                    }
                    
                }
                Node[] randomWords = DifferentRandomController<Node>.GetDifferentRandom(tempWords, 3);  //从剩下的9个单词中获取3个随机单词

                //跳转到ImageCheckForm界面
                ImageCheckForm imageCheckForm = new ImageCheckForm(trueWord, randomWords[0].Data, randomWords[1].Data, randomWords[2].Data);
                imageCheckForm.True += CorrectAnswer;

                transfer.Transfer(this.panel_Form, imageCheckForm);


            }
        }

        private void ExplanationCheck(Node currentNode)
        {
            throw new NotImplementedException();
        }

        private void SpellingCheck(Node currentNode)
        {
            throw new NotImplementedException();
        }

        private void CorrectAnswer()
        {
            if(currentNode.StrangeDegree == 3)
            {
                currentNode.StrangeDegree--;
                var wordInfoForm = new WordInfoForm(currentNode.Data);
                wordInfoForm.ucBtnExt_Next.BtnClick += Memory;
                wordInfoForm.ucBtnExt_Next.Visible = true;
                transfer.Transfer(panel_Form, wordInfoForm);
                index++;
            }

            else
            {
                currentNode.StrangeDegree--;
                if (currentNode.StrangeDegree == 0)
                    changingWords.Remove(index);
                else
                    index++;
            }
        } 

        private void InCorrectAnswer()
        {
            if (currentNode.StrangeDegree != 3)
            {
            }

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
