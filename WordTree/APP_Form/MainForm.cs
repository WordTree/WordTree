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
using Reader;

namespace APP_Form
{
    public partial class MainForm : Form
    {
        public SearchForm searchForm = new SearchForm();
        public ReaderForm readerForm = new ReaderForm();
        public MemoryForm memoryForm = new MemoryForm();
        public TransferController transferController = TransferController.GetController();
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 跳转至查词界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SearchTransfer_Click(object sender, EventArgs e)
        {
            transferController.Transfer(panel_Form,searchForm);
        }
        /// <summary>
        /// 跳转到阅读界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ReadingTransfer_Click(object sender, EventArgs e)
        {
            transferController.Transfer(panel_Form, readerForm);
        }

        private void button_MemoryTransfer_Click(object sender, EventArgs e)
        {
            transferController.Transfer(panel_Form, memoryForm);
        }
    }
}
