﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Controls;
using Newtonsoft.Json;
using WordTree.Model;
using WordTree.Service;


namespace StatTracer
{
    public partial class TraceForm : Form
    {
        public List<string> yesterday = new List<string>();
        public List<string> today = new List<string>();
        public List<string> tomorrow = new List<string>();
        //int count = 0;
        //int needNum = 0;
        float growth = 0.1f;

        WordAndDicManager manager = WordAndDicManager.getInstance();
        public  TraceForm()
        {
            InitializeComponent();
            YesterdayRecordInit();
            TodaydayRecordInit();
            TomorrowRecordInit();
           
            FormInit(TimeLine1, yesterday);
            FormInit(TimeLine2, today);
            FormInit(TimeLine3, tomorrow);

            PictureBoxInit(plant_pictureBox, pot_pictureBox);
            PictureBoxInit(copy1plant_pictureBox, copypot_pictureBox1);
            PictureBoxInit(copy3plant_pictureBox, copypot_pictureBox3);

        }



        private void YesterdayRecordInit()
        {
            string recordstring = File.ReadAllText("..\\..\\..\\StatTracer\\Record\\history\\hinfo.json");
            List<string> records = JsonConvert.DeserializeObject<List<string>>(recordstring);
            yesterday = records;
        }
        private void TodaydayRecordInit()
        {
            string recordstring = File.ReadAllText("..\\..\\..\\StatTracer\\Record\\current\\cinfo.json");
            List<string> records = JsonConvert.DeserializeObject<List<string>>(recordstring);
            today = records;
        }

        public void TomorrowRecordInit()
        {
            string recordstring = File.ReadAllText("..\\..\\..\\StatTracer\\Record\\temp\\tinfo.json");
            List<string> records = JsonConvert.DeserializeObject<List<string>>(recordstring);
            tomorrow = records;
        }

        public void TomorrowFormUpdate()
        {
            List<Word> words = new List<Word>();
            List<TimeLineItem> temps = new List<TimeLineItem>();
            foreach (string reco in tomorrow)
            {
                TimeLineItem temp = new TimeLineItem();
                Word word = manager.getWord(reco);
                temp.Details = word.Mean_cn + "\r\n" + word.Mean_en + "\r\n" + word.Sentence;
                temp.Title = word.word;
                temps.Add(temp);
            }
            if (TimeLine3.InvokeRequired)
            {
                Action action = new Action(()=> TimeLine3.Items = temps.ToArray());
                TimeLine3.Invoke(action);
            }
            else
            {
                TimeLine3.Items = temps.ToArray();
            }
            
        }

        public async void FormInit(UCTimeLine timeLine, List<string> record )
        {
            List<Word> words = new List<Word>();
            List<TimeLineItem> temps = new List<TimeLineItem>();
            if (record != null)
            {
                await Task.Run(() =>
                {
                    foreach (string reco in record)
                    {
                        TimeLineItem temp = new TimeLineItem();
                        Word word = manager.getWord(reco);
                        temp.Details = word.Mean_cn + "\r\n" + word.Mean_en + "\r\n" + word.Sentence;
                        temp.Title = word.word;
                        temps.Add(temp);
                    }
                });

                timeLine.Items = temps.ToArray();
            }
        }

        public void SetTree(int count, int needNum)
        {
            try
            {
               growth = count / needNum;
            }catch(Exception e)
            {
                growth = 0.1f;
            }
            if (growth > 0.25 && growth < 0.75) plant_pictureBox.Image = Image.FromFile("..\\..\\..\\StatTracer\\Tree\\seedling.png");
            if (growth > 0.75 && growth <= 1)//随机生成植物
            {
                int index = 1;
                Random random = new Random();
                index = random.Next(1, 3);
                plant_pictureBox.Image = Image.FromFile($"..\\..\\..\\StatTracer\\Tree\\animatedplants\\{index}.gif");
                copy1plant_pictureBox.Image = plant_pictureBox.Image;
                copy3plant_pictureBox.Image = plant_pictureBox.Image;
            }
           
        }

        private void PictureBoxInit(PictureBox son, PictureBox parent )
        {
            son.BackColor = Color.Transparent;
            son.Parent = parent;
            son.Location = new Point(10, -10);
        }

    }

    internal class MemoryInfo
    {
        public int count = 0;
        public int index = 0;
        public List<Node> savedWords = new List<Node>();
        public WordLinkedList changingWords = new WordLinkedList();

        public MemoryInfo()
        {

        }
        public MemoryInfo(int count, int index, List<Node> savedWords, WordLinkedList changingWords)
        {
            this.count = count;
            this.index = index;
            this.savedWords = savedWords;
            this.changingWords = changingWords;
        }

        public bool IsAvailable()
        {
            return savedWords.Count != 0 && !changingWords.IsEmpty();
        }
    }
}
