using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;

namespace APP_Form.Controller
{
    /// <summary>
    /// 用于保存记忆环节的相关控制信息，
    /// 以便再次打开时定位到原进度。
    /// </summary>
    [Serializable]
    public class MemoryInfo
    {
        public int count = 0;
        public int index = 0;
        public  List<Node> savedWords = new List<Node>(); 
        public  WordLinkedList changingWords = new WordLinkedList();
        public DateTime updateTime;
        public List<string> falsedWords = new List<string>();
        public MemoryInfo()
        {

        }
        public MemoryInfo(int count,int index, List<Node> savedWords, WordLinkedList changingWords,List<string> falsedWords)
        {
            this.count = count;
            this.index = index;
            this.savedWords = savedWords;
            this.changingWords = changingWords;
            this.falsedWords = falsedWords;
            this.updateTime = System.DateTime.Now;
        }
        
        public bool IsAvailable()
        {
            return updateTime.DayOfYear == System.DateTime.Now.DayOfYear;
        }
    }
}
