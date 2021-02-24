
namespace ParcAuto
{
    partial class ParcAuto
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
            this.ReviziiBtn = new System.Windows.Forms.Button();
            this.SoferiBtn = new System.Windows.Forms.Button();
            this.AutosBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReviziiBtn
            // 
            this.ReviziiBtn.Location = new System.Drawing.Point(585, 177);
            this.ReviziiBtn.Name = "ReviziiBtn";
            this.ReviziiBtn.Size = new System.Drawing.Size(122, 28);
            this.ReviziiBtn.TabIndex = 0;
            this.ReviziiBtn.Text = "Revizii";
            this.ReviziiBtn.UseVisualStyleBackColor = true;
            this.ReviziiBtn.Click += new System.EventHandler(this.ReviziiBtn_Click);
            // 
            // SoferiBtn
            // 
            this.SoferiBtn.Location = new System.Drawing.Point(347, 177);
            this.SoferiBtn.Name = "SoferiBtn";
            this.SoferiBtn.Size = new System.Drawing.Size(114, 28);
            this.SoferiBtn.TabIndex = 1;
            this.SoferiBtn.Text = "Soferi";
            this.SoferiBtn.UseVisualStyleBackColor = true;
            this.SoferiBtn.Click += new System.EventHandler(this.SoferiBtn_Click);
            // 
            // AutosBtn
            // 
            this.AutosBtn.Location = new System.Drawing.Point(86, 177);
            this.AutosBtn.Name = "AutosBtn";
            this.AutosBtn.Size = new System.Drawing.Size(134, 27);
            this.AutosBtn.TabIndex = 2;
            this.AutosBtn.Text = "Autos";
            this.AutosBtn.UseVisualStyleBackColor = true;
            this.AutosBtn.Click += new System.EventHandler(this.AutosBtn_Click);
            // 
            // ParcAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AutosBtn);
            this.Controls.Add(this.SoferiBtn);
            this.Controls.Add(this.ReviziiBtn);
            this.Name = "ParcAuto";
            this.Text = "Parc Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReviziiBtn;
        private System.Windows.Forms.Button SoferiBtn;
        private System.Windows.Forms.Button AutosBtn;
    }
}