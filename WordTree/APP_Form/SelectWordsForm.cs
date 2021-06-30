using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree.Model;
using WordTree.Service;

namespace APP_Form
{
    public delegate void SetRecord();
    public partial class SelectWordsForm : Form
    {
        MmryPlanManager mmryPlanManager = new MmryPlanManager();
        int count = 0;
        public SetRecord set;

        public SelectWordsForm()
        {
            InitializeComponent();
        }

        private void SelectWordsForm_Load(object sender, EventArgs e)
        {
            DataGridViewColumnEntity[] lstLeftCulumns = new DataGridViewColumnEntity[1];
            lstLeftCulumns[0] = new DataGridViewColumnEntity() { DataField = "Value", HeadText = "建议单词", TextAlign = ContentAlignment.MiddleLeft};

            DataGridViewColumnEntity[] lstRightCulumns = new DataGridViewColumnEntity[1];
            lstRightCulumns[0] = new DataGridViewColumnEntity() { DataField = "Value", HeadText = "已选单词", TextAlign = ContentAlignment.MiddleLeft};

            this.ucTsfWords.LeftColumns = lstLeftCulumns;
            this.ucTsfWords.RightColumns = lstRightCulumns;

            getRecommendedWords();

        }
        /// <summary>
        /// 获取50个未加入计划的单词
        /// </summary>
        private void getRecommendedWords()
        {
            var lstItems = new WordModel[50];
            var lstWords = mmryPlanManager.QueryDicWordLimit50(count);
            count += 50;

            for (int i = 0; i < 50; i++)
            {
                lstItems[i] = new WordModel() { Key = i, Value = lstWords[i].WordStr };
            }

            ucTsfWords.LeftDataSource = lstItems;
            ucTsfWords.RightDataSource = new List<WordModel>().ToArray();
        }

       class WordModel
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }

        private void btnNext_BtnClick(object sender, EventArgs e)
        {
            getRecommendedWords();
        }

        private async void btnAffirm_BtnClick(object sender, EventArgs e)
        {
            if(ucTsfWords.RightDataSource.Length == 0)
            {
                return;
            }
            List<string> traceRecord = new List<string>();
            foreach(WordModel word in ucTsfWords.RightDataSource)
            {
                mmryPlanManager.AddPlan(word.Value);

                traceRecord.Add(word.Value);
            }
            FrmDialog.ShowDialog(this, "添加成功！", "提示");
            var list = ucTsfWords.RightDataSource.ToList();
            list.Clear();
            ucTsfWords.RightDataSource = list.ToArray();
            string path = "..\\..\\..\\StatTracer\\Record\\temp\\tinfo.json";
            if (ucTsfWords.LeftDataSource.Length == 0)
            {
                getRecommendedWords();
            }
            //异步写入Record统计文件
            await Task.Run(()=>
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(traceRecord));
                set();
            });
            
        }

        private void btnCancel_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
