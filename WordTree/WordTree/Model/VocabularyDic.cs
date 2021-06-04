using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTree.Model
{
   
    /// <summary>
    /// 存储词库信息
    /// </summary>
    public class VocabularyDic
    {
        public string Name { get; set; }   //词库名
        public int Total { get; set; }    //词汇总数
        public string[] List { get; set; }  //单词列表

        public VocabularyDic()
        {

        }
        public VocabularyDic(string name)
        {
            Name = name;
            Total = 0;
            List = null;
           
        }

        public override string ToString()
        {
            return "name：" + Name + "\ntotal：" + Total;
        }
    }
}
