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
<<<<<<< HEAD

=======
>>>>>>> a40cdf441226c397075407ff28c85481a27f4de7
        public SearchForm searchForm = new SearchForm();
        public ReaderForm readerForm = new ReaderForm();
        public MemoryForm memoryForm = new MemoryForm();
        public TransferController transferController = TransferController.GetController();

        TreeNode dictNode = new TreeNode("         词典");
        TreeNode statNode = new TreeNode("         统计");
        TreeNode readNode = new TreeNode("         阅读");
        TreeNode mryNode = new TreeNode("         记忆");
        public TrialMain()
        {
            InitializeComponent();
            Console.WriteLine(this.panControl.Size.Width);
            Console.WriteLine(this.panControl.Size.Height);
        }


        private void TrialMain_Load(object sender, EventArgs e)
        {
            

            readNode.Nodes.Add("    CET4");
            readNode.Nodes.Add("    CET6");
            readNode.Nodes.Add("    TOEFL");
            readNode.Nodes.Add("    IELTS");


            this.tvMenu.Nodes.Add(dictNode);
            this.tvMenu.Nodes.Add(statNode);
            this.tvMenu.Nodes.Add(mryNode);
            this.tvMenu.Nodes.Add(readNode);

            
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
<<<<<<< HEAD
=======
                    memoryForm.Memory(null, null);
                    break;
                case "CET4":
                    transferController.Transfer(panControl, new ReaderForm("CET4"));
                    break;
                case "CET6":
                    transferController.Transfer(panControl, new ReaderForm("CET6"));
                    break;
                case "TOEFL":
                    transferController.Transfer(panControl, new ReaderForm("TOEFL"));
                    break;
                case "IELTS":
                    transferController.Transfer(panControl, new ReaderForm("IELTS"));
>>>>>>> a40cdf441226c397075407ff28c85481a27f4de7
                    break;
            }
        }

        private void tvMenu_AfterExpand(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
