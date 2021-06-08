
namespace Reader
{
    partial class UserTextChoice
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
            this.choice_comboBox_Searcher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choice_comboBox_Searcher
            // 
            this.choice_comboBox_Searcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choice_comboBox_Searcher.FormattingEnabled = true;
            this.choice_comboBox_Searcher.ItemHeight = 15;
            this.choice_comboBox_Searcher.Location = new System.Drawing.Point(96, 76);
            this.choice_comboBox_Searcher.Margin = new System.Windows.Forms.Padding(4);
            this.choice_comboBox_Searcher.Name = "choice_comboBox_Searcher";
            this.choice_comboBox_Searcher.Size = new System.Drawing.Size(257, 23);
            this.choice_comboBox_Searcher.TabIndex = 5;
            this.choice_comboBox_Searcher.SelectedIndexChanged += new System.EventHandler(this.choice_comboBox_Searcher_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择文段";
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(174, 174);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(92, 33);
            this.confirm_button.TabIndex = 3;
            this.confirm_button.Text = "确认";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // UserTextChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 250);
            this.Controls.Add(this.choice_comboBox_Searcher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(150, 150);
            this.Name = "UserTextChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserTextChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choice_comboBox_Searcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_button;
    }
}