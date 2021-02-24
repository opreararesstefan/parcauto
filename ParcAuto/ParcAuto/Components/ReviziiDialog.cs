using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcAuto.Components
{
    public partial class ReviziiDialog : Form
    {
        #region C'tor

        /// <summary>
        /// C'tor
        /// </summary>
        public ReviziiDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Controller
        /// </summary>
        public Controllers Controller
        {
            get
            {
                Controllers controllers = new Controllers();
                return controllers;
            }
        }

        /// <summary>
        /// FlagRevizii
        /// </summary>
        public static bool FlagRevizii { get; set; } = false;

        #endregion

        #region Methods

        /// <summary>
        /// HomeBtn_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            FlagRevizii = false;
            this.Close();
        }

        /// <summary>
        /// ReviziiDialog_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviziiDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlagRevizii = false;
            Logging.ReportLogsInfo("Revizii Dialog Closed!!");
        }

        /// <summary>
        /// ReviziiDialog_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviziiDialog_Load(object sender, EventArgs e)
        {
            var connect = Controller.ConnectDB();
            ReviziiDGridView.DataSource = Controller.PopulateDataGridView(connect, "Revizii");
            Controller.CloseConnectionDb(connect);
            Controller.ResizeColumns(ReviziiDGridView);
        }

        /// <summary>
        /// ReviziiDGridView_CellValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviziiDGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int actual = 0;
            var connect = Controller.ConnectDB();
            DataGridViewRow dgvReviziiRow = ReviziiDGridView.CurrentRow;
            if (dgvReviziiRow != null)
            {
                SqlCommand sqlcmd = new SqlCommand("ReviziiAddOrEdit", connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                if (dgvReviziiRow.Cells["DGVID"].Value == DBNull.Value)
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                else
                {
                    actual = Convert.ToInt32(dgvReviziiRow.Cells["DGVID"].Value);
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                }
                Logging.ReportLogsInfo("Modify " + Convert.ToString(actual) + " From Table Revizii");
                sqlcmd.Parameters.AddWithValue("@Last_Inspection", Controller.DGVCEllVal(ReviziiDGridView, dgvReviziiRow, "DGVLast_Inspection"));
                sqlcmd.Parameters.AddWithValue("@Next_Inspection", Controller.DGVCEllVal(ReviziiDGridView, dgvReviziiRow, "DGVNext_Inspection"));
                sqlcmd.Parameters.AddWithValue("@Km", Controller.DGVCEllVal(ReviziiDGridView, dgvReviziiRow, "DGVKm"));
                sqlcmd.Parameters.AddWithValue("@Car", Controller.DGVCEllVal(ReviziiDGridView, dgvReviziiRow, "DGVCar"));
                sqlcmd.ExecuteNonQuery();
                Controller.CloseConnectionDb(connect);
                Controller.ResizeColumns(ReviziiDGridView);
            }
        }

        /// <summary>
        /// ReviziiDGridView_UserDeletingRow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviziiDGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Controller.UserDeletingRow(ReviziiDGridView, "Revizii", e);
            Controller.ResizeColumns(ReviziiDGridView);
        }

        /// <summary>
        /// ReviziiDGridView_RowPostPaint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviziiDGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Controller.PaintIdColumn(ReviziiDGridView, sender, e);
        }

        #endregion

    }
}
