using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     OEC API logs output window
    /// </summary>
    public partial class LogForm : Form
    {
        private static LogForm _logForm;

        /// <summary>
        ///     Creates OEC API logs output window
        /// </summary>
        public LogForm()
        {
            InitializeComponent();
            //Lets name main thread
            if (string.IsNullOrEmpty(Thread.CurrentThread.Name))
                Thread.CurrentThread.Name = "Main";
        }

        /// <summary>
        ///     Set up custom logger on load to ensure that logBox control is ready for output
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            Log.Initialize(new LogImpl(logBox));
            UpdateLoggingConfig();
        }

        /// <summary>
        ///     Shows log window
        /// </summary>
        public static void ShowLog()
        {
            if (_logForm == null)
                _logForm = new LogForm();
            _logForm.Show();
        }

        /// <summary>
        ///     To prevent form disposing
        /// </summary>
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
            base.OnClosing(e);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            logBox.Items.Clear();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void chbTransport_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLoggingConfig();
        }

        private void UpdateLoggingConfig()
        {
            var level = LogLevel.Core;
            if (chbApplication.Checked)
                level |= LogLevel.Application;
            if (chbPriceFeed.Checked)
                level |= LogLevel.Datafeed;
            if (chbTransport.Checked)
                level |= LogLevel.Transport;
            OECClient.Global.SetLoggingConfig(new LoggingConfiguration
            {
                Level = level,
                DataFeedLoggingInterval = TimeSpan.FromSeconds((int) edInterval.Value),
                DataFeedLogIndexNumber = (int) edIndexNum.Value
            });
        }

        private void edIndexNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateLoggingConfig();
        }

        private class LogImpl : ILogImpl
        {
            private const int MaxLogItems = 7000;
            private readonly ListBox _logBox;

            public LogImpl(ListBox logBox)
            {
                _logBox = logBox;
            }

            public void Start(string path)
            {
            }

            public void Stop()
            {
            }

            public void WriteLine(Severity severity, string format, params object[] args)
            {
                try
                {
                    string thread = Thread.CurrentThread.Name;
                    if (String.IsNullOrEmpty(thread))
                        thread = "System #" + Thread.CurrentThread.GetHashCode();

                    Log.ThreadContext.Current<OECClient>();
                    var level = Log.ThreadContext.Current<LogLevel>();
                    DateTime time = DateTime.Now;

                    // caller can be from diffrent thread
                    _logBox.BeginInvoke(new MethodInvoker(() =>
                    {
                        try
                        {
                            if (_logBox.Items.Count > MaxLogItems)
                                _logBox.Items.Clear();
                            _logBox.Items.Add(string.Format("{0}: {1} ({2}) {3}: {4}", time, severity, thread, level,
                                string.Format(format, args)));
                        }
                        catch
                        {
                            //should be handled here 
                        }
                    }));
                }
                catch
                {
                    //should be handled here 
                }
            }
        }
    }
}