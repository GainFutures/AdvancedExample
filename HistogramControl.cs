namespace OEC.API.Example
{
    /// <summary>
    ///     Histogram control. Draws price/volume histogram
    /// </summary>
    public partial class HistogramControl : BaseControl
    {
        /// <summary>
        ///     Current histogram contract
        /// </summary>
        private Contract _currentContract;

        /// <summary>
        ///     Current subscription
        /// </summary>
        private Subscription _currentSubscription;

        /// <summary>
        ///     Histogram control constructor
        /// </summary>
        public HistogramControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Prepares histogram event
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();

            OECClient.Global.OnHistogramReceived += OnHistogramReceived;
        }

        /// <summary>
        ///     Occurs when new contract selected
        /// </summary>
        /// <param name="contract">New contract</param>
        public void ChartSelectedContractChangedEventHandler(Contract contract)
        {
            //clears last subscription
            histogramChart.ClearHistogram();
            dgHistogram.DataSource = null;

            if (_currentSubscription != null)
                OECClient.Global.CancelSubscription(_currentSubscription);
            _currentSubscription = null;

            if (contract == null)
                return;

            _currentContract = contract;

            OECClient.Global.SubscribeHistogram(contract);
        }

        /// <summary>
        ///     Occurs when subscribed histogram received
        /// </summary>
        /// <param name="subscription"></param>
        /// <param name="histogram"></param>
        private void OnHistogramReceived(Subscription subscription, Histogram histogram)
        {
            // if current contract has been changed, received Histogram doesn't need to be shown
            if (_currentContract == null || subscription.Contract.ID != _currentContract.ID)
                return;

            if (histogram.Count == 0)
                return;

            _currentSubscription = subscription;

            HistEntry[] simpleHistogram = ConvertToSimpleHistogram(histogram);

            dgHistogram.DataSource = simpleHistogram;
            histogramChart.DrawHistogram(subscription.Contract.Name, simpleHistogram);
        }

        /// <summary>
        ///     Converts OEC API Histogram instance to array of HistEntry
        /// </summary>
        /// <param name="histogram"></param>
        /// <returns></returns>
        private HistEntry[] ConvertToSimpleHistogram(Histogram histogram)
        {
            var result = new HistEntry[histogram.Count];
            for (int i = 0; i < histogram.Count; i++)
            {
                result[i] = new HistEntry(i, histogram.GetPriceAt(i), histogram.GetVolumeAt(i));
            }
            return result;
        }
    }
}