
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
            this.btnSetting = new HZH_Controls.Controls.UCBtnExt();
            this.btnSelect = new HZH_Controls.Controls.UCBtnExt();
            this.btnExit = new HZH_Controls.Controls.UCBtnExt();
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
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.BackgroundImage = global::APP_Form.Properties.Resources.设_置__1_;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetting.BtnBackColor = System.Drawing.Color.White;
            this.btnSetting.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.BtnForeColor = System.Drawing.Color.White;
            this.btnSetting.BtnText = null;
            this.btnSetting.ConerRadius = 5;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.EnabledMouseEffect = false;
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSetting.IsRadius = true;
            this.btnSetting.IsShowRect = true;
            this.btnSetting.IsShowTips = false;
            this.btnSetting.Location = new System.Drawing.Point(899, 5);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.RectColor = System.Drawing.Color.Transparent;
            this.btnSetting.RectWidth = 1;
            this.btnSetting.Size = new System.Drawing.Size(57, 52);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.TabStop = false;
            this.btnSetting.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSetting.TipsText = "";
            this.btnSetting.BtnClick += new System.EventHandler(this.btnSetting_BtnClick);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.BackgroundImage = global::APP_Form.Properties.Resources.单词__1_;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelect.BtnBackColor = System.Drawing.Color.White;
            this.btnSelect.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.BtnForeColor = System.Drawing.Color.White;
            this.btnSelect.BtnText = null;
            this.btnSelect.ConerRadius = 5;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.EnabledMouseEffect = false;
            this.btnSelect.FillColor = System.Drawing.Color.Transparent;
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSelect.IsRadius = true;
            this.btnSelect.IsShowRect = true;
            this.btnSelect.IsShowTips = false;
            this.btnSelect.Location = new System.Drawing.Point(828, 0);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RectColor = System.Drawing.Color.Transparent;
            this.btnSelect.RectWidth = 1;
            this.btnSelect.Size = new System.Drawing.Size(58, 61);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.TabStop = false;
            this.btnSelect.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSelect.TipsText = "";
            this.btnSelect.BtnClick += new System.EventHandler(this.btnSelect_BtnClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::APP_Form.Properties.Resources.退出__1_;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.BtnBackColor = System.Drawing.Color.White;
            this.btnExit.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.BtnForeColor = System.Drawing.Color.White;
            this.btnExit.BtnText = null;
            this.btnExit.ConerRadius = 5;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.EnabledMouseEffect = false;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.IsRadius = true;
            this.btnExit.IsShowRect = true;
            this.btnExit.IsShowTips = false;
            this.btnExit.Location = new System.Drawing.Point(968, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.RectColor = System.Drawing.Color.Transparent;
            this.btnExit.RectWidth = 1;
            this.btnExit.Size = new System.Drawing.Size(51, 52);
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnExit.TipsText = "";
            this.btnExit.BtnClick += new System.EventHandler(this.btnExit_BtnClick);
            // 
            // TrialMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 698);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.tvMenu);
            this.Name = "TrialMain";
            this.ShowInTaskbar = true;
            this.Text = "TrialMain";
            this.Load += new System.EventHandler(this.TrialMain_Load);
            this.Shown += new System.EventHandler(this.TrialMain_Shown);
            this.Controls.SetChildIndex(this.tvMenu, 0);
            this.Controls.SetChildIndex(this.panControl, 0);
            this.Controls.SetChildIndex(this.btnSetting, 0);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.TreeViewEx tvMenu;
        private System.Windows.Forms.Panel panControl;
        private HZH_Controls.Controls.UCBtnExt btnSetting;
        private HZH_Controls.Controls.UCBtnExt btnSelect;
        private HZH_Controls.Controls.UCBtnExt btnExit;
    }
}