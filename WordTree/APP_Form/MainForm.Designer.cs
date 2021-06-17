
namespace APP_Form
{
    partial class MainForm
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
            this.panel_Form = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_FormController = new System.Windows.Forms.FlowLayoutPanel();
            this.button_MemoryTransfer = new System.Windows.Forms.Button();
            this.button_SearchTransfer = new System.Windows.Forms.Button();
            this.button_HistoryTransfer = new System.Windows.Forms.Button();
            this.button_ReadingTransfer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            this.comboBox_Searcher = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_FormController.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Form
            // 
            this.panel_Form.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_Form.Location = new System.Drawing.Point(0, 73);
            this.panel_Form.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(1001, 706);
            this.panel_Form.TabIndex = 0;
            // 
            // flowLayoutPanel_FormController
            // 
            this.flowLayoutPanel_FormController.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel_FormController.Controls.Add(this.button_MemoryTransfer);
            this.flowLayoutPanel_FormController.Controls.Add(this.button_SearchTransfer);
            this.flowLayoutPanel_FormController.Controls.Add(this.button_HistoryTransfer);
            this.flowLayoutPanel_FormController.Controls.Add(this.button_ReadingTransfer);
            this.flowLayoutPanel_FormController.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_FormController.Location = new System.Drawing.Point(0, 783);
            this.flowLayoutPanel_FormController.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_FormController.Name = "flowLayoutPanel_FormController";
            this.flowLayoutPanel_FormController.Size = new System.Drawing.Size(1001, 141);
            this.flowLayoutPanel_FormController.TabIndex = 1;
            // 
            // button_MemoryTransfer
            // 
            this.button_MemoryTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_MemoryTransfer.Location = new System.Drawing.Point(4, 4);
            this.button_MemoryTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.button_MemoryTransfer.Name = "button_MemoryTransfer";
            this.button_MemoryTransfer.Size = new System.Drawing.Size(241, 138);
            this.button_MemoryTransfer.TabIndex = 3;
            this.button_MemoryTransfer.Text = "记忆";
            this.button_MemoryTransfer.UseVisualStyleBackColor = true;
            this.button_MemoryTransfer.Click += new System.EventHandler(this.button_MemoryTransfer_Click);
            // 
            // button_SearchTransfer
            // 
            this.button_SearchTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SearchTransfer.Location = new System.Drawing.Point(253, 4);
            this.button_SearchTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.button_SearchTransfer.Name = "button_SearchTransfer";
            this.button_SearchTransfer.Size = new System.Drawing.Size(241, 138);
            this.button_SearchTransfer.TabIndex = 0;
            this.button_SearchTransfer.Text = "查词";
            this.button_SearchTransfer.UseVisualStyleBackColor = true;
            this.button_SearchTransfer.Click += new System.EventHandler(this.button_SearchTransfer_Click);
            // 
            // button_HistoryTransfer
            // 
            this.button_HistoryTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_HistoryTransfer.Location = new System.Drawing.Point(502, 4);
            this.button_HistoryTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.button_HistoryTransfer.Name = "button_HistoryTransfer";
            this.button_HistoryTransfer.Size = new System.Drawing.Size(241, 138);
            this.button_HistoryTransfer.TabIndex = 1;
            this.button_HistoryTransfer.Text = "统计";
            this.button_HistoryTransfer.UseVisualStyleBackColor = true;
            // 
            // button_ReadingTransfer
            // 
            this.button_ReadingTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ReadingTransfer.Location = new System.Drawing.Point(751, 4);
            this.button_ReadingTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReadingTransfer.Name = "button_ReadingTransfer";
            this.button_ReadingTransfer.Size = new System.Drawing.Size(241, 138);
            this.button_ReadingTransfer.TabIndex = 2;
            this.button_ReadingTransfer.Text = "阅读";
            this.button_ReadingTransfer.UseVisualStyleBackColor = true;
            this.button_ReadingTransfer.Click += new System.EventHandler(this.button_ReadingTransfer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Search.Location = new System.Drawing.Point(272, 31);
            this.label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(52, 15);
            this.label_Search.TabIndex = 4;
            this.label_Search.Text = "查询：";
            // 
            // comboBox_Searcher
            // 
            this.comboBox_Searcher.FormattingEnabled = true;
            this.comboBox_Searcher.ItemHeight = 15;
            this.comboBox_Searcher.Location = new System.Drawing.Point(348, 28);
            this.comboBox_Searcher.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Searcher.Name = "comboBox_Searcher";
            this.comboBox_Searcher.Size = new System.Drawing.Size(257, 23);
            this.comboBox_Searcher.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 924);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.comboBox_Searcher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel_FormController);
            this.Controls.Add(this.panel_Form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "WordTree";
            this.flowLayoutPanel_FormController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_FormController;
        private System.Windows.Forms.Button button_MemoryTransfer;
        private System.Windows.Forms.Button button_SearchTransfer;
        private System.Windows.Forms.Button button_HistoryTransfer;
        private System.Windows.Forms.Button button_ReadingTransfer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.ComboBox comboBox_Searcher;
    }
}