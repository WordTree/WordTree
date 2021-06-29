using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;
using WordTree.Service;

namespace WordTree
{
    class Program
    {
        static void Main(string[] args)
        {
            WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
            //wordAndDicManager.changeTargetDic("CET4");
            //Console.WriteLine(wordAndDicManager.targetDic);
            //Word word = wordAndDicManager.getWord("crucial");
            //Console.WriteLine(word);
            MmryPlanManager mmryPlanManager = new MmryPlanManager();
            //mmryPlanManager.ClearAll();
            mmryPlanManager.AddPlan("access");
            mmryPlanManager.AddPlan("project");
            mmryPlanManager.AddPlan("intention");
            mmryPlanManager.AddPlan("negotiate");
            mmryPlanManager.AddPlan("strategy");
            mmryPlanManager.AddPlan("primary");
            mmryPlanManager.AddPlan("obstacle");
            mmryPlanManager.AddPlan("signal");
            mmryPlanManager.AddPlan("plague");
            mmryPlanManager.AddPlan("psychological");
            mmryPlanManager.AddPlan("senior");
            mmryPlanManager.AddPlan("crucial");
            mmryPlanManager.AddPlan("flaw");
            mmryPlanManager.AddPlan("individual");
            mmryPlanManager.AddPlan("contemporary");
            mmryPlanManager.AddPlan("specialize");
            mmryPlanManager.AddPlan("philosopher");
            mmryPlanManager.AddPlan("scholarship");
            mmryPlanManager.AddPlan("fiction");
            mmryPlanManager.AddPlan("depressed");
        }

        public static int[] GetRandomSequence(int[] array, int count)
        {
            int[] output = new int[count];
            Random rd = new Random();
            for (int i = array.Length - 1; i >= 0 && count > 0; i--)
            {
                if (rd.Next(0, i + 1) < count)//概率是 剩余取数长度/总数组剩余的长度
                {
                    output[count - 1] = array[i];//output从最后一位开始往前存
                    count--;
                }
            }
            return output;
        }
        public static void Shuffle(int[] array)
        {
            Random random = new Random();
            int target = 0;
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                target = random.Next(0, array.Length);
                temp = array[i];
                array[i] = array[target];
                array[target] = temp;
            }
        }
    }
}
