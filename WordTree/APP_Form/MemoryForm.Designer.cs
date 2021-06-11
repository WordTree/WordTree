
namespace APP_Form
{
    partial class MemoryForm
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
            this.panel_Lights = new System.Windows.Forms.Panel();
            this.label_meanZN = new System.Windows.Forms.Label();
            this.textBox_SpellingBox = new System.Windows.Forms.TextBox();
            this.button_CommitSpelling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_Lights
            // 
            this.panel_Lights.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Lights.Location = new System.Drawing.Point(0, 12);
            this.panel_Lights.Name = "panel_Lights";
            this.panel_Lights.Size = new System.Drawing.Size(776, 43);
            this.panel_Lights.TabIndex = 0;
            // 
            // label_meanZN
            // 
            this.label_meanZN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_meanZN.Location = new System.Drawing.Point(249, 99);
            this.label_meanZN.Name = "label_meanZN";
            this.label_meanZN.Size = new System.Drawing.Size(244, 45);
            this.label_meanZN.TabIndex = 1;
            this.label_meanZN.Text = "中文释义";
            this.label_meanZN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_SpellingBox
            // 
            this.textBox_SpellingBox.Location = new System.Drawing.Point(314, 147);
            this.textBox_SpellingBox.Name = "textBox_SpellingBox";
            this.textBox_SpellingBox.Size = new System.Drawing.Size(100, 21);
            this.textBox_SpellingBox.TabIndex = 2;
            // 
            // button_CommitSpelling
            // 
            this.button_CommitSpelling.Location = new System.Drawing.Point(329, 174);
            this.button_CommitSpelling.Name = "button_CommitSpelling";
            this.button_CommitSpelling.Size = new System.Drawing.Size(75, 23);
            this.button_CommitSpelling.TabIndex = 3;
            this.button_CommitSpelling.Text = "Commit";
            this.button_CommitSpelling.UseVisualStyleBackColor = true;
            this.button_CommitSpelling.Click += new System.EventHandler(this.button_CommitSpelling_Click);
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_CommitSpelling);
            this.Controls.Add(this.textBox_SpellingBox);
            this.Controls.Add(this.label_meanZN);
            this.Controls.Add(this.panel_Lights);
            this.Name = "MemoryForm";
            this.Text = "MemoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Lights;
        private System.Windows.Forms.Label label_meanZN;
        private System.Windows.Forms.TextBox textBox_SpellingBox;
        private System.Windows.Forms.Button button_CommitSpelling;
    }
}