
namespace APP_Form
{
    partial class FinishedForm
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
            this.lblString = new System.Windows.Forms.Label();
            this.pictureBox_Smile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Smile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblString
            // 
            this.lblString.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblString.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblString.Location = new System.Drawing.Point(254, 153);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(240, 80);
            this.lblString.TabIndex = 1;
            this.lblString.Text = "今日任务已完成\r\n小树茁壮成长！\r\n";
            this.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_Smile
            // 
            this.pictureBox_Smile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Smile.Enabled = false;
            this.pictureBox_Smile.Image = global::APP_Form.Properties.Resources.tree;
            this.pictureBox_Smile.Location = new System.Drawing.Point(167, 134);
            this.pictureBox_Smile.Name = "pictureBox_Smile";
            this.pictureBox_Smile.Size = new System.Drawing.Size(92, 80);
            this.pictureBox_Smile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Smile.TabIndex = 0;
            this.pictureBox_Smile.TabStop = false;
            // 
            // FinishedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 427);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.pictureBox_Smile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishedForm";
            this.Text = "FinishedForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Smile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Smile;
        private System.Windows.Forms.Label lblString;
    }
}