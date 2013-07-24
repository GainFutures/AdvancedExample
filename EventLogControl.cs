using System;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Event log control. Displays order related events to log window
    /// </summary>
    public partial class EventLogControl : BaseControl
    {
        /// <summary>
        ///     Event log control constructor
        /// </summary>
        public EventLogControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Prepares events which must be logged
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnOrderConfirmed += Global_OnOrderConfirmed;
            OECClient.Global.OnOrderFilled += Global_OnOrderFilled;
            OECClient.Global.OnOrderStateChanged += Global_OnOrderStateChanged;
            OECClient.Global.OnCommandUpdated += Global_OnCommandUpdated;
        }

        /// <summary>
        ///     Writes to log when command updated
        /// </summary>
        /// <param name="order"></param>
        /// <param name="command"></param>
        private void Global_OnCommandUpdated(Order order, Command command)
        {
            PrintToEventLog(DateTime.UtcNow,
                string.Format("Command {0} for Order #{1} ({2}) updated", command, order.ID, order));
        }

        /// <summary>
        ///     Writes to log when order state changed
        /// </summary>
        /// <param name="order"></param>
        /// <param name="oldOrderState"></param>
        private void Global_OnOrderStateChanged(Order order, OrderState oldOrderState)
        {
            PrintToEventLog(DateTime.UtcNow,
                string.Format("State of Order #{0} ({1}) changed from {2} to {3}", order.ID, order, oldOrderState,
                    order.CurrentState));
        }

        /// <summary>
        ///     Writes to log when order filled
        /// </summary>
        /// <param name="order"></param>
        /// <param name="fill"></param>
        private void Global_OnOrderFilled(Order order, Fill fill)
        {
            PrintToEventLog(DateTime.UtcNow, string.Format("Order #{0} ({1}) filled : {2}", order.ID, order, fill));
        }

        /// <summary>
        ///     Writes to log when order confirmed
        /// </summary>
        /// <param name="order"></param>
        /// <param name="oldOrderID"></param>
        private void Global_OnOrderConfirmed(Order order, int oldOrderID)
        {
            PrintToEventLog(DateTime.UtcNow,
                string.Format("Order #{0} ({1}) confirmed. New Order #{2}", oldOrderID, order, order.ID));
        }

        /// <summary>
        ///     Writes custom message to log
        /// </summary>
        /// <param name="time">Time when event occured</param>
        /// <param name="message">Event message text</param>
        private void PrintToEventLog(DateTime time, string message)
        {
            edLog.Text = string.Format("{0} : {1}\r\n", time.ToLocalTime().ToString("HH:mm:ss.fff"), message) +
                         edLog.Text;
        }
    }
}