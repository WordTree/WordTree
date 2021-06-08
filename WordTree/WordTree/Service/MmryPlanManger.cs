using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;

namespace WordTree.Service
{
    /// <summary>
    /// 管理单词计划，增删改查数据库
    /// </summary>
    class MmryPlanManger
    {
        public void AddPlan(Word word)
        {
            PlannedWord plannedWord = new PlannedWord(word.word,DateTime.Now,-1,3);
            using(var ctx  = new PlannedWordContext())
            {
                if (ctx.PlannedWords.Contains(plannedWord))
                    throw new ApplicationException("该单词已经在计划中");
                ctx.PlannedWords.Add(plannedWord);
                ctx.SaveChanges();
                
                Console.WriteLine("Successfully add!");
            }
        }

        public void DelPlan(string wordStr)
        {
            using(var ctx = new PlannedWordContext())
            {
                var targetWord = ctx.PlannedWords.SingleOrDefault(o => o.Wordstr == wordStr);

                if (targetWord == null)
                    throw new ApplicationException("该单词不在计划中");
                else
                {
                    ctx.PlannedWords.Remove(targetWord);
                    ctx.SaveChanges();
                }
                
            }
        }

        public void UpdatePlan(PlannedWord plannedWord)
        {
            if (plannedWord == null)
                throw new NullReferenceException("空记录");

            using(var ctx = new PlannedWordContext())
            {
                DelPlan(plannedWord.Wordstr);
                ctx.PlannedWords.Add(plannedWord);
                ctx.SaveChanges();
                
            }
        }
        public List<PlannedWord> QueryAll()
        {
            using(var ctx = new PlannedWordContext())
            {
                return ctx.PlannedWords.OrderBy(o=>o.Phase).ToList();
            }
        }

        public PlannedWord QueryByWordStr(string wordStr)
        {
            using(var ctx = new PlannedWordContext())
            {
                var targetWord = ctx.PlannedWords.SingleOrDefault(o => o.Wordstr == wordStr);

                if (targetWord == null)
                    throw new ApplicationException("该单词不在计划中");
                return targetWord;
            }
        }
        


    }
}
