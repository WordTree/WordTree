using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;

namespace WordTree.Service
{
    public class MemoryManager
    {
		WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
		private MmryPlanManger mmryPlanManger = new MmryPlanManger();
		/// <summary>
		/// 用户设定的每次记忆单词量
		/// </summary>
		public int NeedNum { get; set; }

		public PlannedWord[] NeedWord;

		//去掉5分钟和30分钟这个短时记忆周期
		static TimeSpan[] memoryCycle = {
			new TimeSpan(12,0,0),	// 12小时 
			new TimeSpan(1,0,0,0),	// 1天
			new TimeSpan(2,0,0,0),	// 2天 
			new TimeSpan(4,0,0,0),	// 4天 
			new TimeSpan(7,0,0,0),	// 7天 
			new TimeSpan(15,0,0,0)	// 15天
		};
		
		public bool NeedRecite(PlannedWord target)
		{
			if (target.Phase == -1)
				return true;
			if (target.Phase >= memoryCycle.Length)
			{
				return false;
			}
			DateTime currentTime = DateTime.Now;
			TimeSpan timeDiff = currentTime - target.LastMmryTime;

			return timeDiff > memoryCycle[target.Phase];
		}

		public MemoryManager()
        {
			List <PlannedWord> words = new MmryPlanManger().QueryAll();
			var targetWords = words.Where(o => NeedRecite(o));
			NeedWord = targetWords.ToArray();

        }

		public WordLinkedList GetNextWords(int count)
		{
			if (count >= NeedNum)
			{
				throw new ApplicationException("已达成目标");
			}
			WordLinkedList wordLinkedList = new WordLinkedList();
			for (int i = count; i < count + 10; i++)
			{

				Word newWord = wordAndDicManager.getWord(NeedWord[i].Wordstr);
				wordLinkedList.Add(newWord);
			}
			return wordLinkedList;

		}

		public void CompleteMmry(Word word)
		{
			var target = NeedWord.SingleOrDefault(w => w.Wordstr == word.word);
			target.Phase++;
			target.LastMmryTime = DateTime.Now;
			mmryPlanManger.UpdatePlan(target);
		}



	}
}
