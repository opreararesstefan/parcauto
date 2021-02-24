using System;
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
    public partial class SoferiDialog : Form
    {
        #region Properties

        public static bool FlagSoferi { get; set; } = false;

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

        #endregion

        #region C'tor

        /// <summary>
        /// C'tor
        /// </summary>
        public SoferiDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// HomeBtn_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            FlagSoferi = false;
            this.Close();
        }

        /// <summary>
        /// SoferiDialog_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoferiDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlagSoferi = false;
            Logging.ReportLogsInfo("Soferi Dialog Closed!!");
        }

        #endregion

        private void SoferiDialog_Load(object sender, EventArgs e)
        {
            var connect = Controller.ConnectDB();
            DGV_Soferi.DataSource = Controller.PopulateDataGridView(connect, "Soferi");
            Controller.CloseConnectionDb(connect);
            Controller.ResizeColumns(DGV_Soferi);
        }

        private void DGV_Soferi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Controller.PaintIdColumn(DGV_Soferi, sender, e);
        }

        private void DGV_Soferi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int actual = 0;
            var connect = Controller.ConnectDB();
            DataGridViewRow dgvReviziiRow = DGV_Soferi.CurrentRow;
            if (dgvReviziiRow != null)
            {
                SqlCommand sqlcmd = new SqlCommand("SoferiAddOrEdit", connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                if (dgvReviziiRow.Cells["DGVID"].Value == DBNull.Value)
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                else
                {
                    actual = Convert.ToInt32(dgvReviziiRow.Cells["DGVID"].Value);
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                }
                Logging.ReportLogsInfo("Modify " + Convert.ToString(actual) + " From Table Soferi");
                sqlcmd.Parameters.AddWithValue("@Names", Controller.DGVCEllVal(DGV_Soferi, dgvReviziiRow, "DGVName"));
                sqlcmd.Parameters.AddWithValue("@Cat_Permis", Controller.DGVCEllVal(DGV_Soferi, dgvReviziiRow, "DGVCat_Permis"));
                sqlcmd.Parameters.AddWithValue("@DayOfBirth", Controller.DGVCEllVal(DGV_Soferi, dgvReviziiRow, "DGVDayOfBirth"));
                sqlcmd.ExecuteNonQuery();
                Controller.CloseConnectionDb(connect);
                Controller.ResizeColumns(DGV_Soferi);
            }
        }

        private void DGV_Soferi_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Controller.UserDeletingRow(DGV_Soferi, "Soferi", e);
            Controller.ResizeColumns(DGV_Soferi);
        }
    }
}
