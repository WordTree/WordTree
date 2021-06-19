﻿using System;
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
        }

        /// <summary>
        /// 控制单个单词记忆的界面跳转逻辑
        /// </summary>
        public void Memory(object sender, EventArgs args)
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


        /// <summary>
        /// 显示选图方法界面
        /// </summary>
        /// <param name="currentNode"></param>
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

        /// <summary>
        /// 显示选释义方法界面
        /// </summary>
        /// <param name="currentNode"></param>
        private void ExplanationCheck(Node currentNode)
        {
            //从剩下的9个单词中获取3个随机单词
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
            Node[] randomWords = DifferentRandomController<Node>.GetDifferentRandom(tempWords, 3);  

            //跳转到ExplanationCheckForm界面
            ExplanationCheckForm explanationCheckForm = new ExplanationCheckForm(trueWord, randomWords[0].Data, randomWords[1].Data, randomWords[2].Data);
            explanationCheckForm.True += CorrectAnswer;
            explanationCheckForm.False += HaveIncorrectAnswer;
            transfer.Transfer(this.panel_Form, explanationCheckForm);
        }

        /// <summary>
        /// 显示默写方法界面
        /// </summary>
        /// <param name="currentNode"></param>
        private void SpellingCheck(Node currentNode)
        {
            SpellingCheckForm spellingCheckForm = new SpellingCheckForm(currentNode.Data);
            spellingCheckForm.True += CorrectAnswer;
            spellingCheckForm.False += HaveIncorrectAnswer;

            transfer.Transfer(panel_Form, spellingCheckForm);


        }

        /// <summary>
        /// 直接回答正确后的操作：若为选图方法，熟悉度-1且显示单词详细信息，若为其他两种方法，直接下一个单词记忆
        /// </summary>
        private void CorrectAnswer()
        {
            if(currentNode.StrangeDegree == 3)
            {
                currentNode.StrangeDegree--;
                HaveIncorrectAnswer();
            }
            else
            {
                currentNode.StrangeDegree--;
                if (currentNode.StrangeDegree == 0)
                {
                    changingWords.Remove(index);
                    count++;
                    memoryManager.CompleteMmry(currentNode.Data);
                }
                    
                else
                    index++;

                Memory(null,null);

            }
        } 

        /// <summary>
        /// 回答过程中选择过错误答案的操作：显示单词详细信息，并选择下一个单词，不更改当前单词熟悉度
        /// </summary>
        private void HaveIncorrectAnswer()
        {
            var wordInfoForm = new WordInfoForm(currentNode.Data);
            wordInfoForm.ucBtnExt_Next.BtnClick += Memory;
            wordInfoForm.ucBtnExt_Next.Visible = true;
            transfer.Transfer(panel_Form, wordInfoForm);
            index++;
        }



      
    }
}
