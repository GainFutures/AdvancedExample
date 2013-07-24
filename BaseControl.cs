using System;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Base class for all controls in example
    /// </summary>
    public partial class BaseControl : UserControl
    {
        /// <summary>
        ///     Base control constructor
        /// </summary>
        public BaseControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Control's caption
        /// </summary>
        public string Caption
        {
            get { return lbCaption.Text; }
            set { lbCaption.Text = value; }
        }

        /// <summary>
        ///     Prepares handlers
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
                PrepareControlEventHandlers();
        }

        /// <summary>
        ///     Prepares derived control's event handlers
        /// </summary>
        protected virtual void PrepareControlEventHandlers()
        {
            //do nothing 
        }
    }
}