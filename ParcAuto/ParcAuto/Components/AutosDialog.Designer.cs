
namespace ParcAuto.Components
{
    partial class AutosDialog
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
            this.DGVAutos = new System.Windows.Forms.DataGridView();
            this.DGVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(12, 23);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(132, 29);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DGVAutos
            // 
            this.DGVAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVID,
            this.DGVMarca,
            this.DGVModel,
            this.DGVYear});
            this.DGVAutos.Location = new System.Drawing.Point(91, 100);
            this.DGVAutos.Name = "DGVAutos";
            this.DGVAutos.Size = new System.Drawing.Size(622, 302);
            this.DGVAutos.TabIndex = 1;
            this.DGVAutos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAutos_CellValueChanged);
            this.DGVAutos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGVAutos_RowPostPaint);
            this.DGVAutos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGVAutos_UserDeletingRow);
            // 
            // DGVID
            // 
            this.DGVID.DataPropertyName = "ID";
            this.DGVID.HeaderText = "Id";
            this.DGVID.Name = "DGVID";
            this.DGVID.Visible = false;
            // 
            // DGVMarca
            // 
            this.DGVMarca.DataPropertyName = "Marca";
            this.DGVMarca.HeaderText = "Marca";
            this.DGVMarca.Name = "DGVMarca";
            // 
            // DGVModel
            // 
            this.DGVModel.DataPropertyName = "Models";
            this.DGVModel.HeaderText = "Model";
            this.DGVModel.Name = "DGVModel";
            // 
            // DGVYear
            // 
            this.DGVYear.DataPropertyName = "Years";
            this.DGVYear.HeaderText = "Year";
            this.DGVYear.Name = "DGVYear";
            // 
            // AutosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVAutos);
            this.Controls.Add(this.HomeBtn);
            this.Name = "AutosDialog";
            this.Text = "AutosDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutosDialog_FormClosing);
            this.Load += new System.EventHandler(this.AutosDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.DataGridView DGVAutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVYear;
    }
}