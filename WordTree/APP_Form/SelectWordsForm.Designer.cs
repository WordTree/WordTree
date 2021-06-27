
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
            this.SuspendLayout();
            // 
            // ucTsfWords
            // 
            this.ucTsfWords.BackColor = System.Drawing.Color.White;
            this.ucTsfWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTsfWords.LeftColumns = new HZH_Controls.Controls.DataGridViewColumnEntity[0];
            this.ucTsfWords.LeftDataSource = new object[0];
            this.ucTsfWords.Location = new System.Drawing.Point(0, 0);
            this.ucTsfWords.Name = "ucTsfWords";
            this.ucTsfWords.RightColumns = new HZH_Controls.Controls.DataGridViewColumnEntity[0];
            this.ucTsfWords.RightDataSource = new object[0];
            this.ucTsfWords.Size = new System.Drawing.Size(812, 562);
            this.ucTsfWords.TabIndex = 0;
            this.ucTsfWords.Transfered += new HZH_Controls.Controls.TransferEventHandler(this.ucTsfWords_Transfered);
            // 
            // SelectWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.ucTsfWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectWordsForm";
            this.Text = "SelectWordsForm";
            this.Load += new System.EventHandler(this.SelectWordsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCTransfer ucTsfWords;
    }
}