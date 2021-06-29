
namespace APP_Form
{
    partial class SettingForm
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
            this.cmbTargetDic = new HZH_Controls.Controls.UCCombox();
            this.ntbNeedNum = new HZH_Controls.Controls.UCNumTextBox();
            this.ucSplitLine_H2 = new HZH_Controls.Controls.UCSplitLine_H();
            this.btnAffrim = new HZH_Controls.Controls.UCBtnExt();
            this.lblTargetDic = new System.Windows.Forms.Label();
            this.lblNeedNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTargetDic
            // 
            this.cmbTargetDic.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetDic.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbTargetDic.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTargetDic.ConerRadius = 10;
            this.cmbTargetDic.DropPanelHeight = -1;
            this.cmbTargetDic.FillColor = System.Drawing.Color.White;
            this.cmbTargetDic.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbTargetDic.IsRadius = true;
            this.cmbTargetDic.IsShowRect = true;
            this.cmbTargetDic.ItemWidth = 70;
            this.cmbTargetDic.Location = new System.Drawing.Point(206, 103);
            this.cmbTargetDic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTargetDic.Name = "cmbTargetDic";
            this.cmbTargetDic.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cmbTargetDic.RectWidth = 1;
            this.cmbTargetDic.SelectedIndex = -1;
            this.cmbTargetDic.SelectedValue = "";
            this.cmbTargetDic.Size = new System.Drawing.Size(176, 33);
            this.cmbTargetDic.Source = null;
            this.cmbTargetDic.TabIndex = 8;
            this.cmbTargetDic.TextValue = "";
            this.cmbTargetDic.TriangleColor = System.Drawing.Color.RoyalBlue;
            // 
            // ntbNeedNum
            // 
            this.ntbNeedNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ntbNeedNum.InputType = HZH_Controls.TextInputType.Number;
            this.ntbNeedNum.IsNumCanInput = true;
            this.ntbNeedNum.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.ntbNeedNum.Location = new System.Drawing.Point(205, 193);
            this.ntbNeedNum.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ntbNeedNum.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ntbNeedNum.Name = "ntbNeedNum";
            this.ntbNeedNum.Num = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ntbNeedNum.Padding = new System.Windows.Forms.Padding(2);
            this.ntbNeedNum.Size = new System.Drawing.Size(176, 33);
            this.ntbNeedNum.TabIndex = 9;
            // 
            // ucSplitLine_H2
            // 
            this.ucSplitLine_H2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_H2.Location = new System.Drawing.Point(0, 292);
            this.ucSplitLine_H2.Name = "ucSplitLine_H2";
            this.ucSplitLine_H2.Size = new System.Drawing.Size(572, 1);
            this.ucSplitLine_H2.TabIndex = 10;
            this.ucSplitLine_H2.TabStop = false;
            // 
            // btnAffrim
            // 
            this.btnAffrim.BackColor = System.Drawing.Color.White;
            this.btnAffrim.BtnBackColor = System.Drawing.Color.White;
            this.btnAffrim.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAffrim.BtnForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAffrim.BtnText = "确定";
            this.btnAffrim.ConerRadius = 5;
            this.btnAffrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAffrim.EnabledMouseEffect = false;
            this.btnAffrim.FillColor = System.Drawing.Color.White;
            this.btnAffrim.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAffrim.IsRadius = true;
            this.btnAffrim.IsShowRect = true;
            this.btnAffrim.IsShowTips = false;
            this.btnAffrim.Location = new System.Drawing.Point(0, 296);
            this.btnAffrim.Margin = new System.Windows.Forms.Padding(0);
            this.btnAffrim.Name = "btnAffrim";
            this.btnAffrim.RectColor = System.Drawing.Color.White;
            this.btnAffrim.RectWidth = 1;
            this.btnAffrim.Size = new System.Drawing.Size(572, 65);
            this.btnAffrim.TabIndex = 11;
            this.btnAffrim.TabStop = false;
            this.btnAffrim.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAffrim.TipsText = "";
            this.btnAffrim.BtnClick += new System.EventHandler(this.btnAffrim_BtnClick);
            // 
            // lblTargetDic
            // 
            this.lblTargetDic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTargetDic.Location = new System.Drawing.Point(95, 103);
            this.lblTargetDic.Margin = new System.Windows.Forms.Padding(0);
            this.lblTargetDic.Name = "lblTargetDic";
            this.lblTargetDic.Size = new System.Drawing.Size(107, 33);
            this.lblTargetDic.TabIndex = 12;
            this.lblTargetDic.Text = "目标词库";
            this.lblTargetDic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNeedNum
            // 
            this.lblNeedNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNeedNum.Location = new System.Drawing.Point(82, 193);
            this.lblNeedNum.Margin = new System.Windows.Forms.Padding(0);
            this.lblNeedNum.Name = "lblNeedNum";
            this.lblNeedNum.Size = new System.Drawing.Size(120, 33);
            this.lblNeedNum.TabIndex = 13;
            this.lblNeedNum.Text = "每次学习量";
            this.lblNeedNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 359);
            this.Controls.Add(this.lblNeedNum);
            this.Controls.Add(this.lblTargetDic);
            this.Controls.Add(this.btnAffrim);
            this.Controls.Add(this.ucSplitLine_H2);
            this.Controls.Add(this.ntbNeedNum);
            this.Controls.Add(this.cmbTargetDic);
            this.IsShowCloseBtn = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Title = "设置";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.Controls.SetChildIndex(this.cmbTargetDic, 0);
            this.Controls.SetChildIndex(this.ntbNeedNum, 0);
            this.Controls.SetChildIndex(this.ucSplitLine_H2, 0);
            this.Controls.SetChildIndex(this.btnAffrim, 0);
            this.Controls.SetChildIndex(this.lblTargetDic, 0);
            this.Controls.SetChildIndex(this.lblNeedNum, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCCombox cmbTargetDic;
        private HZH_Controls.Controls.UCNumTextBox ntbNeedNum;
        private HZH_Controls.Controls.UCSplitLine_H ucSplitLine_H2;
        private HZH_Controls.Controls.UCBtnExt btnAffrim;
        private System.Windows.Forms.Label lblTargetDic;
        private System.Windows.Forms.Label lblNeedNum;
    }
}