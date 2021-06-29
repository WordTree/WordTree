using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTree.Model
{
    /// <summary>
    /// 记录词库单词是否加入计划
    /// </summary>
    public class DictionaryWord
    {
        [Key]
        public string WordStr { get; set; }
        public bool IsAdd { get;set; }
        public DateTime Time { get; set; }

        public DictionaryWord()
        {

        }

        public DictionaryWord(string wordStr, bool isAdd,DateTime dateTime)
        {
            WordStr = wordStr;
            IsAdd = isAdd;
            Time = dateTime;
        }

        public override bool Equals(object obj)
        {
            return obj is DictionaryWord word &&
                   WordStr == word.WordStr;
        }

        public override int GetHashCode()
        {
            return 1081271672 + EqualityComparer<string>.Default.GetHashCode(WordStr);
        }
    }
}
