using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Form.Controller
{
    /// <summary>
    /// 操控主界面的跳转
    /// </summary>
    public class TransferController
    {
        /// <summary>
        /// 单例对象
        /// </summary>
        private static TransferController controller = new TransferController();
        /// <summary>
        /// 获取单例对象
        /// </summary>
        /// <returns>控制界面跳转的单例对象</returns>
        public static TransferController GetController()
        {
            return controller;
        }
        /// <summary>
        /// 在Panel上显示指定的窗口内容
        /// </summary>
        /// <param name="panel">目标Panel</param>
        /// <param name="form">目标窗口</param>
        public void Transfer(Panel panel,Form form)
        {
            panel.Controls.Clear();
            //调整可见级
            form.TopLevel = false;
            //调整Dock风格
            form.Dock = DockStyle.Top;
            //去除边框
            form.FormBorderStyle = FormBorderStyle.None;

            panel.Controls.Add(form);
            form.Show();
        }
    }
}
