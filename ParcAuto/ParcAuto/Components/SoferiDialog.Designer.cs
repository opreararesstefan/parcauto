
namespace ParcAuto.Components
{
    partial class SoferiDialog
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
            this.HomeBtn = new System.Windows.Forms.Button();
            this.DGV_Soferi = new System.Windows.Forms.DataGridView();
            this.DGVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVCat_Permis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDayOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Soferi)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(35, 36);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(132, 29);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DGV_Soferi
            // 
            this.DGV_Soferi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Soferi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVName,
            this.DGVId,
            this.DGVCat_Permis,
            this.DGVDayOfBirth});
            this.DGV_Soferi.Location = new System.Drawing.Point(35, 92);
            this.DGV_Soferi.Name = "DGV_Soferi";
            this.DGV_Soferi.Size = new System.Drawing.Size(715, 421);
            this.DGV_Soferi.TabIndex = 2;
            this.DGV_Soferi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Soferi_CellValueChanged);
            this.DGV_Soferi.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_Soferi_RowPostPaint);
            this.DGV_Soferi.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGV_Soferi_UserDeletingRow);
            // 
            // DGVName
            // 
            this.DGVName.DataPropertyName = "Names";
            this.DGVName.HeaderText = "Name";
            this.DGVName.Name = "DGVName";
            // 
            // DGVId
            // 
            this.DGVId.DataPropertyName = "ID";
            this.DGVId.HeaderText = "Id";
            this.DGVId.Name = "DGVId";
            this.DGVId.Visible = false;
            // 
            // DGVCat_Permis
            // 
            this.DGVCat_Permis.DataPropertyName = "Cat_Permis";
            this.DGVCat_Permis.HeaderText = "Categorii Permis";
            this.DGVCat_Permis.Name = "DGVCat_Permis";
            // 
            // DGVDayOfBirth
            // 
            this.DGVDayOfBirth.DataPropertyName = "DayOfBirth";
            this.DGVDayOfBirth.HeaderText = "Day of Birth";
            this.DGVDayOfBirth.Name = "DGVDayOfBirth";
            // 
            // SoferiDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 602);
            this.Controls.Add(this.DGV_Soferi);
            this.Controls.Add(this.HomeBtn);
            this.Name = "SoferiDialog";
            this.Text = "SoferiDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoferiDialog_FormClosing);
            this.Load += new System.EventHandler(this.SoferiDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Soferi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.DataGridView DGV_Soferi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCat_Permis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVDayOfBirth;
    }
}