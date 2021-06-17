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
    public partial class SettingForm : Form
    {
        WordAndDicManager wordAndDicManager;
        MemoryManager memoryManager;

        public SettingForm(WordAndDicManager wordAndDicManager,MemoryManager memoryManager) 
        {
            this.wordAndDicManager = wordAndDicManager;
            this.memoryManager = memoryManager;
            InitializeComponent();
        }

        private void btnAffirm_Click(object sender, EventArgs e)
        {
            wordAndDicManager.changeTargetDic(cmbTargetDic.SelectedItem.ToString());
            memoryManager.NeedNum = (int)nudNeedNum.Value;
            this.Close();

        }
    }
}
