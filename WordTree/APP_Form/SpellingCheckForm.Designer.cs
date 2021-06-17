
namespace APP_Form
{
    partial class SpellingCheckForm
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
            this.label_MeanCN = new System.Windows.Forms.Label();
            this.textBox_Spelling = new System.Windows.Forms.TextBox();
            this.button_imply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MeanCN
            // 
            this.label_MeanCN.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_MeanCN.Location = new System.Drawing.Point(12, 9);
            this.label_MeanCN.Name = "label_MeanCN";
            this.label_MeanCN.Size = new System.Drawing.Size(484, 173);
            this.label_MeanCN.TabIndex = 0;
            this.label_MeanCN.Text = "中文释义";
            this.label_MeanCN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Spelling
            // 
            this.textBox_Spelling.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Spelling.Location = new System.Drawing.Point(80, 186);
            this.textBox_Spelling.Name = "textBox_Spelling";
            this.textBox_Spelling.Size = new System.Drawing.Size(324, 52);
            this.textBox_Spelling.TabIndex = 1;
            // 
            // button_imply
            // 
            this.button_imply.Location = new System.Drawing.Point(426, 185);
            this.button_imply.Name = "button_imply";
            this.button_imply.Size = new System.Drawing.Size(60, 49);
            this.button_imply.TabIndex = 2;
            this.button_imply.Text = "提示";
            this.button_imply.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SpellingCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_imply);
            this.Controls.Add(this.textBox_Spelling);
            this.Controls.Add(this.label_MeanCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpellingCheckForm";
            this.Text = "SpellingCheckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MeanCN;
        private System.Windows.Forms.TextBox textBox_Spelling;
        private System.Windows.Forms.Button button_imply;
        private System.Windows.Forms.Button button1;
    }
}