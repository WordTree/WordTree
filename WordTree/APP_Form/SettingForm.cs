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
using WordTree.Service;

namespace APP_Form
{
    public partial class SettingForm : FrmWithTitle
    {
        WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
        MemoryManager memoryManager = MemoryManager.getInstance();

        public SettingForm() 
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            
            KeyValuePair<string, string>[] keyValuePairs = {new KeyValuePair<string, string>("1","CET4"),
                                                          new KeyValuePair<string, string>("2","CET6"),
                                                          new KeyValuePair<string, string>("3","TOEFL"),
                                                          new KeyValuePair<string, string>("4","IELTS"),
                                                          new KeyValuePair<string, string>("5","GRE"),
                                                          new KeyValuePair<string, string>("6","SAT")};
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>(keyValuePairs);
            cmbTargetDic.Source = list;
            ntbNeedNum.Num = UserDefault.Default.NeedNum;//显示当前设置
            cmbTargetDic.SelectedIndex = Convert.ToInt32(list.First(o => o.Value == UserDefault.Default.TargetDic).Key);
        }

        private void btnAffrim_BtnClick(object sender, EventArgs e)
        {
            try
            {
                //wordAndDicManager.changeTargetDic(cmbTargetDic.SelectedText);
                UserDefault.Default.TargetDic = cmbTargetDic.SelectedText;
                //memoryManager.NeedNum = (int)ntbNeedNum.Num;
                UserDefault.Default.NeedNum = (int)ntbNeedNum.Num;
                if (FrmDialog.ShowDialog(this, "设置成功！", "提示") == DialogResult.OK) {
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

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
