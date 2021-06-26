using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTree.Service;

namespace APP_Form
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrialMain());

            //WordAndDicManager wordAndDicManager = WordAndDicManager.getInstance();
            //WordTree.Model.Word word = wordAndDicManager.getWord("access");
            //SpellingCheckForm spellingCheckForm = new SpellingCheckForm(word);
            //spellingCheckForm.SetValue(word);
            //Application.Run(spellingCheckForm);

            //WordTree.Model.Word word1 = wordAndDicManager.getWord("adorn");
            //WordTree.Model.Word word2 = wordAndDicManager.getWord("signal");
            //WordTree.Model.Word word3 = wordAndDicManager.getWord("intention");
            //Application.Run(new ExplanationCheckForm(word, word1, word2, word3));

        }
    }
}
