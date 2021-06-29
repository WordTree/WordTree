
namespace APP_Form
{
    partial class SelectWordsForm
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
            this.ucTsfWords = new HZH_Controls.Controls.UCTransfer();
            this.btnNext = new HZH_Controls.Controls.UCBtnExt();
            this.btnAffirm = new HZH_Controls.Controls.UCBtnExt();
            this.btnCancel = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // ucTsfWords
            // 
            this.ucTsfWords.BackColor = System.Drawing.Color.White;
            this.ucTsfWords.LeftColumns = new HZH_Controls.Controls.DataGridViewColumnEntity[0];
            this.ucTsfWords.LeftDataSource = new object[0];
            this.ucTsfWords.Location = new System.Drawing.Point(0, 0);
            this.ucTsfWords.Name = "ucTsfWords";
            this.ucTsfWords.RightColumns = new HZH_Controls.Controls.DataGridViewColumnEntity[0];
            this.ucTsfWords.RightDataSource = new object[0];
            this.ucTsfWords.Size = new System.Drawing.Size(812, 469);
            this.ucTsfWords.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BtnBackColor = System.Drawing.Color.White;
            this.btnNext.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.btnNext.BtnText = "下一批";
            this.btnNext.ConerRadius = 5;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.EnabledMouseEffect = false;
            this.btnNext.FillColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNext.IsRadius = true;
            this.btnNext.IsShowRect = true;
            this.btnNext.IsShowTips = false;
            this.btnNext.Location = new System.Drawing.Point(0, 467);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.RectColor = System.Drawing.Color.White;
            this.btnNext.RectWidth = 1;
            this.btnNext.Size = new System.Drawing.Size(269, 81);
            this.btnNext.TabIndex = 2;
            this.btnNext.TabStop = false;
            this.btnNext.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnNext.TipsText = "";
            this.btnNext.BtnClick += new System.EventHandler(this.btnNext_BtnClick);
            // 
            // btnAffirm
            // 
            this.btnAffirm.BackColor = System.Drawing.Color.White;
            this.btnAffirm.BtnBackColor = System.Drawing.Color.White;
            this.btnAffirm.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAffirm.BtnForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAffirm.BtnText = "确定";
            this.btnAffirm.ConerRadius = 5;
            this.btnAffirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAffirm.EnabledMouseEffect = false;
            this.btnAffirm.FillColor = System.Drawing.Color.White;
            this.btnAffirm.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAffirm.IsRadius = true;
            this.btnAffirm.IsShowRect = true;
            this.btnAffirm.IsShowTips = false;
            this.btnAffirm.Location = new System.Drawing.Point(271, 468);
            this.btnAffirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnAffirm.Name = "btnAffirm";
            this.btnAffirm.RectColor = System.Drawing.Color.White;
            this.btnAffirm.RectWidth = 1;
            this.btnAffirm.Size = new System.Drawing.Size(264, 81);
            this.btnAffirm.TabIndex = 3;
            this.btnAffirm.TabStop = false;
            this.btnAffirm.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAffirm.TipsText = "";
            this.btnAffirm.BtnClick += new System.EventHandler(this.btnAffirm_BtnClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BtnBackColor = System.Drawing.Color.White;
            this.btnCancel.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.BtnText = "取消";
            this.btnCancel.ConerRadius = 5;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.EnabledMouseEffect = false;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.IsRadius = true;
            this.btnCancel.IsShowRect = true;
            this.btnCancel.IsShowTips = false;
            this.btnCancel.Location = new System.Drawing.Point(538, 468);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.Color.White;
            this.btnCancel.RectWidth = 1;
            this.btnCancel.Size = new System.Drawing.Size(274, 81);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnCancel.TipsText = "";
            this.btnCancel.BtnClick += new System.EventHandler(this.btnCancel_BtnClick);
            // 
            // SelectWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 548);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAffirm);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.ucTsfWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectWordsForm";
            this.Load += new System.EventHandler(this.SelectWordsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCTransfer ucTsfWords;
        private HZH_Controls.Controls.UCBtnExt btnNext;
        private HZH_Controls.Controls.UCBtnExt btnAffirm;
        private HZH_Controls.Controls.UCBtnExt btnCancel;
    }
}