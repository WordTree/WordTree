using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader
{
    public delegate void GetChoice(string choice);
    public delegate void Tracecommand();
    public partial class UserTextChoice :  Form
    {
        ParagraphManager manager = new ParagraphManager();
        List<string> userchoices = new List<string>();

        private GetChoice choice;
        private Tracecommand trace;
        public UserTextChoice(GetChoice Setpara, Tracecommand command)
        {
            InitializeComponent();
            userchoices = manager.GetAllParagraghNames();
            choice_comboBox_Searcher.Items.AddRange(userchoices.ToArray());
            choice = Setpara;
            trace = command;
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            choice(choice_comboBox_Searcher.Text);
            trace();
            this.Close();
        }

        private void choice_comboBox_Searcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice_comboBox_Searcher.Text = (string)choice_comboBox_Searcher.SelectedItem;
            
        }
    }
}
