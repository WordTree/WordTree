
namespace APP_Form
{
    partial class TrialMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrialMain));
            this.tvMenu = new HZH_Controls.Controls.TreeViewEx();
            this.panControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvMenu.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.IsShowByCustomModel = true;
            this.tvMenu.IsShowTip = false;
            this.tvMenu.ItemHeight = 70;
            this.tvMenu.Location = new System.Drawing.Point(0, 61);
            this.tvMenu.LstTips = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("tvMenu.LstTips")));
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.tvMenu.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeDownPic")));
            this.tvMenu.NodeForeColor = System.Drawing.Color.White;
            this.tvMenu.NodeHeight = 70;
            this.tvMenu.NodeIsShowSplitLine = true;
            this.tvMenu.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tvMenu.NodeSelectedForeColor = System.Drawing.Color.White;
            this.tvMenu.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tvMenu.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeUpPic")));
            this.tvMenu.ParentNodeCanSelect = true;
            this.tvMenu.ShowLines = false;
            this.tvMenu.ShowPlusMinus = false;
            this.tvMenu.ShowRootLines = false;
            this.tvMenu.Size = new System.Drawing.Size(283, 637);
            this.tvMenu.TabIndex = 8;
            this.tvMenu.TipFont = new System.Drawing.Font("新宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMenu.TipImage = ((System.Drawing.Image)(resources.GetObject("tvMenu.TipImage")));
            this.tvMenu.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterExpand);
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // panControl
            // 
            this.panControl.AutoScroll = true;
            this.panControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControl.Location = new System.Drawing.Point(283, 61);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(736, 637);
            this.panControl.TabIndex = 10;
            // 
            // TrialMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 698);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.tvMenu);
            this.IsShowCloseBtn = true;
            this.Name = "TrialMain";
            this.ShowInTaskbar = true;
            this.Text = "TrialMain";
            this.Load += new System.EventHandler(this.TrialMain_Load);
            this.Controls.SetChildIndex(this.tvMenu, 0);
            this.Controls.SetChildIndex(this.panControl, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.TreeViewEx tvMenu;
        private System.Windows.Forms.Panel panControl;
    }
}