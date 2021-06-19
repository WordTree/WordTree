using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_Form.Controller;
using HZH_Controls.Forms;
using Reader;

namespace APP_Form
{
    public partial class TrialMain : FrmWithTitle
    {

        public SearchForm searchForm = new SearchForm();
        public ReaderForm readerForm = new ReaderForm();
        public MemoryForm memoryForm = new MemoryForm();
        public TransferController transferController = TransferController.GetController();
        public TrialMain()
        {
            InitializeComponent();
            Console.WriteLine(this.panControl.Size.Width);
            Console.WriteLine(this.panControl.Size.Height);
        }


        private void TrialMain_Load(object sender, EventArgs e)
        {
            TreeNode dictNode = new TreeNode("         词典");
            TreeNode statNode = new TreeNode("         统计");
            TreeNode readNode = new TreeNode("         阅读");
            TreeNode mryNode = new TreeNode("         记忆");

            readNode.Nodes.Add("四级真题");
            readNode.Nodes.Add("四级材料");
            readNode.Nodes.Add("六级真题");
            readNode.Nodes.Add("六级材料");


            this.tvMenu.Nodes.Add(dictNode);
            this.tvMenu.Nodes.Add(statNode);
            this.tvMenu.Nodes.Add(readNode);
            this.tvMenu.Nodes.Add(mryNode);
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panControl.Controls.Clear();
            string strName = e.Node.Text.Trim();
            this.Title = strName;
            switch (strName)
            {
                case "词典":
                    transferController.Transfer(panControl, searchForm);
                    break;
                case "统计":
                    transferController.Transfer(panControl, searchForm);
                    break;
                case "阅读":
                    transferController.Transfer(panControl, readerForm);
                    break;
                case "记忆":
                    transferController.Transfer(panControl, memoryForm);
                    break;
            }
        }
    }
}
