
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
            this.lblTargetDic = new System.Windows.Forms.Label();
            this.lblNeedNum = new System.Windows.Forms.Label();
            this.ckbPicture = new System.Windows.Forms.CheckBox();
            this.ckbChooseWord = new System.Windows.Forms.CheckBox();
            this.ckbRecite = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbTargetDic = new System.Windows.Forms.ComboBox();
            this.nudNeedNum = new System.Windows.Forms.NumericUpDown();
            this.btnAffirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeedNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTargetDic
            // 
            this.lblTargetDic.AutoSize = true;
            this.lblTargetDic.Location = new System.Drawing.Point(74, 63);
            this.lblTargetDic.Name = "lblTargetDic";
            this.lblTargetDic.Size = new System.Drawing.Size(67, 15);
            this.lblTargetDic.TabIndex = 0;
            this.lblTargetDic.Text = "目标词库";
            // 
            // lblNeedNum
            // 
            this.lblNeedNum.AutoSize = true;
            this.lblNeedNum.Location = new System.Drawing.Point(74, 110);
            this.lblNeedNum.Name = "lblNeedNum";
            this.lblNeedNum.Size = new System.Drawing.Size(82, 15);
            this.lblNeedNum.TabIndex = 1;
            this.lblNeedNum.Text = "每次学习量";
            // 
            // ckbPicture
            // 
            this.ckbPicture.AutoSize = true;
            this.ckbPicture.Location = new System.Drawing.Point(13, 24);
            this.ckbPicture.Name = "ckbPicture";
            this.ckbPicture.Size = new System.Drawing.Size(59, 19);
            this.ckbPicture.TabIndex = 2;
            this.ckbPicture.Text = "选图";
            this.ckbPicture.UseVisualStyleBackColor = true;
            // 
            // ckbChooseWord
            // 
            this.ckbChooseWord.AutoSize = true;
            this.ckbChooseWord.Location = new System.Drawing.Point(120, 24);
            this.ckbChooseWord.Name = "ckbChooseWord";
            this.ckbChooseWord.Size = new System.Drawing.Size(74, 19);
            this.ckbChooseWord.TabIndex = 3;
            this.ckbChooseWord.Text = "选释义";
            this.ckbChooseWord.UseVisualStyleBackColor = true;
            // 
            // ckbRecite
            // 
            this.ckbRecite.AutoSize = true;
            this.ckbRecite.Location = new System.Drawing.Point(227, 24);
            this.ckbRecite.Name = "ckbRecite";
            this.ckbRecite.Size = new System.Drawing.Size(59, 19);
            this.ckbRecite.TabIndex = 4;
            this.ckbRecite.Text = "默写";
            this.ckbRecite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbPicture);
            this.groupBox1.Controls.Add(this.ckbRecite);
            this.groupBox1.Controls.Add(this.ckbChooseWord);
            this.groupBox1.Location = new System.Drawing.Point(163, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(74, 158);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(67, 15);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "记忆方法";
            // 
            // cmbTargetDic
            // 
            this.cmbTargetDic.FormattingEnabled = true;
            this.cmbTargetDic.Items.AddRange(new object[] {
            "CET4",
            "CET6",
            "雅思",
            "托福",
            "GRE",
            "SAT"});
            this.cmbTargetDic.Location = new System.Drawing.Point(163, 60);
            this.cmbTargetDic.Name = "cmbTargetDic";
            this.cmbTargetDic.Size = new System.Drawing.Size(121, 23);
            this.cmbTargetDic.TabIndex = 6;
            // 
            // nudNeedNum
            // 
            this.nudNeedNum.Location = new System.Drawing.Point(163, 108);
            this.nudNeedNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudNeedNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNeedNum.Name = "nudNeedNum";
            this.nudNeedNum.Size = new System.Drawing.Size(120, 25);
            this.nudNeedNum.TabIndex = 7;
            this.nudNeedNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnAffirm
            // 
            this.btnAffirm.Location = new System.Drawing.Point(225, 237);
            this.btnAffirm.Name = "btnAffirm";
            this.btnAffirm.Size = new System.Drawing.Size(75, 23);
            this.btnAffirm.TabIndex = 8;
            this.btnAffirm.Text = "确认";
            this.btnAffirm.UseVisualStyleBackColor = true;
            this.btnAffirm.Click += new System.EventHandler(this.btnAffirm_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.btnAffirm);
            this.Controls.Add(this.nudNeedNum);
            this.Controls.Add(this.cmbTargetDic);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNeedNum);
            this.Controls.Add(this.lblTargetDic);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeedNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTargetDic;
        private System.Windows.Forms.Label lblNeedNum;
        private System.Windows.Forms.CheckBox ckbPicture;
        private System.Windows.Forms.CheckBox ckbChooseWord;
        private System.Windows.Forms.CheckBox ckbRecite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cmbTargetDic;
        private System.Windows.Forms.NumericUpDown nudNeedNum;
        private System.Windows.Forms.Button btnAffirm;
    }
}