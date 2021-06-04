using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;

namespace WordTree
{
    /// <summary>
    /// 单例类 负责管理目标词库和单词读取
    /// </summary>
    class WordAndDicManager
    {
        private static WordAndDicManager instance = new WordAndDicManager();

        public VocabularyDic targetDic;

        private WordAndDicManager() {
            targetDic = new VocabularyDic();
        }
        
        public static WordAndDicManager getInstance()
        {
            return instance;
        }

        /// <summary>
        /// 初始化目标词库
        /// </summary>
        /// <param name="dicName"></param>
        public void init(string dicName)
        {
            string dicInfo = File.ReadAllText("..\\..\\Words\\VocabularyDic\\" + dicName + ".json");
            targetDic = JsonConvert.DeserializeObject<VocabularyDic>(dicInfo);

            targetDic.Name = dicName;
        }
        
        /// <summary>
        /// 更换目标词库
        /// </summary>
        /// <param name="dicName"></param>
        public void changeTargetDic(string dicName)
        {
            if (dicName == targetDic.Name)
                throw  new ApplicationException("目标词库已经是该词库");
            init(dicName);

        }

        /// <summary>
        /// 根据单词名获取单词对象
        /// </summary>
        /// <param name="wordStr"></param>
        /// <returns></returns>
        public Word getWord(string wordStr)
        {
            string voicPath = "..\\..\\Voice\\" + wordStr + ".mp3";
            //如果本地不存在对应单词音频则爬取对应单词的音频
            if (!File.Exists(voicPath))
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string url = "http://dict.youdao.com/dictvoice?type=1&audio=" + wordStr;
                Task<byte[]> downloadTask = Task.Run(() => webClient.DownloadData(url));
                byte[] result = downloadTask.Result;
                Task writeFileTask = Task.Run(() => File.WriteAllBytes(voicPath, result));
            }
            string wordInfo = File.ReadAllText("..\\..\\Words\\"+wordStr+".json");
            Word target = JsonConvert.DeserializeObject<Word>(wordInfo);
            target.VoicePath = voicPath;
            return target;
        }
    }
}
