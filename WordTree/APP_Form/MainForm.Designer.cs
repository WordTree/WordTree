
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
            this.button_MemoryTransfer = new System.Windows.Forms.Button();
            this.button_SearchTransfer = new System.Windows.Forms.Button();
            this.button_HistoryTransfer = new System.Windows.Forms.Button();
            this.button_ReadingTransfer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Form
            // 
            this.panel_Form.BackColor = System.Drawing.Color.White;
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Form.Location = new System.Drawing.Point(286, 0);
            this.panel_Form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(715, 651);
            this.panel_Form.TabIndex = 0;
            // 
            // button_MemoryTransfer
            // 
            this.button_MemoryTransfer.BackColor = System.Drawing.Color.Gainsboro;
            this.button_MemoryTransfer.FlatAppearance.BorderSize = 0;
            this.button_MemoryTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemoryTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_MemoryTransfer.ForeColor = System.Drawing.Color.DimGray;
            this.button_MemoryTransfer.Location = new System.Drawing.Point(0, 246);
            this.button_MemoryTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.button_MemoryTransfer.Name = "button_MemoryTransfer";
            this.button_MemoryTransfer.Size = new System.Drawing.Size(283, 82);
            this.button_MemoryTransfer.TabIndex = 3;
            this.button_MemoryTransfer.Text = "记忆";
            this.button_MemoryTransfer.UseVisualStyleBackColor = false;
            this.button_MemoryTransfer.Click += new System.EventHandler(this.button_MemoryTransfer_Click);
            // 
            // button_SearchTransfer
            // 
            this.button_SearchTransfer.BackColor = System.Drawing.Color.Gainsboro;
            this.button_SearchTransfer.FlatAppearance.BorderSize = 0;
            this.button_SearchTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SearchTransfer.ForeColor = System.Drawing.Color.DimGray;
            this.button_SearchTransfer.Location = new System.Drawing.Point(0, 0);
            this.button_SearchTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.button_SearchTransfer.Name = "button_SearchTransfer";
            this.button_SearchTransfer.Size = new System.Drawing.Size(283, 82);
            this.button_SearchTransfer.TabIndex = 0;
            this.button_SearchTransfer.Text = "词典";
            this.button_SearchTransfer.UseVisualStyleBackColor = false;
            this.button_SearchTransfer.Click += new System.EventHandler(this.button_SearchTransfer_Click);
            // 
            // button_HistoryTransfer
            // 
            this.button_HistoryTransfer.BackColor = System.Drawing.Color.Gainsboro;
            this.button_HistoryTransfer.FlatAppearance.BorderSize = 0;
            this.button_HistoryTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HistoryTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_HistoryTransfer.ForeColor = System.Drawing.Color.DimGray;
            this.button_HistoryTransfer.Location = new System.Drawing.Point(0, 82);
            this.button_HistoryTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.button_HistoryTransfer.Name = "button_HistoryTransfer";
            this.button_HistoryTransfer.Size = new System.Drawing.Size(283, 82);
            this.button_HistoryTransfer.TabIndex = 1;
            this.button_HistoryTransfer.Text = "统计";
            this.button_HistoryTransfer.UseVisualStyleBackColor = false;
            this.button_HistoryTransfer.Click += new System.EventHandler(this.button_HistoryTransfer_Click);
            // 
            // button_ReadingTransfer
            // 
            this.button_ReadingTransfer.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ReadingTransfer.FlatAppearance.BorderSize = 0;
            this.button_ReadingTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ReadingTransfer.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ReadingTransfer.ForeColor = System.Drawing.Color.DimGray;
            this.button_ReadingTransfer.Location = new System.Drawing.Point(0, 164);
            this.button_ReadingTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.button_ReadingTransfer.Name = "button_ReadingTransfer";
            this.button_ReadingTransfer.Size = new System.Drawing.Size(283, 82);
            this.button_ReadingTransfer.TabIndex = 2;
            this.button_ReadingTransfer.Text = "阅读";
            this.button_ReadingTransfer.UseVisualStyleBackColor = false;
            this.button_ReadingTransfer.Click += new System.EventHandler(this.button_ReadingTransfer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Controls.Add(this.button_SearchTransfer);
            this.flowLayoutPanel1.Controls.Add(this.button_HistoryTransfer);
            this.flowLayoutPanel1.Controls.Add(this.button_ReadingTransfer);
            this.flowLayoutPanel1.Controls.Add(this.button_MemoryTransfer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 651);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 651);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_Form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "WordTree";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.Button button_MemoryTransfer;
        private System.Windows.Forms.Button button_SearchTransfer;
        private System.Windows.Forms.Button button_HistoryTransfer;
        private System.Windows.Forms.Button button_ReadingTransfer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}