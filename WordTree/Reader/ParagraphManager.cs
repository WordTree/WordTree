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
            StreamReader stream = new StreamReader("..\\..\\..\\Reader\\Text\\" + p.ParagraphName + ".txt", Encoding.GetEncoding("UTF-8"));
            p.content = stream.ReadToEnd();
            stream.Close();
        }
        /// <summary>
        /// 获得本地段落名称列表
        /// </summary>
        public List<string > GetAllParagraghNames()
        {
            var files = Directory.GetFiles("..\\..\\..\\Reader\\Text\\", "*.txt").ToList();
            List<string> names = new List<string>();
            foreach( string name in files)
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
            foreach (string target in targets) {
                List<int> list = GetIndexArray(textbox.Text, target);
                for (int i = 0; i < list.Count; i++)
                {
                    int index = (int)list[i];
                    textbox.Select(index, target.Length);
                    textbox.SelectionColor = Color.Red;
           
                } 
            }
        }

        /// <summary>
        /// 查询关键字位置
        /// </summary>
        public List<int> GetIndexArray(String textbox_text, String targetstr)
        {
            List<int> list = new List<int>();
            int start = 0;
            while (start < textbox_text.Length)
            {
                int index = textbox_text.IndexOf(targetstr, start);
                if (index >= 0)
                {
                    list.Add(index);
                    start = index + targetstr.Length;
                }
                else
                {
                    break;
                }
            }
            return list;
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
                if(selectedline[i] == ' '|| (int)selectedline[i] > 122 || (int)selectedline[i] < 65)//根据空格和标点选出单词
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
