using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WordTree.Model;

namespace WordTree.Service
{
    /// <summary>
    /// 单例类 负责管理目标词库和单词读取
    /// </summary>
    public class WordAndDicManager
    {
        private static WordAndDicManager instance = new WordAndDicManager();

        private MmryPlanManager mmryPlanManger = new MmryPlanManager();

        public VocabularyDic targetDic;  //目标词库

        private WordAndDicManager() {
            targetDic = new VocabularyDic();
        }
        
        public static WordAndDicManager getInstance()
        {
            return instance;
        }

        /// <summary>
        /// 初始化目标词库 （不再是初始化就把目标词库的单词全部录入数据库)
        /// </summary>
        /// <param name="dicName"></param>
        public async void init(string dicName)
        {
            string dicInfo = File.ReadAllText("..\\..\\..\\WordTree\\Words\\VocabularyDic\\" + dicName + ".json");
            targetDic = JsonConvert.DeserializeObject<VocabularyDic>(dicInfo);
            targetDic.Name = dicName;

            ////将目标词库中所有单词加入计划
            //await Task.Run(() =>
            //{
            //    foreach (string wordStr in targetDic.List)
            //    {
            //        try
            //        {
            //            mmryPlanManger.AddPlan(wordStr);
            //        }
            //        catch (ApplicationException e)
            //        {
            //            continue;
            //        }
            //    }
            //});
        }

        /// <summary>
        /// 更换目标词库
        /// </summary>
        /// <param name="dicName"></param>
        public async void changeTargetDic(string dicName)
        {
            //if (dicName == targetDic.Name)
            //    throw new ApplicationException("目标词库已经是该词库");

            ////清空计划，重新设置目标词库
            //await Task.Run(() => mmryPlanManger.ClearAll());
            //init(dicName);
        }

        /// <summary>
        /// 根据单词名获取单词对象
        /// </summary>
        /// <param name="wordStr"></param>
        /// <returns></returns>
        public Word getWord(string wordStr)
        {
            string wordInfo = File.ReadAllText("..\\..\\..\\WordTree\\Words\\" + wordStr+".json");
            Word target = JsonConvert.DeserializeObject<Word>(wordInfo);
            string pictureInfo = File.ReadAllText("..\\..\\..\\WordTree\\Words\\VocabularyDic\\单词图片.json");
            string filter = @"http.*"+wordStr+"_.*png";
            var pictureUrl = Regex.Match(pictureInfo, filter);
            target.Picture = pictureUrl.Value;
            return target;
        }

        public VocabularyDic getVocabularyDic(string dicName)
        {
            string dicInfo = File.ReadAllText("..\\..\\..\\WordTree\\Words\\VocabularyDic\\" + dicName + ".json");
            targetDic = JsonConvert.DeserializeObject<VocabularyDic>(dicInfo);
            return targetDic;
        }
    }
}
