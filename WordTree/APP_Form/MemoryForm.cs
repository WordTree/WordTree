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
        private PictureBox[] pictureBoxes = new PictureBox[10];

        private const string stage1 = @"..\..\Resources\Images\种子.png";
        private const string stage2 = @"..\..\Resources\Images\幼苗.png";
        private const string stage3 = @"..\..\Resources\Images\成熟期.png";
        private const string stage4 = @"..\..\Resources\Images\带树.png";

        private string[] stages = { stage1, stage2, stage3, stage4 };

        public MemoryForm()
        {
            InitializeComponent();
            memoryManager.NeedNum = 20;
            Memory(null,null);
            InitPictureBoxes();
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
                FrmTips.ShowTips(new Form(), "NICE", 1000, false, ContentAlignment.TopCenter,new Point(2000,600),TipsSizeMode.Small,null,TipsState.Success);
                transfer.Transfer(panel_Form, wordInfoForm);
                SetPicture(index, currentNode.StrangeDegree);
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
        /// 初始化数组 pictureBoxes
        /// </summary>
        private void InitPictureBoxes()
        {
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;
            pictureBoxes[9] = pictureBox10;

            foreach (var picture in pictureBoxes)
            {
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = Image.FromFile(stage1);
            }
        }

        private void SetPicture(int pictureIndex,int StageIndex)
        {
            pictureBoxes[pictureIndex].Image = Image.FromFile(stages[StageIndex]);
        }
    }
}
