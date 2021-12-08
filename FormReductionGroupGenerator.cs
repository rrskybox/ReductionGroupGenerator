using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Deployment.Application;
using System.Diagnostics;

namespace ReductionGroupGenerator
{
    public partial class FormReductionGroupGenerator : Form
    {
        const string AppSettingsFilename = "AppSettings.ini";
        const string OutAppSettingsFilename = "AppSettings.ini";

        public List<XElement> CalibrationLibs = new List<XElement>();

        public FormReductionGroupGenerator()
        {
            InitializeComponent();
            // Acquire the version information and put it in the form header
            try { this.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(); }
            catch { this.Text = " in Debug"; } //probably in debug, no version info available
            this.Text = "Reduction Group Generator V" + this.Text;
            CalibrationDirectoryBox.Text = Properties.Settings.Default.CalDirectory;
            AppSettingsDirBox.Text = Properties.Settings.Default.TSXDirectory;
            StartButton.BackColor = System.Drawing.Color.LightSeaGreen;
            CalDirBrowseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            AppSettingsDirBrowseButton.BackColor = System.Drawing.Color.LightSeaGreen;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.BackColor = System.Drawing.Color.LightSalmon;
            //Build Calibration libraries
            FrameCatalog fc = new FrameCatalog();
            List<FrameCatalog.ReductionLibrary> frcl = new List<FrameCatalog.ReductionLibrary>();
            fc.AcquireAndSort(CalibrationDirectoryBox.Text);
            foreach (string filter in fc.FlatGroupFilterList)
            {
                foreach (int exposure in fc.DarkGroupExposureList)
                {
                    //Note: Temperature converted to integer value
                    frcl.Add(fc.CompileLibrary(exposure, filter, Convert.ToInt16(TemperatureBox.SelectedItem.ToString()), BinningBox.SelectedItem.ToString()));
                }
            }
            //Write calibration libraries to appsettings.ini
            AppSettings.InsertAppSettings(frcl, AppSettingsDirBox.Text + "\\" + AppSettingsFilename, AppSettingsDirBox.Text + "\\" + OutAppSettingsFilename);
            StartButton.BackColor = System.Drawing.Color.LightSeaGreen;
            return;
        }

        private void CalDirBrowseButton_Click(object sender, EventArgs e)
        {
            CalDirBrowseButton.BackColor = System.Drawing.Color.LightSalmon;
            //Explore for calibration library directory
            CalDirBrowserDialog.SelectedPath = CalibrationDirectoryBox.Text;
            DialogResult dr1 = CalDirBrowserDialog.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                CalibrationDirectoryBox.Text = CalDirBrowserDialog.SelectedPath;
                Properties.Settings.Default.CalDirectory = CalDirBrowserDialog.SelectedPath;
            }
            FrameCatalog fc = new FrameCatalog();
            fc.AcquireAndSort(CalibrationDirectoryBox.Text);
            foreach (string b in fc.BiasGroupBinningList)
                BinningBox.Items.Add(b);
            foreach (int t in fc.BiasGroupTemperatureList)
                TemperatureBox.Items.Add(t);
            BinningBox.SelectedIndex = 0;
            TemperatureBox.SelectedIndex = 0;
            Properties.Settings.Default.Save();
            CalDirBrowseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            Show();
        }

        private void AppSettingsDirBrowseButton_Click(object sender, EventArgs e)
        {
            AppSettingsDirBrowseButton.BackColor = System.Drawing.Color.LightSalmon;
            //Explore for AppSettings (Software Bisque) directory
            AppSettingsDirBrowserDialog.SelectedPath = AppSettingsDirBox.Text;
            DialogResult dr1 = AppSettingsDirBrowserDialog.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                AppSettingsDirBox.Text = AppSettingsDirBrowserDialog.SelectedPath;
                Properties.Settings.Default.TSXDirectory = AppSettingsDirBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
            AppSettingsDirBrowseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
