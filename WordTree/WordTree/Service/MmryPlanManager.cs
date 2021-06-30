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
    public class MmryPlanManager
    {
        /// <summary>
        /// 增加计划记录
        /// </summary>
        /// <param name="wordStr"></param>
        public void AddPlan(string wordStr)
        {
            PlannedWord plannedWord = new PlannedWord(wordStr, DateTime.Now, -1);
            using (var ctx = new PlannedWordContext())
            {
                if (ctx.PlannedWords.Where(o => o.Wordstr == wordStr).Any())
                {
                    throw new ApplicationException("该单词已经在计划中");
                }
                ctx.PlannedWords.Add(plannedWord);
                ctx.SaveChanges();
                var target = ctx.DictionaryWords.SingleOrDefault(w => w.WordStr == wordStr);
                if (target != null)
                {
                    target.IsAdd = true;
                    ctx.SaveChanges();
                }

                //Console.WriteLine("Successfully add!");
            }
        }

        /// <summary>
        /// 清空计划
        /// </summary>
        public void ClearAllPlan()
        {
            using (var ctx = new PlannedWordContext())
            {
                var list = ctx.PlannedWords.ToList();
                ctx.PlannedWords.RemoveRange(list);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 删除计划
        /// </summary>
        /// <param name="wordStr"></param>
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

        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="plannedWord"></param>
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

        /// <summary>
        /// 按上次记忆时间查询所有记录
        /// </summary>
        /// <returns></returns>
        public List<PlannedWord> QueryAllPlan()
        {
            using(var ctx = new PlannedWordContext())
            {
                return ctx.PlannedWords.OrderBy(o=>o.LastMmryTime).ToList();
            }
        }

        /// <summary>
        /// 按单词查询记录
        /// </summary>
        /// <param name="wordStr"></param>
        /// <returns></returns>
        public bool IsExist(string wordStr)
        {
            using(var ctx = new PlannedWordContext())
            {
                return ctx.PlannedWords.Where(o => o.Wordstr == wordStr).Any();               
            }
        }

        /// <summary>
        /// 将目标词库单词加入数据库
        /// </summary>
        /// <param name="wordStr"></param>
        public void AddDicWord(string wordStr)
        {
            DictionaryWord dictionaryWord = new DictionaryWord(wordStr, false,DateTime.Now);
            using (var ctx = new PlannedWordContext())
            {
                if(ctx.PlannedWords.Where(w=>w.Wordstr == wordStr).Any())
                {
                    dictionaryWord.IsAdd = true;
                }
                ctx.DictionaryWords.Add(dictionaryWord);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 分页查询50个未加入记忆计划的单词
        /// </summary>
        public DictionaryWord[] QueryDicWordLimit50(int count)
        {
            using(var ctx = new PlannedWordContext())
            {
                var words = ctx.DictionaryWords.Where(w => w.IsAdd == false).OrderBy(w=>w.Time).Skip(count).Take(50);
                return words.ToArray();
            }
        }

        public void ClearDic()
        {
            using (var ctx = new PlannedWordContext())
            {
                var list = ctx.DictionaryWords.ToList();
                ctx.DictionaryWords.RemoveRange(list);
                ctx.SaveChanges();
            }
        }

    }
}
