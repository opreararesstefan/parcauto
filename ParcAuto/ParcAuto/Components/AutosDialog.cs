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
    public partial class AutosDialog : Form
    {
        #region Properties

        public static bool FlagAutos { get; set; } = false;


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

        public AutosDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            FlagAutos = false;
            this.Close();
        }

        private void AutosDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlagAutos = false;
            Logging.ReportLogsInfo("Auto Dialog Closed!!");
        }

        private void AutosDialog_Load(object sender, EventArgs e)
        {
            var connect = Controller.ConnectDB();
            DGVAutos.DataSource = Controller.PopulateDataGridView(connect, "Cars");
            Controller.CloseConnectionDb(connect);
            Controller.ResizeColumns(DGVAutos);
        }

        private void DGVAutos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Controller.UserDeletingRow(DGVAutos, "Cars", e);
            Controller.ResizeColumns(DGVAutos);
        }

        private void DGVAutos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            Controller.PaintIdColumn(DGVAutos, sender, e);
        }

        private void DGVAutos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int actual = 0;
            var connect = Controller.ConnectDB();
            DataGridViewRow dgvReviziiRow = DGVAutos.CurrentRow;
            if (dgvReviziiRow != null)
            {
                SqlCommand sqlcmd = new SqlCommand("CarsAddOrEdit", connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                if (dgvReviziiRow.Cells["DGVID"].Value == DBNull.Value)
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                else
                {
                    actual = Convert.ToInt32(dgvReviziiRow.Cells["DGVID"].Value);
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                }
                Logging.ReportLogsInfo("Modify " + Convert.ToString(actual) + " From Table Cars");
                sqlcmd.Parameters.AddWithValue("@Marca", Controller.DGVCEllVal(DGVAutos, dgvReviziiRow, "DGVMarca"));
                sqlcmd.Parameters.AddWithValue("@Model", Controller.DGVCEllVal(DGVAutos, dgvReviziiRow, "DGVModel"));
                sqlcmd.Parameters.AddWithValue("@Years", Controller.DGVCEllVal(DGVAutos, dgvReviziiRow, "DGVYear"));
                sqlcmd.ExecuteNonQuery();
                Controller.CloseConnectionDb(connect);
                Controller.ResizeColumns(DGVAutos);
            }
        }

        #endregion

    }
}
