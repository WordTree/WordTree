using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TEST
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string apiResult = webClient.DownloadString(@"http://open.iciba.com/dsapi/");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, object> json = (Dictionary<string, object>)serializer.DeserializeObject(apiResult); ;
            object content;
            object note;
            object picture;
            json.TryGetValue("content", out content);
            json.TryGetValue("note", out note);
            json.TryGetValue("picture2", out picture);
            label1.Text = content.ToString();
            label2.Text = note.ToString();
            var webC = new System.Net.WebClient();
            var bmp = new Bitmap(webC.OpenRead(picture.ToString()));
            pictureBox1.Image = bmp;
        }
    }
}
