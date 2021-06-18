using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader
{
    public delegate void GetChoice(string choice);
    public delegate void Tracecommand();
    class TypeControl
    {
            ParagraphManager manager = new ParagraphManager();
            List<string> userchoices = new List<string>();

            private GetChoice choice;
            private Tracecommand trace;
            public TypeControl(GetChoice Setpara, Tracecommand command, string type)
            {
                userchoices = manager.GetAllParagraghNames(type);
                choice = Setpara;
                trace = command;
            }
        }
}
