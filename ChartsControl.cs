using System;

namespace OEC.API.Example
{
    /// <summary>
    ///     Current contract selection changed event handler
    /// </summary>
    /// <param name="contract">Newly selected contract</param>
    public delegate void ChartSelectedContractChangedEventHandler(Contract contract);

    /// <summary>
    ///     Charts control. Visualize contract OLHC price chart
    /// </summary>
    public partial class ChartsControl : BaseControl
    {
        /// <summary>
        ///     Chart control constructor
        /// </summary>
        public ChartsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Occurs when current selected contract changed
        /// </summary>
        public event ChartSelectedContractChangedEventHandler OnChartSelectedContractChanged;

        /// <summary>
        ///     Prepares price chart control events
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnBarsReceived += OnBarsReceived;
        }

        /// <summary>
        ///     Another contract selected
        /// </summary>
        private void cbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChartSelectedContractChanged(cbSymbol.SelectedContract);
            RefreshChart();
        }

        /// <summary>
        ///     Another time scale selected
        /// </summary>
        private void cbTimeScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshChart();
        }

        /// <summary>
        ///     Refreshes chart
        /// </summary>
        private void RefreshChart()
        {
            chart.ClearChart();
            dgBars.DataSource = null;

            if (cbSymbol.SelectedContract == null)
                return;

            float interval = float.Parse((string) cbTimeScale.SelectedItem);

            OECClient.Global.RequestBars(cbSymbol.SelectedContract,
                DateTime.UtcNow - TimeSpan.FromMinutes(interval*chart.IntervalCnt),
                DateTime.UtcNow, TimeSpan.FromMinutes(interval));
        }

        /// <summary>
        ///     Draws chart when Bars for selected contract received
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="bars"></param>
        private void OnBarsReceived(Subscription subscription, Bar[] bars)
        {
            if (cbSymbol.SelectedContract == null)
                return;

            if (cbSymbol.SelectedContract.ID != subscription.Contract.ID)
                return;

            if (bars.Length == 0)
                return;

            chart.DrawChart(subscription.Contract.Name, bars);
            BarEntry[] barTable = Array.ConvertAll(bars, BarEntry.BarEntryConverter);
            dgBars.DataSource = barTable;
        }
    }

    /// <summary>
    ///     Represent chart bar for visualization
    /// </summary>
    public class BarEntry
    {
        private readonly Bar _bar;

        /// <summary>
        ///     Creates bar entry from OEC API Bar
        /// </summary>
        /// <param name="bar"></param>
        public BarEntry(Bar bar)
        {
            _bar = bar;
        }

        /// <summary>
        ///     Bar close value
        /// </summary>
        public double Close
        {
            get { return _bar.Close; }
        }

        /// <summary>
        ///     Bar high value
        /// </summary>
        public double High
        {
            get { return _bar.High; }
        }

        /// <summary>
        ///     Bar low value
        /// </summary>
        public double Low
        {
            get { return _bar.Low; }
        }

        /// <summary>
        ///     Bar open value
        /// </summary>
        public double Open
        {
            get { return _bar.Open; }
        }

        /// <summary>
        ///     Bar time stamp
        /// </summary>
        public DateTime TimeStamp
        {
            get { return _bar.Timestamp.ToLocalTime(); }
        }

        /// <summary>
        ///     Converts OEC API bar to internal bar entry
        /// </summary>
        /// <param name="bar">OEC API Bar</param>
        /// <returns>Bar entry</returns>
        public static BarEntry BarEntryConverter(Bar bar)
        {
            return new BarEntry(bar);
        }
    }
}