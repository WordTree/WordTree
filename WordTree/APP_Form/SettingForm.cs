using HZH_Controls.Forms;
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
    public delegate void SetType(string selectedtype);
    public partial class SettingForm : FrmWithTitle
    {
        public SetType setType;
        WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
        MemoryManager memoryManager = MemoryManager.getInstance();

        public event Action<char, List<string>> updateRecord;

        public SettingForm() 
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            
            KeyValuePair<string, string>[] keyValuePairs = {new KeyValuePair<string, string>("0","CET4"),
                                                          new KeyValuePair<string, string>("1","CET6"),
                                                          new KeyValuePair<string, string>("2","TOEFL"),
                                                          new KeyValuePair<string, string>("3","IELTS"),
                                                          new KeyValuePair<string, string>("4","GRE"),
                                                          new KeyValuePair<string, string>("5","SAT")};
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>(keyValuePairs);
            cmbTargetDic.Source = list;
            ntbNeedNum.Num = UserDefault.Default.NeedNum;//显示当前设置
            if (UserDefault.Default.TargetDic != "")
            {
                cmbTargetDic.SelectedIndex = Convert.ToInt32(list.First(o => o.Value == UserDefault.Default.TargetDic).Key);
            }
        }

        private void btnAffrim_BtnClick(object sender, EventArgs e)
        {
            try
            {
                wordAndDicManager.changeTargetDic(cmbTargetDic.SelectedText);
                UserDefault.Default.TargetDic = cmbTargetDic.SelectedText;
                memoryManager.NeedNum = (int)ntbNeedNum.Num;
                UserDefault.Default.NeedNum = (int)ntbNeedNum.Num;
                if (FrmDialog.ShowDialog(this, "设置成功！", "提示") == DialogResult.OK) {
                    setType(cmbTargetDic.SelectedText);
                    updateRecord('a', TakeRecord(memoryManager.NeedWord));
                    this.Close();
                }
            }catch(ApplicationException ex)
            {
                memoryManager.NeedNum = (int)ntbNeedNum.Num;
                if (FrmDialog.ShowDialog(this, "设置成功！", "提示") == DialogResult.OK)
                {
                    this.Close();
                }
            }
            UserDefault.Default.Save();
        }

        private List<string> TakeRecord(PlannedWord[] NeedWords)
        {
            List<string> records = new List<string>();
            for (int i = 0; i < memoryManager.NeedNum; i++)
            {
                records.Add(NeedWords[i].Wordstr);
            }
            return records;
        }
    }
}
