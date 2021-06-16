using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTree.Model
{
    /// <summary>
    /// 计划记忆的单词
    /// </summary>
    public class PlannedWord
    {
        [Key]
        public string Wordstr { get; set; }   
        public DateTime LastMmryTime { get; set; }
        public int Phase { get; set; }
        public PlannedWord()
        {

        }
        public PlannedWord(string wordstr, DateTime lastMmryTime, int phase)
        {
            Wordstr = wordstr;
            LastMmryTime = lastMmryTime;
            Phase = phase;
        }

        public override bool Equals(object obj)
        {
            return obj is PlannedWord word &&
                   Wordstr == word.Wordstr;
        }

        public override int GetHashCode()
        {
            return -1497828904 + EqualityComparer<string>.Default.GetHashCode(Wordstr);
        }
    }
}
