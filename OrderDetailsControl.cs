using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Order details control. Displays details of current contract
    /// </summary>
    public partial class OrderDetailsControl : BaseControl
    {
        /// <summary>
        ///     list of order details
        /// </summary>
        private readonly List<OrderDetailsEntry> _list = new List<OrderDetailsEntry>(100);

        /// <summary>
        ///     Order details control constructor
        /// </summary>
        public OrderDetailsControl()
        {
            InitializeComponent();
            dgOrderDetails.DataSource = _list;
        }

        /// <summary>
        ///     Reacts to current Order changes and fullfills Order details table with new order details
        /// </summary>
        /// <param name="currentOrder">New selected order</param>
        public void CurrentOrderChangedEventHandler(Order currentOrder)
        {
            try
            {
                _list.Clear();

                if (currentOrder == null)
                    return;

                FullfillCommandsToOrderDetails(currentOrder);
                FullfillStatesToOrderDetails(currentOrder);
                FullfillFillsToOrderDetails(currentOrder);

                _list.Sort(OrderDetailsEntry.OrderDetailsComparer);
            }
            finally
            {
                BindingContext[dgOrderDetails.DataSource].Position = BindingContext[dgOrderDetails.DataSource].Count - 1;
                ((CurrencyManager) BindingContext[dgOrderDetails.DataSource]).Refresh();
            }
        }

        /// <summary>
        ///     Gets Fills from orders and adds them to order detail list
        /// </summary>
        /// <param name="currentOrder"></param>
        private void FullfillFillsToOrderDetails(Order currentOrder)
        {
            foreach (Fill fill in currentOrder.Fills)
                _list.Add(new OrderDetailsEntry(fill.Timestamp, fill.ID, ActionState.Fill, fill.ToString(),
                    fill.Comments));
        }

        /// <summary>
        ///     Gets States from orders and adds them to order detail list
        /// </summary>
        /// <param name="currentOrder"></param>
        private void FullfillStatesToOrderDetails(Order currentOrder)
        {
            foreach (State state in currentOrder.States)
                _list.Add(new OrderDetailsEntry(state.Timestamp, state.ID, ActionState.State,
                    state.OrderState.ToString(), state.Comments));
        }

        /// <summary>
        ///     Gets Commands from orders and adds them to order detail list
        /// </summary>
        /// <param name="currentOrder"></param>
        private void FullfillCommandsToOrderDetails(Order currentOrder)
        {
            foreach (Command command in currentOrder.Commands)
            {
                string comment = string.Empty;
                if (command.Version != null)
                {
                    comment = command.Version.ToString();
                    if (command.Type == CommandType.Modify)
                        comment = "To: " + comment;
                }
                _list.Add(new OrderDetailsEntry(command.Timestamp, command.ID, ActionState.Command,
                    command.Type.ToString(), comment));
            }
        }
    }

    /// <summary>
    ///     Order detail data source class.
    /// </summary>
    internal class OrderDetailsEntry
    {
        private readonly ActionState _action;
        private readonly string _comment = string.Empty;
        private readonly string _description = string.Empty;
        private readonly int _id = -1;
        private DateTime _timestamp;

        /// <summary>
        ///     Creates order detail instance
        /// </summary>
        /// <param name="timeStamp">Time of object event</param>
        /// <param name="id">Id of object</param>
        /// <param name="action">Action of object</param>
        /// <param name="description">Description of object</param>
        /// <param name="comment">Comment of object</param>
        public OrderDetailsEntry(DateTime timeStamp, int id, ActionState action, string description, string comment)
        {
            _timestamp = timeStamp;
            _id = id;
            _action = action;
            _description = description;
            _comment = comment;
        }

        /// <summary>
        ///     Time of order detail event object
        /// </summary>
        public DateTime TimeStamp
        {
            get { return _timestamp.ToLocalTime(); }
        }

        /// <summary>
        ///     Id of order detail object (in case of command - command id, in case of fill - fill id, and so on
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        ///     Action of order detail object
        /// </summary>
        public ActionState Action
        {
            get { return _action; }
        }

        /// <summary>
        ///     Desctiption of order detail object
        /// </summary>
        public string Description
        {
            get { return _description; }
        }

        /// <summary>
        ///     Comment of order detail object
        /// </summary>
        public string Comment
        {
            get { return _comment; }
        }

        /// <summary>
        ///     Compares instances
        /// </summary>
        /// <param name="x">left instance to compare</param>
        /// <param name="y">right instance to compare</param>
        /// <returns>1 - if left is more than right instance</returns>
        public static int OrderDetailsComparer(OrderDetailsEntry x, OrderDetailsEntry y)
        {
            int res = x.TimeStamp.CompareTo(y.TimeStamp);
            if (res == 0)
                res = x.Action.CompareTo(y.Action);
            if (res == 0)
                res = x.ID.CompareTo(y.ID);
            return res;
        }
    }

    /// <summary>
    ///     Order detail object state enumeration
    /// </summary>
    public enum ActionState
    {
        /// <summary>
        ///     Represent Order's command
        /// </summary>
        Command,

        /// <summary>
        ///     Represent Order's version
        /// </summary>
        Version,

        /// <summary>
        ///     Represent Order's state
        /// </summary>
        State,

        /// <summary>
        ///     Represent Order's fill
        /// </summary>
        Fill
    }
}