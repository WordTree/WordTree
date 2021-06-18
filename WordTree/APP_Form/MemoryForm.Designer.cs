
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
            this.panel_Form = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_Lights
            // 
            this.panel_Lights.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_Lights.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Lights.Location = new System.Drawing.Point(0, 0);
            this.panel_Lights.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Lights.Name = "panel_Lights";
            this.panel_Lights.Size = new System.Drawing.Size(736, 66);
            this.panel_Lights.TabIndex = 0;
            // 
            // panel_Form
            // 
            this.panel_Form.BackColor = System.Drawing.Color.Silver;
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Form.Location = new System.Drawing.Point(0, 52);
            this.panel_Form.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(736, 585);
            this.panel_Form.TabIndex = 1;
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 637);
            this.Controls.Add(this.panel_Form);
            this.Controls.Add(this.panel_Lights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemoryForm";
            this.Text = "MemoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Lights;
        private System.Windows.Forms.Panel panel_Form;
    }
}