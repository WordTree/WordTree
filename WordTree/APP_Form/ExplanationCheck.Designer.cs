
namespace APP_Form
{
    partial class ExplanationCheck
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
            this.label_Word = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Explan1 = new System.Windows.Forms.Label();
            this.label_Explan2 = new System.Windows.Forms.Label();
            this.label_Explan3 = new System.Windows.Forms.Label();
            this.label_Explan4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Word
            // 
            this.label_Word.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Word.Location = new System.Drawing.Point(12, 9);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(481, 81);
            this.label_Word.TabIndex = 0;
            this.label_Word.Text = "Word";
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_Explan1);
            this.flowLayoutPanel1.Controls.Add(this.label_Explan2);
            this.flowLayoutPanel1.Controls.Add(this.label_Explan3);
            this.flowLayoutPanel1.Controls.Add(this.label_Explan4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(468, 247);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label_Explan1
            // 
            this.label_Explan1.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Explan1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Explan1.Location = new System.Drawing.Point(3, 3);
            this.label_Explan1.Margin = new System.Windows.Forms.Padding(3);
            this.label_Explan1.Name = "label_Explan1";
            this.label_Explan1.Size = new System.Drawing.Size(465, 56);
            this.label_Explan1.TabIndex = 0;
            this.label_Explan1.Text = "释义一";
            // 
            // label_Explan2
            // 
            this.label_Explan2.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Explan2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Explan2.Location = new System.Drawing.Point(3, 65);
            this.label_Explan2.Margin = new System.Windows.Forms.Padding(3);
            this.label_Explan2.Name = "label_Explan2";
            this.label_Explan2.Size = new System.Drawing.Size(465, 56);
            this.label_Explan2.TabIndex = 1;
            this.label_Explan2.Text = "释义二";
            // 
            // label_Explan3
            // 
            this.label_Explan3.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Explan3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Explan3.Location = new System.Drawing.Point(3, 127);
            this.label_Explan3.Margin = new System.Windows.Forms.Padding(3);
            this.label_Explan3.Name = "label_Explan3";
            this.label_Explan3.Size = new System.Drawing.Size(465, 56);
            this.label_Explan3.TabIndex = 2;
            this.label_Explan3.Text = "释义三";
            // 
            // label_Explan4
            // 
            this.label_Explan4.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Explan4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Explan4.Location = new System.Drawing.Point(3, 189);
            this.label_Explan4.Margin = new System.Windows.Forms.Padding(3);
            this.label_Explan4.Name = "label_Explan4";
            this.label_Explan4.Size = new System.Drawing.Size(465, 56);
            this.label_Explan4.TabIndex = 3;
            this.label_Explan4.Text = "释义四";
            // 
            // ExplanationCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 352);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label_Word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExplanationCheck";
            this.Text = "ExplanationCheck";
            this.Load += new System.EventHandler(this.ExplanationCheck_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Word;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_Explan1;
        private System.Windows.Forms.Label label_Explan2;
        private System.Windows.Forms.Label label_Explan3;
        private System.Windows.Forms.Label label_Explan4;
    }
}