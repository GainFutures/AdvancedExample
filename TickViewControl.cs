using System;
using System.Collections.Generic;

namespace OEC.API.Example
{
    /// <summary>
    ///     Tick View: shows how to subscribe to tick subscriptions and handle tick responses
    /// </summary>
    public partial class TickViewControl : BaseControl
    {
        private readonly List<TickEntry> _tickEntries = new List<TickEntry>();
        private Subscription _tickSubscription;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public TickViewControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Prepares tick control events
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnTicksReceived += Global_OnTicksReceived;
        }

        private void Global_OnTicksReceived(Subscription subscription, Ticks ticks)
        {
            if (cbSymbol.SelectedContract == null)
                return;

            if (_tickSubscription == null || _tickSubscription.ID != subscription.ID)
                return;

            if (ticks.PriceList.Length == 0)
                return;

            TickEntry[] tickTable = TickEntry.TickEntryConverter(ticks);
            _tickEntries.AddRange(tickTable);
            if (_tickEntries.Count > 0 && _tickEntries[_tickEntries.Count - 1].TimeStamp < tickTable[0].TimeStamp)
            {
                _tickEntries.Sort((x, y) => x.TimeStamp.CompareTo(y.TimeStamp));
            }
            dgTicks.DataSource = null;
            dgTicks.DataSource = _tickEntries;
        }

        private void cbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_tickSubscription != null)
            {
                OECClient.Global.CancelSubscription(_tickSubscription);
                _tickSubscription = null;
                _tickEntries.Clear();
            }

            dgTicks.DataSource = null;

            if (cbSymbol.SelectedContract == null)
                return;

            _tickSubscription = OECClient.Global.SubscribeTicks(cbSymbol.SelectedContract,
                DateTime.UtcNow.AddMinutes(-10));
        }
    }

    /// <summary>
    ///     Represent tick for visualization
    /// </summary>
    public class TickEntry
    {
        private readonly float _askPrice;
        private readonly float _bidPrice;
        private readonly float _price;
        private readonly uint _volume;
        private DateTime _timestamp;

        /// <summary>
        ///     Creates tick entry
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="price"></param>
        /// <param name="volume"></param>
        /// <param name="bidPrice"></param>
        /// <param name="askPrice"></param>
        public TickEntry(DateTime timestamp, float price, uint volume, float bidPrice, float askPrice)
        {
            _timestamp = timestamp;
            _price = price;
            _volume = volume;
            _askPrice = askPrice;
            _bidPrice = bidPrice;
        }

        /// <summary>
        ///     Tick timestamp
        /// </summary>
        public DateTime TimeStamp
        {
            get { return _timestamp.ToLocalTime(); }
        }

        /// <summary>
        ///     Tick price
        /// </summary>
        public float Price
        {
            get { return _price; }
        }

        /// <summary>
        ///     Tick volume
        /// </summary>
        public uint Volume
        {
            get { return _volume; }
        }

        /// <summary>
        ///     Bid price at the time of tick
        /// </summary>
        public float BidPrice
        {
            get { return _bidPrice; }
        }

        /// <summary>
        ///     Ask price at the time of tick
        /// </summary>
        public float AskPrice
        {
            get { return _askPrice; }
        }

        /// <summary>
        ///     Converts OEC API ticks to internal tick entries
        /// </summary>
        /// <param name="ticks"></param>
        /// <returns></returns>
        public static TickEntry[] TickEntryConverter(Ticks ticks)
        {
            var result = new TickEntry[ticks.PriceList.Length];
            for (int i = 0; i < ticks.PriceList.Length; ++i)
                result[i] = new TickEntry(ticks.TimestampList[i].ToLocalTime(), ticks.PriceList[i],
                    (uint) ticks.VolumeList[i], ticks.BidPriceList[i], ticks.AskPriceList[i]);
            return result;
        }
    }
}