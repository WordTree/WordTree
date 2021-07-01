using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader
{
    class ParagraphManager
    {
        /// <summary>
        /// 段落类初始化，生成内容
        /// </summary>
        public void ContentInit(Paragraph p)
        {
            try
            {
                StreamReader stream = new StreamReader("..\\..\\..\\Reader\\Text\\" + p.ParagraphName + ".txt", Encoding.GetEncoding("UTF-8"));
                p.content = stream.ReadToEnd();
                stream.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获得本地段落名称列表
        /// </summary>
        public List<string > GetAllParagraghNames(string type)
        {
            
                var files = Directory.GetFiles($"..\\..\\..\\Reader\\Text\\{type}", "*.txt").ToList();
                List<string> names = new List<string>();
                foreach (string name in files)
                {
                    string generalpath = "..\\..\\..\\Reader\\Text\\";

                    string targetname = name.Replace(generalpath, "");
                    targetname = targetname.Substring(0, targetname.Length - 4);
                    names.Add(targetname);
                }
                return names;
           
        }
        /// <summary>
        /// 关键字标红
        /// </summary>
        public void ContentImpact(List<string> targets, RichTextBox textbox)
        {
            char[] textsearch = textbox.Text.ToCharArray();
            foreach (string target in targets) {
                List<int> list = GetIndexArray(textbox, target);
                for (int i = 0; i < list.Count; i++)
                {
                    int index = list[i];
                    textbox.Select(index, target.Length);
                    textbox.SelectionColor = Color.Red;
                } 
            }
        }

        /// <summary>
        /// 查询关键字位置
        /// </summary>
        public List<int> GetIndexArray(RichTextBox textbox, String targetstr)
        {

            List<int> list_position = new List<int>();
            int start = 0;
            char[] textsearch = textbox.Text.ToCharArray();
            while (start < textbox.Text.Length)
            {
                int index = textbox.Text.IndexOf(targetstr, start);
                if (index >= 0 && textsearch[index - 1] == ' ')
                {
                    list_position.Add(index);
                    start = index + targetstr.Length;
                }
                else
                {
                    break;
                }
            }
            return list_position;
        }
        /// <summary>
        /// 获取并处理被选中的单词
        /// </summary>
        public string SlectedStringScanner(RichTextBox richTextBox)
        {
            int start = richTextBox.SelectionStart;
            richTextBox.Select(start, 22);
            string selectedline = richTextBox.SelectedText;
            string selectedstring = null;
           
            for(int i=0; i<selectedline.Length; i++) 
            {
                if(selectedline[i] == ' '|| selectedline[i] > 122 || selectedline[i] < 65)//根据空格和标点选出单词
                {
                    selectedstring = selectedline.Substring(0, i);
                    richTextBox.Select(start, i);
                    break;
                }
            }
            return selectedstring;
        }

    }
}
