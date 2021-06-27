using HZH_Controls.Controls;
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
    public partial class SelectWordsForm : Form
    {
        //WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();

        public SelectWordsForm()
        {
            InitializeComponent();
            //wordAndDicManager.init("CET4");
        }

        private void ucTsfWords_Transfered(object sender, HZH_Controls.Controls.TransferEventArgs e)
        {


        }

        private void SelectWordsForm_Load(object sender, EventArgs e)
        {
            DataGridViewColumnEntity[] lstLeftCulumns = new DataGridViewColumnEntity[1];
            lstLeftCulumns[0] = new DataGridViewColumnEntity() { DataField = "Value", HeadText = "建议单词", TextAlign = ContentAlignment.MiddleCenter };

            DataGridViewColumnEntity[] lstRightCulumns = new DataGridViewColumnEntity[1];
            lstRightCulumns[0] = new DataGridViewColumnEntity() { DataField = "Value", HeadText = "已选单词", TextAlign = ContentAlignment.MiddleLeft };

            this.ucTsfWords.LeftColumns = lstLeftCulumns;
            this.ucTsfWords.RightColumns = lstRightCulumns;

            string[] lst = {"access","depressed","apple","banana","cat" };

            var lstItems = new WordModel[5];

            for(int i = 0; i<5; i++)
            {
                lstItems[i] = new WordModel() { Key = i, Value = lst[i] };
            }

            ucTsfWords.LeftDataSource = lstItems;
            ucTsfWords.RightDataSource = new List<WordModel>().ToArray();

        }

        public class WordModel
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }
    }
}
