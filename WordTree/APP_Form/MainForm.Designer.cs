
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
            this.flowLayoutPanel_FormController.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Form
            // 
            this.panel_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Form.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_Form.Location = new System.Drawing.Point(0, -5);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(751, 628);
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
            this.flowLayoutPanel_FormController.Location = new System.Drawing.Point(0, 626);
            this.flowLayoutPanel_FormController.Name = "flowLayoutPanel_FormController";
            this.flowLayoutPanel_FormController.Size = new System.Drawing.Size(751, 113);
            this.flowLayoutPanel_FormController.TabIndex = 1;
            // 
            // button_MemoryTransfer
            // 
            this.button_MemoryTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_MemoryTransfer.Location = new System.Drawing.Point(3, 3);
            this.button_MemoryTransfer.Name = "button_MemoryTransfer";
            this.button_MemoryTransfer.Size = new System.Drawing.Size(181, 110);
            this.button_MemoryTransfer.TabIndex = 3;
            this.button_MemoryTransfer.Text = "记忆";
            this.button_MemoryTransfer.UseVisualStyleBackColor = true;
            // 
            // button_SearchTransfer
            // 
            this.button_SearchTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SearchTransfer.Location = new System.Drawing.Point(190, 3);
            this.button_SearchTransfer.Name = "button_SearchTransfer";
            this.button_SearchTransfer.Size = new System.Drawing.Size(181, 110);
            this.button_SearchTransfer.TabIndex = 0;
            this.button_SearchTransfer.Text = "查词";
            this.button_SearchTransfer.UseVisualStyleBackColor = true;
            this.button_SearchTransfer.Click += new System.EventHandler(this.button_SearchTransfer_Click);
            // 
            // button_HistoryTransfer
            // 
            this.button_HistoryTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_HistoryTransfer.Location = new System.Drawing.Point(377, 3);
            this.button_HistoryTransfer.Name = "button_HistoryTransfer";
            this.button_HistoryTransfer.Size = new System.Drawing.Size(181, 110);
            this.button_HistoryTransfer.TabIndex = 1;
            this.button_HistoryTransfer.Text = "统计";
            this.button_HistoryTransfer.UseVisualStyleBackColor = true;
            // 
            // button_ReadingTransfer
            // 
            this.button_ReadingTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ReadingTransfer.Location = new System.Drawing.Point(564, 3);
            this.button_ReadingTransfer.Name = "button_ReadingTransfer";
            this.button_ReadingTransfer.Size = new System.Drawing.Size(181, 110);
            this.button_ReadingTransfer.TabIndex = 2;
            this.button_ReadingTransfer.Text = "阅读";
            this.button_ReadingTransfer.UseVisualStyleBackColor = true;
            this.button_ReadingTransfer.Click += new System.EventHandler(this.button_ReadingTransfer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 739);
            this.Controls.Add(this.flowLayoutPanel_FormController);
            this.Controls.Add(this.panel_Form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "WordTree";
            this.flowLayoutPanel_FormController.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_FormController;
        private System.Windows.Forms.Button button_MemoryTransfer;
        private System.Windows.Forms.Button button_SearchTransfer;
        private System.Windows.Forms.Button button_HistoryTransfer;
        private System.Windows.Forms.Button button_ReadingTransfer;
    }
}