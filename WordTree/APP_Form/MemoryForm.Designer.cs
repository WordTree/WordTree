
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryForm));
            this.panel_Lights = new System.Windows.Forms.Panel();
            this.label_meanZN = new System.Windows.Forms.Label();
            this.textBox_SpellingBox = new System.Windows.Forms.TextBox();
            this.button_CommitSpelling = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Lights
            // 
            this.panel_Lights.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Lights.Location = new System.Drawing.Point(0, 15);
            this.panel_Lights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Lights.Name = "panel_Lights";
            this.panel_Lights.Size = new System.Drawing.Size(1035, 54);
            this.panel_Lights.TabIndex = 0;
            // 
            // label_meanZN
            // 
            this.label_meanZN.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_meanZN.Location = new System.Drawing.Point(332, 124);
            this.label_meanZN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_meanZN.Name = "label_meanZN";
            this.label_meanZN.Size = new System.Drawing.Size(325, 56);
            this.label_meanZN.TabIndex = 1;
            this.label_meanZN.Text = "中文释义";
            this.label_meanZN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_SpellingBox
            // 
            this.textBox_SpellingBox.Location = new System.Drawing.Point(419, 184);
            this.textBox_SpellingBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_SpellingBox.Name = "textBox_SpellingBox";
            this.textBox_SpellingBox.Size = new System.Drawing.Size(132, 25);
            this.textBox_SpellingBox.TabIndex = 2;
            // 
            // button_CommitSpelling
            // 
            this.button_CommitSpelling.Location = new System.Drawing.Point(439, 218);
            this.button_CommitSpelling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_CommitSpelling.Name = "button_CommitSpelling";
            this.button_CommitSpelling.Size = new System.Drawing.Size(100, 29);
            this.button_CommitSpelling.TabIndex = 3;
            this.button_CommitSpelling.Text = "Commit";
            this.button_CommitSpelling.UseVisualStyleBackColor = true;
            this.button_CommitSpelling.Click += new System.EventHandler(this.button_CommitSpelling_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(837, 434);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "提示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button_CommitSpelling);
            this.Controls.Add(this.textBox_SpellingBox);
            this.Controls.Add(this.label_meanZN);
            this.Controls.Add(this.panel_Lights);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MemoryForm";
            this.Text = "MemoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Lights;
        private System.Windows.Forms.Label label_meanZN;
        private System.Windows.Forms.TextBox textBox_SpellingBox;
        private System.Windows.Forms.Button button_CommitSpelling;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
    }
}