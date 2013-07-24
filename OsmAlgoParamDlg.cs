using System;
using System.Windows.Forms;
using OEC.API.OSM.Info;

namespace OEC.API.Example
{
    /// <summary>
    ///     Dialog that displays properties of an OSM algo param.
    /// </summary>
    public partial class OsmAlgoParamDlg : Form
    {
        /// <summary>
        ///     Creates an instance of OSM algo param dialog.
        /// </summary>
        public OsmAlgoParamDlg(AlgoParam paramInfo, string paramValue)
        {
            InitializeComponent();

            ParamInfo = paramInfo;
            ParamValue = paramValue;

            FillControls();
        }

        /// <summary>
        ///     Gets the value of an OSM algo param as a string.
        /// </summary>
        public string ParamValue { get; private set; }

        /// <summary>
        ///     Gets an information about OSM algo param.
        /// </summary>
        public AlgoParam ParamInfo { get; private set; }

        /// <summary>
        ///     Fills the dialog controls.
        /// </summary>
        private void FillControls()
        {
            edName.Text = ParamInfo.Name;
            edDescription.Text = ParamInfo.Description;
            edEnabled.Text = ParamInfo.Enabled ? "Yes" : "No";
            edModifiable.Text = ParamInfo.Modifiable ? "Yes" : "No";

            edDataType.Text = ParamInfo.DataDomain.DataType.ToString();
            edUnits.Text = ParamInfo.DataDomain.Units;
            edDefaultValue.Text = ParamInfo.DataDomain.Default.StringValue;
            edValue.Text = ParamValue;
        }

        /// <summary>
        ///     Validates the specified value according the data domain of OSM algo param.
        ///     If the value is invalid, an exception is thrown.
        /// </summary>
        private void ValidateParamValue(string paramValue)
        {
            var param = new OSM.AlgoParam(ParamInfo.Name, paramValue);
            ParamInfo.DataDomain.ValidateParam(param);
        }

        /// <summary>
        ///     Validates the param current value from UI control.
        /// </summary>
        private void btnValidateValue_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateParamValue(edValue.Text);

                string s = string.Format("Value \"{0}\" is correct.", edValue.Text);
                MessageBox.Show(s, "Valid value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                string s = string.Format("Value \"{0}\" is incorrect for the algo parameter.", edValue.Text);
                MessageBox.Show(s, "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Validates the param value when the dialog is being closing.
        /// </summary>
        private void OsmAlgoParamDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    ValidateParamValue(edValue.Text);
                    ParamValue = edValue.Text;
                }
                catch (Exception)
                {
                    string s = string.Format("Value \"{0}\" is incorrect for the algo parameter.", edValue.Text);
                    MessageBox.Show(s, "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}