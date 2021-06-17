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
        //public SearchForm searchForm = new SearchForm();
        //public ReaderForm readerForm = new ReaderForm();
        //public MemoryForm memoryForm = new MemoryForm();
        //public TransferController transferController = TransferController.GetController();
        /// <summary>
        /// 存放界面上所有的按钮
        /// </summary>
        private List<Button> buttons = new List<Button>();

        public MainForm()
        {
            InitializeComponent();
            InitButtonList();

        }

        /// <summary>
        /// 跳转至查词界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SearchTransfer_Click(object sender, EventArgs e)
        {
            GetFocus(button_SearchTransfer);
            //transferController.Transfer(panel_Form, searchForm);

        }
        /// <summary>
        /// 跳转到阅读界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ReadingTransfer_Click(object sender, EventArgs e)
        {
            GetFocus(button_ReadingTransfer);
            //transferController.Transfer(panel_Form, readerForm);
        }

        private void button_MemoryTransfer_Click(object sender, EventArgs e)
        {
            GetFocus(button_MemoryTransfer);
            //transferController.Transfer(panel_Form, memoryForm);
        }

        private void button_HistoryTransfer_Click(object sender, EventArgs e)
        {
            GetFocus(button_HistoryTransfer);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 设置选中按钮的颜色，并将其他按钮颜色设为默认
        /// </summary>
        /// <param name="button"></param>
        private void GetFocus(Button button)
        {
            button.BackColor = ColorTranslator.FromHtml("#FFE4E1");
            button.ForeColor = ColorTranslator.FromHtml("#F5FFFA");
            foreach(var butt in buttons)
            {
                if(butt != button)
                {
                    butt.BackColor = System.Drawing.Color.Gainsboro;
                    butt.ForeColor = System.Drawing.Color.DimGray;
                }
            }
        }
        /// <summary>
        /// Init buttons
        /// </summary>
        private void InitButtonList()
        {
            buttons.Add(button_HistoryTransfer);
            buttons.Add(button_MemoryTransfer);
            buttons.Add(button_ReadingTransfer);
            buttons.Add(button_SearchTransfer);
        }

    }
}
