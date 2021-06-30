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
    public partial class WordInfoForm : Form
    {
        private Word targetWord;
        private MmryPlanManager mmryplanmanager = new MmryPlanManager();
        private bool isPlannedWord;

        public WordInfoForm(Word targetWord)
        {
            this.targetWord = targetWord;
            InitializeComponent();
            InitWordInfo();
            this.AcceptButton = button_enter;
            this.button_enter.Enabled = false;
            InitPic();

        }

        private void button_Voice_Click(object sender, EventArgs e)
        {
            VoicePlayer.Ctlcontrols.play();
        }

        private void ucBtnExt_Next_BtnClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Add_BtnClick(object sender, EventArgs e)
        {
            try
            {
                mmryplanmanager.AddPlan(targetWord.word);
            }catch(Exception ex)
            {

            }
        }
        /// <summary>
        /// 用于设置单词的相关信息
        /// </summary>
        private void InitWordInfo()
        {
            label_Word.Text = targetWord.word;
            lblAccent.Text = targetWord.Accent;
            rtbWordInfo.AppendText(targetWord.Mean_cn + "\n\n");
            rtbWordInfo.AppendText(targetWord.Mean_en + "\n\n");
            rtbWordInfo.AppendText(targetWord.Sentence + "\n");
            rtbWordInfo.AppendText(targetWord.Sentence_trans + "\n\n");
            rtbWordInfo.AppendText(targetWord.Sentence_phrase + "\n");
            rtbWordInfo.AppendText(targetWord.Word_etyma + "\n");

            VoicePlayer.URL = "http://dict.youdao.com/dictvoice?type=1&audio=" + targetWord.word;
            VoicePlayer.Ctlcontrols.play();
        }

        private void InitPic()
        {
            if (mmryplanmanager.IsExist(targetWord.word))
            {
                button_AddPlan.Image = Properties.Resources.已加入计划;
                isPlannedWord = true;
            }
            else
            {
                button_AddPlan.Image = Properties.Resources.未加入计划;
                isPlannedWord = false;
            }
        }

        public void button_AddPlan_Click(object sender, EventArgs e)
        {
            if(!isPlannedWord)
            {
                mmryplanmanager.AddPlan(targetWord.word);
                button_AddPlan.Image = Properties.Resources.已加入计划;
                isPlannedWord = true;
            }else
            {
                mmryplanmanager.DelPlan(targetWord.word);
                button_AddPlan.Image = Properties.Resources.未加入计划;
                isPlannedWord = false;
            }
            button_AddPlan.Refresh();
        }
    }
}
