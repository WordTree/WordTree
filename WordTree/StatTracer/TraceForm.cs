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
        List<string> yesterday = new List<string>();
        List<string> today = new List<string>();
        List<string> tomorrow = new List<string>();

        WordAndDicManager manager = WordAndDicManager.getInstance();
        public TraceForm()
        {
            InitializeComponent();
            YesterdayRecordInit();
            TodaydayRecordInit();
            
        }

        private void TraceForm_Load(object sender, EventArgs e)
        {
           
            FormInit(TimeLine1, yesterday);
            FormInit(TimeLine2, today);
            FormInit(TimeLine3, tomorrow);
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
            TimeLine3.Items = temps.ToArray();
        }

        private void FormInit(UCTimeLine timeLine, List<string> record )
        {
            List<Word> words = new List<Word>();
            List<TimeLineItem> temps = new List<TimeLineItem>();
            foreach (string reco in record)
            {
                TimeLineItem temp = new TimeLineItem();
                Word word = manager.getWord(reco);
                temp.Details = word.Mean_cn + "\r\n" + word.Mean_en + "\r\n" + word.Sentence;
                temp.Title = word.word;
                temps.Add(temp);
            }
            timeLine.Items = temps.ToArray();
            
        }

        private void YesterdayListConvert(List<Node> saved)
        {
            foreach(Node node in saved)
            {
                yesterday.Add(node.Data.word);
            }
        }

        private void TimeLine1_Load(object sender, EventArgs e)
        {

        }

        private void TraceForm_Shown(object sender, EventArgs e)
        {
            
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