using System;
using System.IO;
using ParcAuto.Components;
using System.Windows.Forms;

namespace ParcAuto
{
    public partial class ParcAuto : Form
    {
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

        private static string Log = @"C:\temp\Logs.txt";

        #endregion

        #region C'tor

        /// <summary>
        /// C'tor
        /// </summary>
        public ParcAuto()
        {
            InitializeComponent();
            if (File.Exists(Log))
                File.Delete(Log);
            Logging.StartLogs();
            Logging.ReportLogsInfo("App Loaded!");
        }

        #endregion

        #region Buttons

        /// <summary>
        /// ReviziiBtn_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviziiBtn_Click(object sender, EventArgs e)
        {
            ReviziiDialog form = new ReviziiDialog();
            if (!ReviziiDialog.FlagRevizii)
            {
                form.Show();
                ReviziiDialog.FlagRevizii = true;
                Logging.ReportLogsInfo("Revizii Dialog Loaded!!");
            }
            else
                form.Activate();
        }

        /// <summary>
        /// SoferiBtn_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoferiBtn_Click(object sender, EventArgs e)
        {
            SoferiDialog form = new SoferiDialog();
            if (!SoferiDialog.FlagSoferi)
            {
                form.Show();
                SoferiDialog.FlagSoferi = true;
                Logging.ReportLogsInfo("Soferi Dialog Loaded!!");
            }
            else
                form.Activate();
        }

        /// <summary>
        /// AutosBtn_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutosBtn_Click(object sender, EventArgs e)
        {
            AutosDialog form = new AutosDialog();
            if (!AutosDialog.FlagAutos)
            {
                form.Show();
                AutosDialog.FlagAutos = true;
                Logging.ReportLogsInfo("Auto Dialog Loaded!!");
            }
            else
                form.Activate();
        }

        /// <summary>
        /// FirstPage_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logging.ReportLogsInfo("App CLosed!!");
        }

        #endregion

    }
}
