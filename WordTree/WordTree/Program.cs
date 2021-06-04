using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;

namespace WordTree
{
    class Program
    {
        static void Main(string[] args)
        {
            WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
            wordAndDicManager.changeTargetDic("CET4");
            Console.WriteLine(wordAndDicManager.targetDic);
            Word adorn = wordAndDicManager.getWord("surreptitious");
            Console.WriteLine(adorn);
            Console.ReadKey();
        }
    }
}
