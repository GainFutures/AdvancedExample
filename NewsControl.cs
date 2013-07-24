namespace OEC.API.Example
{
    /// <summary>
    ///     News control. Displays incoming news messages
    /// </summary>
    public partial class NewsControl : BaseControl
    {
        /// <summary>
        ///     News control constructor
        /// </summary>
        public NewsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Prepares news control related events
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnLoginComplete += OnLoginComplete;
            OECClient.Global.OnNewsMessage += OnNewsMessage;
        }

        /// <summary>
        ///     Refresh news list when new message incomes
        /// </summary>
        private void OnNewsMessage(string channel, string message)
        {
            RefreshNews();
        }

        /// <summary>
        ///     Refresh news when login complete
        /// </summary>
        private void OnLoginComplete()
        {
            RefreshNews();
        }

        /// <summary>
        ///     Refreshes news list
        /// </summary>
        private void RefreshNews()
        {
            lbNews.Items.Clear();
            foreach (NewsMessage message in OECClient.Global.News)
            {
                string time = message.Timestamp.ToShortDateString() + " " + message.Timestamp.ToShortTimeString();
                lbNews.Items.Add(string.Format("{0} {1} : {2}", time, message.Channel, message.Message));
            }
        }
    }
}