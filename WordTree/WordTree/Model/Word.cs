using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTree.Model
{
    /// <summary>
    /// 单词信息
    /// </summary>
    public class Word
    {
        public string word { get; set; } //单词名
        public string Accent { get; set; }  //音标
        public string Mean_cn { get; set; }  //中文释义
        public string Mean_en { get; set; }  //英文释义
        public string Sentence { get; set;}  //例句
        public string Sentence_trans { get; set; }  //例句翻译
        public string Sentence_phrase { get; set; }  //短语（可能为空）
        public string Word_etyma { get; set; }  //助记（可能为空）
        public string Picture { get; set; }

        //public string VoicePath{ get; set; }    //音频路径

        public bool Check(string answer)
        {
            return word.Equals(answer);
        }

        

        public override bool Equals(object obj)
        {
            return obj is Word word &&
                   this.word == word.word;
        }

        public override int GetHashCode()
        {
            return -1708164475 + EqualityComparer<string>.Default.GetHashCode(word);
        }

        

        override public string ToString()
        {
            return "word:" + word + "\naccent:" + Accent + "\nmean_cn:" + Mean_cn + "\nmean_en:" + Mean_en + "\nsentence:" + Sentence
                + "\nsentence_trans:" + Sentence_trans + "\nsentence_phrase:" + Sentence_phrase + "\nword_etyma:" + Word_etyma ;
        }

    }
}
