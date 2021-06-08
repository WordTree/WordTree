using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;

namespace Reader
{
    class Paragraph
    {   
        public string ParagraphName { get; set; }//文段名称
        public List<Word> KeyWords { get; set; }// 重点单词
        public Word SelectedWord { get; set; }// 被选中的词
        public string content { get; set; }// 文段内容

        public Paragraph(string name)
        {
            ParagraphName = name;
        }
        public Paragraph(){}
    }
}
