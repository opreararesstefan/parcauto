
namespace ParcAuto.Components
{
    partial class ReviziiDialog
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
            this.components = new System.ComponentModel.Container();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ReviziiDGridView = new System.Windows.Forms.DataGridView();
            this.DGVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVLast_Inspection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVNext_Inspection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableReviziiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcAutoDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcAutoDatabaseDataSet = new ParcAutoDatabaseDataSet();
            this.table_ReviziiTableAdapter = new ParcAutoDatabaseDataSetTableAdapters.Table_ReviziiTableAdapter();
            this.reviziiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReviziiDGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReviziiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcAutoDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcAutoDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviziiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(30, 32);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(132, 29);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ReviziiDGridView
            // 
            this.ReviziiDGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviziiDGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVID,
            this.DGVLast_Inspection,
            this.DGVNext_Inspection,
            this.DGVCar,
            this.DGVKm});
            this.ReviziiDGridView.Location = new System.Drawing.Point(152, 86);
            this.ReviziiDGridView.Name = "ReviziiDGridView";
            this.ReviziiDGridView.Size = new System.Drawing.Size(607, 352);
            this.ReviziiDGridView.TabIndex = 9;
            this.ReviziiDGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviziiDGridView_CellValueChanged);
            this.ReviziiDGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ReviziiDGridView_RowPostPaint);
            this.ReviziiDGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ReviziiDGridView_UserDeletingRow);
            // 
            // DGVID
            // 
            this.DGVID.DataPropertyName = "ID";
            this.DGVID.HeaderText = "ID";
            this.DGVID.Name = "DGVID";
            this.DGVID.Visible = false;
            // 
            // DGVLast_Inspection
            // 
            this.DGVLast_Inspection.DataPropertyName = "Last_Inspection";
            this.DGVLast_Inspection.HeaderText = "Last_Inspection";
            this.DGVLast_Inspection.Name = "DGVLast_Inspection";
            // 
            // DGVNext_Inspection
            // 
            this.DGVNext_Inspection.DataPropertyName = "Next_Inspection";
            this.DGVNext_Inspection.HeaderText = "Next_Inspection";
            this.DGVNext_Inspection.Name = "DGVNext_Inspection";
            // 
            // DGVCar
            // 
            this.DGVCar.DataPropertyName = "Car";
            this.DGVCar.HeaderText = "Car";
            this.DGVCar.Name = "DGVCar";
            // 
            // DGVKm
            // 
            this.DGVKm.DataPropertyName = "Km";
            this.DGVKm.HeaderText = "Km";
            this.DGVKm.Name = "DGVKm";
            // 
            // tableReviziiBindingSource
            // 
            this.tableReviziiBindingSource.DataMember = "Table_Revizii";
            this.tableReviziiBindingSource.DataSource = this.parcAutoDatabaseDataSetBindingSource;
            // 
            // parcAutoDatabaseDataSetBindingSource
            // 
            this.parcAutoDatabaseDataSetBindingSource.DataSource = this.parcAutoDatabaseDataSet;
            this.parcAutoDatabaseDataSetBindingSource.Position = 0;
            // 
            // parcAutoDatabaseDataSet
            // 
            this.parcAutoDatabaseDataSet.DataSetName = "ParcAutoDatabaseDataSet";
            this.parcAutoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_ReviziiTableAdapter
            // 
            this.table_ReviziiTableAdapter.ClearBeforeFill = true;
            // 
            // reviziiBindingSource
            // 
            this.reviziiBindingSource.DataMember = "Revizii";
            // 
            // ReviziiDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.ReviziiDGridView);
            this.Controls.Add(this.HomeBtn);
            this.Name = "ReviziiDialog";
            this.Text = "ReviziiDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviziiDialog_FormClosing);
            this.Load += new System.EventHandler(this.ReviziiDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReviziiDGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReviziiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcAutoDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcAutoDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviziiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.DataGridView ReviziiDGridView;
        private System.Windows.Forms.BindingSource parcAutoDatabaseDataSetBindingSource;
        private ParcAutoDatabaseDataSet parcAutoDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableReviziiBindingSource;
        private ParcAutoDatabaseDataSetTableAdapters.Table_ReviziiTableAdapter table_ReviziiTableAdapter;
        //private ParcAutoDatabaseDataSet1 parcAutoDatabaseDataSet1;
        private System.Windows.Forms.BindingSource reviziiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVLast_Inspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVNext_Inspection;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVKm;
    }
}