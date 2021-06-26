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

        private List<Node> savedWords = new List<Node>(); //保存每一轮的10个单词
        private WordLinkedList changingWords = new WordLinkedList();  //动态变化的单词循环链表
        private int count = 0;   //已完成记忆的单词数量
        private int index;    //单词在循环链表中的index

        private Node currentNode;
        private PictureBox[] pictureBoxes = new PictureBox[10];

        private const string stage1 = @"..\..\Resources\Images\种子.png";
        private const string stage2 = @"..\..\Resources\Images\幼苗.png";
        private const string stage3 = @"..\..\Resources\Images\成熟期.png";
        private const string stage4 = @"..\..\Resources\Images\带树.png";

        private string[] stages = { stage4, stage3, stage2, stage1 };

        public MemoryForm()
        {
            InitializeComponent();
            memoryManager.NeedNum = 20;
            InitPictureBoxes();
            transfer.Transfer(panel_Form, new FinishedForm());

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
                    savedWords.Clear();
                    changingWords = memoryManager.GetNextWords(count);
                    Node temp = changingWords.head.Next;
                    while (temp != changingWords.head)
                    {
                        savedWords.Add(temp);
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
                //MessageBox.Show(e.Message);
                //transfer.Transfer(panel_Form, new FinishedForm());
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
            spellingCheckForm.txbAnswer.txtInput.Focus();
            

        }

        /// <summary>
        /// 直接回答正确后的操作
        /// </summary>
        private void CorrectAnswer()
        {
            int wordIndex = savedWords.IndexOf(currentNode);
            if (currentNode.StrangeDegree == 3)     //若为选图方法，熟悉度-1且显示单词详细信息
            {
                currentNode.StrangeDegree--;
                SetPicture(wordIndex, currentNode.StrangeDegree);

                HaveIncorrectAnswer();      //操作相同因此调用改方法

            }
            else     //若为其他两种方法，熟悉度-1并直接下一个单词记忆
            {
                currentNode.StrangeDegree--;
                SetPicture(wordIndex, currentNode.StrangeDegree);

                if (currentNode.StrangeDegree == 0)   //熟悉度为0则移出循环队列并将记录写回数据库
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

        /// <summary>
        /// 初始化图片数组 pictureBoxes
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
